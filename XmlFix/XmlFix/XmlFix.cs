using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;

namespace ZoranXmlFix
{
    /// <summary>
    /// The MIT License (MIT)
    /// Copyright(c) 2016 Zoran Petrović, zoran@zoran-software.com
    /// 
    /// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
    /// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
    /// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
    /// and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
    ///
    /// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
    /// of the Software.
    ///
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
    /// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
    /// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
    /// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
    /// DEALINGS IN THE SOFTWARE.
    /// </summary>
    public class XmlFix
    {
        /// <summary>
        /// Fixes the specified XML file.
        /// </summary>
        /// <param name="xmlFile">The XML file.</param>
        /// <param name="removeInvalidXmlChars">If set to <c>true</c> removes invalid XML characters.</param>
        /// <param name="convertToXmlCharReference">If set to <c>true</c> converts characters to XML character 
        /// reference.</param>
        /// <param name="convertNumbersWithExponents">If set to <c>true</c> converts numbers with exponents.</param>
        /// <param name="removeNonAsciiChars">If set to <c>true</c> removes non-ASCII chars.</param>
        /// <param name="prettyPrint">If set to <c>true</c> pretty prints.</param>
        /// <param name="generateXsd">If set to <c>true</c> generate XSD schema.</param>
        /// <param name="replacePairs">The replace pairs.</param>
        public static void Fix(string xmlFile, bool removeInvalidXmlChars, bool convertToXmlCharReference,
            bool convertNumbersWithExponents, bool removeNonAsciiChars, bool prettyPrint, bool generateXsd,
            List<Tuple<string, string>> replacePairs)
        {
            string folder = Path.GetDirectoryName(xmlFile);
            string file = Path.GetFileName(xmlFile);
            string newFile = Path.Combine(folder, "fixed-" + file);
            string text = File.ReadAllText(xmlFile);
            if (removeInvalidXmlChars)
            {
                text = RemoveInvalidXmlChars(text);
            }
            if (convertToXmlCharReference)
            {
                text = ConvertToXmlCharacterReference(text);
            }
            if (convertNumbersWithExponents)
            {
                text = ConvertNumbersWithExponents(text);
            }
            if (removeNonAsciiChars)
            {
                text = RemoveNonAsciiChars(text);
            }
            if (prettyPrint)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(text);
                xmlDocument.Save(newFile);
            }
            else
            {
                File.WriteAllText(newFile, text);
            }
            if (generateXsd)
            {
                GenerateXsdFromXml(newFile);
            }
            if (replacePairs.Count > 0)
            {
                ReplaceInFile(newFile, newFile + ".temp", replacePairs);
                File.Delete(newFile);
                File.Move(newFile + ".temp", newFile);
            }
        }

        /// <summary>
        /// Removes the invalid XML chars.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>The XML without invalid chars.</returns>
        public static string RemoveInvalidXmlChars(string xml)
        {
            // From xml spec valid chars: 
            // #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]     
            // any Unicode character, excluding the surrogate blocks, FFFE, and FFFF. 
            const string re = @"[^\x09\x0A\x0D\x20-\uD7FF\uE000-\uFFFD\u10000-\u10FFFF]";
            return Regex.Replace(xml, re, string.Empty);
        }

        /// <summary>
        /// Removes the non ASCII chars.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>The XML without ASCII chars.</returns>
        public static string RemoveNonAsciiChars(string xml)
        {
            const string re = @"[^\u0000-\u007F]";
            return Regex.Replace(xml, re, string.Empty);
        }

        /// <summary>
        /// Converts the numbers with exponents.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>The XML with converted numbers.</returns>
        public static string ConvertNumbersWithExponents(string xml)
        {
            //const string re = @"[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?";
            const string re = @"-?\d*\.?\d+e[+-]?\d+";
            return Regex.Replace(xml, re, delegate (Match match)
            {
                CultureInfo ci = CultureInfo.InvariantCulture;
                return double.Parse(match.ToString(), ci).ToString(ci);
            });
        }

        /// <summary>
        /// Generates the XSD from XML.
        /// </summary>
        /// <param name="xmlFile">The XML file.</param>
        public static void GenerateXsdFromXml(string xmlFile)
        {
            XmlReader reader = XmlReader.Create(xmlFile);
            XmlSchemaInference schema = new XmlSchemaInference();
            XmlSchemaSet schemaSet = schema.InferSchema(reader);
            int i = 0;
            foreach (XmlSchema s in schemaSet.Schemas())
            {
                string folder = Path.GetDirectoryName(xmlFile);
                string file = Path.GetFileNameWithoutExtension(xmlFile);
                string newFile = Path.Combine(folder, file) + "_" + i + ".xsd";
                i++;
                StreamWriter sw = new StreamWriter(newFile);
                s.Write(sw);
                sw.Close();
            }
        }

        /// <summary>
        /// Replaces the text in file.
        /// </summary>
        /// <param name="FilePath">The file path.</param>
        /// <param name="NewFilePath">The new file path.</param>
        /// <param name="replacePairs">The replace pairs.</param>
        private static void ReplaceInFile(string FilePath, string NewFilePath, List<Tuple<string, string>> replacePairs)
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                using (StreamWriter sw = new StreamWriter(NewFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string vLine = sr.ReadLine();
                        foreach (Tuple<string, string> pair in replacePairs)
                        {
                            vLine = vLine?.Replace(pair.Item1, pair.Item2);
                        }
                        sw.WriteLine(vLine);
                    }
                }
            }
        }

        /// <summary>
        /// Converts to XML character reference.
        /// </summary>
        /// <param name="xml">The XML.</param>
        /// <returns>Converted XML.</returns>
        public static string ConvertToXmlCharacterReference(string xml)
        {
            StringBuilder sb = new StringBuilder();
            const char charSpace = '\u0020'; // Anything lower than SPACE is a control character.
            const char charDelete = '\u007F'; // Anything above DELETE isn't ASCII, per se.
            const char charAmpersand = '\u0026'; // The ampersand character.
            const string cAmp = "&amp;";
            const String pre = "&#";
            string[] predef = { "&quot;", "&amp;", "&apos;", "&lt;", "&gt;", pre };
            int len = xml.Length;
            for (int i = 0; i < len; i++)
            {
                char ch = xml[i];
                bool isPrintableAscii = ch >= charSpace && ch <= charDelete;
                if (ch == charAmpersand)
                {
                    bool isPredef = false;
                    foreach (string p in predef)
                    {
                        if (xml.Substring(i, p.Length) == p)
                        {
                            isPredef = true;
                            break;
                        }
                    }
                    if (isPredef == false)
                    {
                        sb.Append(cAmp);
                    }
                }
                else if (isPrintableAscii)
                {
                    sb.Append(ch);
                }
                else
                {
                    sb.Append(pre).AppendFormat("x{0:X4};", (int)ch);
                }
            }
            string instance = sb.ToString();
            return instance;
        }
    }
}