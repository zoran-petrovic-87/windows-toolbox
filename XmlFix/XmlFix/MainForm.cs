using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

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
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private BackgroundWorker bwFix = new BackgroundWorker();
        private BackgroundWorker bwJoin = new BackgroundWorker();
        private FolderBrowserDialog xmlFolderDialog = new FolderBrowserDialog();
        private OpenFileDialog replaceInFilesValuesDialog = new OpenFileDialog();
        private string xmlFolder;
        private bool convertToXmlCharacterReference;
        private bool removeInvalidXmlChars;
        private bool convertNumbersWithExponents;
        private bool removeNonAsciiChars;
        private bool prettyPrint;
        private bool generateXsd;
        private List<Tuple<string, string>> replacePairs;

        public MainForm()
        {
            InitializeComponent();

            progressBarFix.Style = ProgressBarStyle.Continuous;
            bwFix.WorkerSupportsCancellation = true;
            bwFix.WorkerReportsProgress = true;
            bwFix.DoWork += new DoWorkEventHandler(bwFix_DoWork);
            bwFix.ProgressChanged += new ProgressChangedEventHandler(bwFix_ProgressChanged);
            bwFix.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwFix_RunWorkerCompleted);

            progressBarJoin.Style = ProgressBarStyle.Continuous;
            bwJoin.WorkerSupportsCancellation = true;
            bwJoin.WorkerReportsProgress = true;
            bwJoin.DoWork += new DoWorkEventHandler(bwJoin_DoWork);
            bwJoin.ProgressChanged += new ProgressChangedEventHandler(bwJoin_ProgressChanged);
            bwJoin.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwJoin_RunWorkerCompleted);
        }

        /// <summary>
        /// Handles the DoWork event of the bwFix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
        private void bwFix_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string[] files = Directory.GetFiles(xmlFolder, "*.xml", SearchOption.AllDirectories);
            int filesCount = files.Length;
            int i = 1;
            foreach (string file in files)
            {
                try
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    XmlFix.Fix(file, removeInvalidXmlChars, convertToXmlCharacterReference,
                        convertNumbersWithExponents, removeNonAsciiChars, prettyPrint, generateXsd, replacePairs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in " + file + Environment.NewLine + ex.Message, "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                int progress = (int) 100.0*i/filesCount;
                worker.ReportProgress(progress);
                i++;
                GC.Collect();
            }
        }

        /// <summary>
        /// Handles the ProgressChanged event of the bwFix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void bwFix_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarFix.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Handles the Click event of the btnFixCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFixCancel_Click(object sender, EventArgs e)
        {
            if (bwFix.WorkerSupportsCancellation)
            {
                bwFix.CancelAsync();
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the bwFix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void bwFix_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error!" + Environment.NewLine + e.Error.Message, "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnFixRun.Enabled = true;
            btnFixCancel.Enabled = false;
        }

        /// <summary>
        /// Runs the main task.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFixRun_Click(object sender, EventArgs e)
        {
            removeInvalidXmlChars = cbRemoveInvalidXmlChars.Checked;
            convertToXmlCharacterReference = cbConvertToXmlCharacterReference.Checked;
            convertNumbersWithExponents = cbConvertNumbersWithExponents.Checked;
            removeNonAsciiChars = cbRemoveNonAsciiChars.Checked;
            prettyPrint = cbPrettyPrint.Checked;
            generateXsd = cbGenerateXsd.Checked;
            replacePairs = new List<Tuple<string, string>>();
            foreach (DataGridViewRow row in dgvReplaceInFiles.Rows)
            {
                if (!row.IsNewRow)
                {
                    string replaceOldValue = row.Cells[colReplaceOldValue.Name].Value.ToString();
                    string replaceNewValue = row.Cells[colReplaceNewValue.Name].Value.ToString();
                    replacePairs.Add(new Tuple<string, string>(replaceOldValue, replaceNewValue));
                }
            }
            if (bwFix.IsBusy != true)
            {
                bwFix.RunWorkerAsync();
                btnFixRun.Enabled = false;
                btnFixCancel.Enabled = true;
                progressBarFix.Value = 0;
            }
        }

        /// <summary>
        /// Shows folder browser dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnOpenXml_Click(object sender, EventArgs e)
        {
            if (xmlFolderDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFolder = xmlFolderDialog.SelectedPath;
                lblXml.Text = xmlFolder;
            }
        }

        /// <summary>
        /// Loads "replace in files" values.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLoadReplaceInFilesValues_Click(object sender, EventArgs e)
        {
            if (replaceInFilesValuesDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(replaceInFilesValuesDialog.FileName);
                foreach (string line in lines)
                {
                    string[] items = line.Split('\t');
                    if (items.Length == 2)
                    {
                        dgvReplaceInFiles.Rows.Add(items[0], items[1]);
                    }
                }
                MessageBox.Show("Values are loaded!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the bwJoin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
        private void bwJoin_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            string[] files = Directory.GetFiles(xmlFolder, "*.xml", SearchOption.AllDirectories);
            int filesCount = files.Length;
            int i = 1;
            string newFile = Path.Combine(xmlFolder, "merged.xml");
            string rootElement = txtRootElement.Text;
            string rootAttributes = " " + txtJoinRootAttributes.Text;
            using (StreamWriter sw = new StreamWriter(newFile))
            {
                sw.Write("<?xml version='1.0' encoding='UTF-8'?>" + Environment.NewLine);
                sw.Write("<" + rootElement + rootAttributes + ">" + Environment.NewLine);
                foreach (string file in files)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    using (StreamReader sr = new StreamReader(file))
                    {
                        sw.Write(sr.ReadToEnd() + Environment.NewLine);
                    }
                    int progress = (int) 100.0*i/filesCount;
                    worker.ReportProgress(progress);
                    i++;
                    GC.Collect();
                }
                sw.Write("</" + rootElement + ">");
            }
        }

        /// <summary>
        /// Handles the ProgressChanged event of the bwJoin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void bwJoin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarJoin.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Handles the Click event of the btnJoinCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bwJoinCancel_Click(object sender, EventArgs e)
        {
            if (bwJoin.WorkerSupportsCancellation)
            {
                bwJoin.CancelAsync();
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the bwFix control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void bwJoin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error!" + Environment.NewLine + e.Error.Message, "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnJoinRun.Enabled = true;
            btnJoinCancel.Enabled = false;
        }

        /// <summary>
        /// Joins xml files into one file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnJoinRun_Click(object sender, EventArgs e)
        {
            if (bwJoin.IsBusy != true)
            {
                bwJoin.RunWorkerAsync();
                btnJoinRun.Enabled = false;
                btnJoinCancel.Enabled = true;
                progressBarJoin.Value = 0;
            }
        }
    }
}