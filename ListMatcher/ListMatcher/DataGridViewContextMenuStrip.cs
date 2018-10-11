// Author : Zoran Petrović
// Email  : zoran@zoran-software.com
// Year   : 2015.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ListMatcher.Properties;

namespace ListMatcher
{
    /// <summary>
    /// Generic ContextMenuStrip for DataGridView control.
    /// </summary>
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public class DataGridViewContextMenuStrip : ContextMenuStrip
    {
        private readonly SaveFileDialog _exportFileDialog = new SaveFileDialog();
        private const string ExportFilter = "Text|*.txt";

        /// <summary>
        /// Creates a new class instance.
        /// </summary>
        public DataGridViewContextMenuStrip()
        {
            _exportFileDialog.Filter = ExportFilter;
            Initialize();
            this.Font = new Font("Segoe UI", 10);
        }

        /// <summary>
        /// Initialize.
        /// </summary>
        private void Initialize()
        {
            ToolStripMenuItem menuItemSelectAll = new ToolStripMenuItem("Select All");
            menuItemSelectAll.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_select_all");
            menuItemSelectAll.Click += menuItemSelectAll_Click;
            Items.Add(menuItemSelectAll);

            ToolStripMenuItem menuItemSelectColumn = new ToolStripMenuItem("Select column");
            menuItemSelectColumn.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_select_column");
            menuItemSelectColumn.Click += menuItemSelectColumn_Click;
            Items.Add(menuItemSelectColumn);

            ToolStripMenuItem menuItemInvertSelection = new ToolStripMenuItem("Invert selection");
            menuItemInvertSelection.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_invert_selection");
            menuItemInvertSelection.Click += menuItemInvertSelection_Click;
            Items.Add(menuItemInvertSelection);

            Items.Add(new ToolStripSeparator());

            ToolStripMenuItem menuItemCellColor1 = new ToolStripMenuItem("Cell color 1");
            menuItemCellColor1.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_color");
            menuItemCellColor1.Click += menuItemCellColor1_Click;
            menuItemCellColor1.BackColor = Color.DarkMagenta;
            menuItemCellColor1.ForeColor = Color.White;
            Items.Add(menuItemCellColor1);

            ToolStripMenuItem menuItemCellColor2 = new ToolStripMenuItem("Cell color 2");
            menuItemCellColor2.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_color");
            menuItemCellColor2.Click += menuItemCellColor2_Click;
            menuItemCellColor2.BackColor = Color.DarkGreen;
            menuItemCellColor2.ForeColor = Color.White;
            Items.Add(menuItemCellColor2);

            ToolStripMenuItem menuItemCellColorDefault = new ToolStripMenuItem("Cell color default");
            menuItemCellColorDefault.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_color");
            menuItemCellColorDefault.Click += menuItemCellColorDefault_Click;
            menuItemCellColorDefault.BackColor = Color.White;
            menuItemCellColorDefault.ForeColor = Color.Black;
            Items.Add(menuItemCellColorDefault);

            Items.Add(new ToolStripSeparator());

            ToolStripMenuItem menuItemDeleteSelectedRows = new ToolStripMenuItem("Delete selected rows");
            menuItemDeleteSelectedRows.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_delete_row");
            menuItemDeleteSelectedRows.Click += menuItemDeleteSelectedRows_Click;
            Items.Add(menuItemDeleteSelectedRows);

            Items.Add(new ToolStripSeparator());

            ToolStripMenuItem menuItemColumnsSize = new ToolStripMenuItem("Toggle column size");
            menuItemColumnsSize.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_toggle_column_size");
            menuItemColumnsSize.Click += menuItemColumnsSize_Click;
            Items.Add(menuItemColumnsSize);

            Items.Add(new ToolStripSeparator());

            ToolStripMenuItem menuItemExport = new ToolStripMenuItem("Export");
            menuItemExport.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_table_export");
            menuItemExport.Click += menuItemExport_Click;
            Items.Add(menuItemExport);

            ToolStripMenuItem menuItemCopy = new ToolStripMenuItem("Copy");
            menuItemCopy.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_copy");
            menuItemCopy.Click += menuItemCopy_Click;
            Items.Add(menuItemCopy);

            ToolStripMenuItem menuItemPaste = new ToolStripMenuItem("Paste");
            menuItemPaste.Image = (Image)Resources.ResourceManager.GetObject("icon_gui_paste");
            menuItemPaste.Click += menuItemPaste_Click;
            Items.Add(menuItemPaste);
        }

        #region Methods

        /// <summary>
        /// Selects all cells.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemSelectAll_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            dgv.SelectAll();
        }

        /// <summary>
        /// Selects all cells that are in the same column as previously selected cells.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemSelectColumn_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Selected)
                        {
                            for (int r = 0; r < dgv.RowCount; r++)
                            {
                                dgv[cell.ColumnIndex, r].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Inverts selection.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemInvertSelection_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Selected = !row.Selected;
            }
        }

        /// <summary>
        /// Sets selected cells color.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemCellColor1_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                if (!cell.OwningRow.IsNewRow)
                {
                    cell.Style.BackColor = Color.DarkMagenta;
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Sets selected cells color.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemCellColor2_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                if (!cell.OwningRow.IsNewRow)
                {
                    cell.Style.BackColor = Color.DarkGreen;
                    cell.Style.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Sets selected cells color.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemCellColorDefault_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                if (!cell.OwningRow.IsNewRow)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Deletes selected rows.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemDeleteSelectedRows_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                if (row.Selected && !row.IsNewRow)
                {
                    dgv.Rows.Remove(row);
                    i -= 1;
                }
            }
        }

        /// <summary>
        /// Toggles column size (fill, column header and all cells).
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemColumnsSize_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            if (dgv.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.Fill)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            }
            else if (dgv.AutoSizeColumnsMode == DataGridViewAutoSizeColumnsMode.ColumnHeader)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        /// <summary>
        /// Exports <c>DataGridView</c> data to the text file.
        /// </summary>
        /// <param name="dgv"><c>DataGridView</c> to export.</param>
        /// <param name="fileName">Export file name (file path).</param>
        private static void ExportText(DataGridView dgv, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            int rowCount = dgv.Rows.Count;
            int columnCount = dgv.Columns.Count;
            for (int i = 0; i < columnCount; i++)
            {
                writer.Write(dgv.Columns[i].HeaderText);
                if (i < columnCount - 1)
                {
                    writer.Write("\t");
                }
            }
            writer.WriteLine();
            for (int i = 0; i < rowCount; i++)
            {
                if (!dgv.Rows[i].IsNewRow)
                {
                    int cellCount = dgv.Rows[i].Cells.Count;
                    for (int j = 0; j < cellCount; j++)
                    {
                        writer.Write(dgv.Rows[i].Cells[j].EditedFormattedValue.ToString());
                        if (j < cellCount - 1)
                        {
                            writer.Write("\t");
                        }
                    }
                    if (i < rowCount - 1)
                    {
                        writer.WriteLine();
                    }
                }
            }
            writer.Close();
            writer.Dispose();
        }

        /// <summary>
        /// Shows export data dialog.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemExport_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            if (_exportFileDialog.ShowDialog(this.TopLevelControl) == DialogResult.OK)
            {
                try
                {
                    ExportText(dgv, _exportFileDialog.FileName);
                    MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Copies selected cells.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            if (dgv.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                // Add the selection to the clipboard.
                Clipboard.SetDataObject(dgv.GetClipboardContent() ?? new DataObject());
            }
        }

        /// <summary>
        /// Pastes data from clipboard into this <c>DataGridView</c>.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)(SourceControl);
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell firstCell = dgv.SelectedCells[0];
                int i = firstCell.RowIndex;
                string clipboardText = Clipboard.GetText();
                string[] textRows = clipboardText.Split('\n');
                foreach (string textRow in textRows)
                {
                    if (textRow.Length > 0)
                    {
                        DataGridViewRow dgvRow = dgv.Rows[i];
                        if (dgvRow.IsNewRow)
                        {
                            dgv.Rows.Add();
                            dgvRow = dgv.Rows[i];
                        }
                        if (textRow.Length > 0)
                        {
                            string[] textColumns = textRow.Split('\t');
                            int j = firstCell.ColumnIndex;
                            foreach (string text in textColumns)
                            {
                                string formattedText = text.TrimEnd('\r');
                                if (j > dgv.Columns.Count - 1)
                                {
                                    break;
                                }
                                DataGridViewCell cell = dgvRow.Cells[j];
                                if (cell.OwningColumn.GetType() == typeof(DataGridViewTextBoxColumn))
                                {
                                    cell.Value = formattedText;
                                }
                                else if (cell.OwningColumn.GetType() == typeof(DataGridViewComboBoxColumn))
                                {
                                    DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)cell;
                                    if (cb.Items.Contains(text))
                                    {
                                        cb.Value = formattedText;
                                    }
                                }
                                j++;
                            }
                        }
                        i++;
                    }
                }
            }
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}