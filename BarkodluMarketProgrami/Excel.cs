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
            var workbook = new XLWorkbook();
            DateTime tarih = DateTime.Now;
            string dosyaYolu = System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"\\"+baslik + "-" + tarih.ToString("d") + ".xlsx";
            var worksheet = workbook.Worksheets.Add("Sayfa1");

            worksheet.Cell(1, 1).Value = baslik +" / "+ tarih.ToString();

            var titleRange = worksheet.Range(1, 1, 1, dataGridView.Columns.Count);
            titleRange.Merge();
            titleRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            titleRange.Style.Font.Bold = true;
            titleRange.Style.Font.FontSize = 16;
            titleRange.Style.Fill.BackgroundColor = XLColor.LightGray;

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
                    worksheet.Cell(i + 3, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                }
            }
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(dosyaYolu);
            MessageBox.Show("Excel dosyası başarıyla kaydedildi, "+ dosyaYolu, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
