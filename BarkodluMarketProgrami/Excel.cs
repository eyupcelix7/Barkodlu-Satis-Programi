using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    internal class Excel
    {
        public Excel(DataGridView dataGridView, string baslik)
        {
            try
            {
                var workbook = new XLWorkbook();
                DateTime tarih = DateTime.Now;
                string dosyaYolu = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + baslik + "-" + tarih.ToString("d") + ".xlsx";
                var worksheet = workbook.Worksheets.Add("Sayfa1");
                worksheet.Cell(1, 1).Value = baslik + " / " + tarih.ToString();
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count);
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count).Merge();
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count).Style.Font.Bold = true;
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count).Style.Font.FontSize = 16;
                worksheet.Range(1, 1, 1, dataGridView.Columns.Count).Style.Fill.BackgroundColor = XLColor.LightGray;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(2, i + 1).Value = dataGridView.Columns[i].HeaderText;
                    worksheet.Cell(2, i + 1).Style.Font.Bold = true;
                    worksheet.Cell(2, i + 1).Style.Font.FontSize = 12;
                }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if(dataGridView.Rows[i].Cells[j].Value?.ToString() == "True")
                        {
                            worksheet.Cell(i + 3, j + 1).Value = "Evet";
                        }
                        else if(dataGridView.Rows[i].Cells[j].Value?.ToString() == "False")
                        {
                            worksheet.Cell(i + 3, j + 1).Value = "Hayır";
                        }
                        else
                        {
                            worksheet.Cell(i + 3, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }

                    }
                }
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(dosyaYolu);
                DialogResult result = MessageBox.Show("Excel dosyası başarıyla kaydedildi. Açmak ister misiniz ? ", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", dosyaYolu);
                }
            }
            catch (Exception e) 
            { 
                MessageBox.Show("Excel dosyası kaydedilirken bir hata oluştu: " + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
