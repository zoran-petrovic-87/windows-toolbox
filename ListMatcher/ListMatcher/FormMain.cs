using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace ListMatcher
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
    public partial class FormMain : Form
    {
        private readonly OpenFileDialog _ofdTsvList = new OpenFileDialog();
        private readonly SaveFileDialog _sfd = new SaveFileDialog();

        public FormMain()
        {
            InitializeComponent();
            splitContainer2.SplitterDistance = (int)(splitContainer2.ClientSize.Width * 0.5);
            dgvList1.ContextMenuStrip = new DataGridViewContextMenuStrip();
            dgvList2.ContextMenuStrip = new DataGridViewContextMenuStrip();
            dgvListResult.ContextMenuStrip = new DataGridViewContextMenuStrip();
        }

        /// <summary>
        /// Loads the values and metadata from a file into the List 1.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiTsvToList1_Click(object sender, EventArgs e)
        {
            LoadTsv(dgvList1, lblList1);
        }

        /// <summary>
        /// Loads the values and metadata from a file into the List 2.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiTsvToList2_Click(object sender, EventArgs e)
        {
            LoadTsv(dgvList2, lblList2);
        }

        /// <summary>
        /// Saves the values from the result into the file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiExportResultToTsv_Click(object sender, EventArgs e)
        {
            if (_sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow row in dgvListResult.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sb.Append(row.Cells[0].Value)
                            .Append("\t")
                            .Append(row.Cells[1].Value)
                            .Append("\t")
                            .Append(row.Cells[2].Value)
                            .Append("\t")
                            .Append(row.Cells[3].Value)
                            .AppendLine();
                    }
                }
                string outputFile = _sfd.FileName;
                if (!Path.HasExtension(outputFile))
                {
                    outputFile += ".tsv";
                }
                System.IO.File.WriteAllText(outputFile, sb.ToString());
                MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Shows the about message.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Matcher" + Environment.NewLine + Environment.NewLine
                            + "Author: Zoran Petrović (zoran@zoran-software.com)" + Environment.NewLine
                            + Environment.NewLine + "MIT licence", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Clears the List 1.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiClearList1_Click(object sender, EventArgs e)
        {
            dgvList1.Rows.Clear();
        }

        /// <summary>
        /// Clears the List 2.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiClearList2_Click(object sender, EventArgs e)
        {
            dgvList2.Rows.Clear();
        }

        /// <summary>
        /// Clears the results.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void tsmiClearResult_Click(object sender, EventArgs e)
        {
            dgvListResult.Rows.Clear();
        }

        /// <summary>
        /// Loads the tab-separated values file into the DataGridView control.
        /// </summary>
        /// <param name="dgv">The DataGridView control.</param>
        /// <param name="lbl">The label.</param>
        private void LoadTsv(DataGridView dgv, Label lbl)
        {
            try
            {
                if (_ofdTsvList.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(_ofdTsvList.FileName);
                    foreach (string line in lines)
                    {
                        string[] items = line.Split('\t');
                        if (items.Length == 2)
                        {
                            dgv.Rows.Add(items[0], items[1]);
                        }
                        else if (items.Length == 1)
                        {
                            dgv.Rows.Add(items[0], "");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbl.Text = _ofdTsvList.FileName;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row1 in dgvList1.Rows)
            {
                bool found = false;
                if (!row1.IsNewRow)
                {
                    Object val1 = row1.Cells[colList1Value.Name].Value;
                    Object meta1 = row1.Cells[colList1Metadata.Name].Value;
                    string sVal1 = val1.ToString();
                    string sMeta1 = "";
                    if (chkIgnoreTextCase.Checked)
                    {
                        sVal1 = sVal1.ToUpper();
                    }
                    if (meta1 != null)
                    {
                        sMeta1 = meta1.ToString();
                    }
                    foreach (DataGridViewRow row2 in dgvList2.Rows)
                    {
                        if (!row2.IsNewRow)
                        {
                            Object val2 = row2.Cells[colList2Value.Name].Value;
                            Object meta2 = row2.Cells[colList2Metadata.Name].Value;
                            string sVal2 = val2.ToString();
                            string sMeta2 = "";
                            if (chkIgnoreTextCase.Checked)
                            {
                                sVal2 = sVal2.ToUpper();
                            }
                            if (meta2 != null)
                            {
                                sMeta2 = meta2.ToString();
                            }
                            if (sVal1.Equals(sVal2))
                            {
                                found = true;
                                dgvListResult.Rows.Add(sVal1, sMeta1, sVal2, sMeta2);
                                break;
                            }
                        }
                    }
                    if (!found)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(dgvListResult, sVal1, sMeta1, txtNotFoundValue.Text, "");
                        dgvListResult.Rows.Add(row);
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}