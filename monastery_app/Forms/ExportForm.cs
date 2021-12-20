using iTextSharp.text;
using iTextSharp.text.pdf;
using monastery_app.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class ExportForm : Form
    {
        AllModel<Users> user = new AllModel<Users>("Users");
        AllModel<Todoes> todo = new AllModel<Todoes>("Todoes");
        AllModel<Items> item = new AllModel<Items>("Items");
        AllModel<Offers> offer = new AllModel<Offers>("Offers");

        public string[] SelTB =
        {
            "Пользователи",
            "Задачи",
            "Товар",
            "Заказы",
        };

        public string[] SelEx =
        {
            "Excel",
            "PDF",
            "CSV",
            "WORD",
        };
        public ExportForm()
        {
            InitializeComponent();
            dataExport.ForeColor = Color.Black;
            GetTB();
            GetEX();
        }

        // choose
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataExport.DataSource = user.Objs;
                        dataExport.Refresh();
                    }
                    break;

                case 1:
                    {
                        dataExport.DataSource = todo.Objs;
                        dataExport.Refresh();
                    }
                    break;

                case 2:
                    {
                        dataExport.DataSource = item.Objs;
                        dataExport.Refresh();
                    }
                    break;

                case 3:
                    {
                        dataExport.DataSource = offer.Objs;
                        dataExport.Refresh();
                    }
                    break;
            }
        }

        // export
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        ExcepExport();
                    }
                    break;

                case 1:
                    {
                        PdfExport();
                    }
                    break;

                case 2:
                    {
                        CsvExport();
                    }
                    break;

                case 3:
                    {
                        SaveFileDialog sfd = new SaveFileDialog();

                        sfd.Filter = "Word Documents (.docx)|.docx";

                        sfd.FileName = "export.docx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            WordExport(dataExport, sfd.FileName);
                        }
                    }
                    break;
            }
        }

        // Back
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void GetTB()
        {
            comboBox1.Items.Add(SelTB[0]);
            comboBox1.Items.Add(SelTB[1]);
            comboBox1.Items.Add(SelTB[2]);
            comboBox1.Items.Add(SelTB[3]);
            comboBox1.SelectedIndex = 0;
        }

        private void GetEX()
        {
            comboBox2.Items.Add(SelEx[0]);
            comboBox2.Items.Add(SelEx[1]);
            comboBox2.Items.Add(SelEx[2]);
            comboBox2.Items.Add(SelEx[3]);
            comboBox2.SelectedIndex = 0;
        }

        // pdf export
        public void PdfExport()
        {
            if (dataExport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "PFDFile.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Записать данные на диск не удалось." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataExport.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataExport.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataExport.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Данные Успешно Экспортированы!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка :" + ex.Message);
                        }
                    }
                }
            }
        }

        // word export
        public void WordExport(DataGridView DGV, string filename)
        {
            if (dataExport.Rows.Count != 0)
            {
                int RowCount = dataExport.Rows.Count;
                int ColumnCount = dataExport.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = dataExport.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataExport.Columns[c].HeaderText;
                }

                //table style 
                //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        // csv export
        public void CsvExport()
        {
            if (dataExport.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataExport.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataExport.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataExport.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataExport.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataExport.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        // excel export
        public void ExcepExport()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                ws.Name = "Exported from gridview";

                ws.Rows.HorizontalAlignment = HorizontalAlignment.Center;
                for (int i = 1; i < dataExport.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataExport.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataExport.Rows.Count; i++)
                {
                    for (int j = 0; j < dataExport.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataExport.Rows[i].Cells[j].Value;
                    }
                }

                ws.Cells.EntireColumn.AutoFit();

                app.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
