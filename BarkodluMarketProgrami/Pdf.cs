using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;
using PageSize = iTextSharp.text.PageSize;
using Paragraph = iTextSharp.text.Paragraph;

namespace BarkodluMarketProgrami
{
    internal class Pdf
    {
        public Pdf(DataGridView dataGridView, string baslik)
        {
            try
            {
                Document dosya = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                string dosyaYolu = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + baslik + "-" + DateTime.Now.ToString("d") + ".pdf";
                PdfWriter.GetInstance(dosya, new FileStream(dosyaYolu, FileMode.Create));

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font fontBody = new Font(baseFont, 10);
                Font fontBold = new Font(baseFont, 12, Font.BOLD);
                dosya.Open();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    dosya.Add(new Paragraph("-------------------------------", fontBody));
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        string header = dataGridView.Columns[i].HeaderText;
                        string value = row.Cells[i].Value?.ToString() ?? "";
                        if (value == "True")
                        {
                            value = "Evet";
                        }
                        else if (value == "False")
                        {
                            value = "Hayır";
                        }
                        if (value.Length > 100) value = value.Substring(0, 97) + "...";
                        Paragraph p = new Paragraph($"{header}: {value}", fontBody);
                        dosya.Add(p);
                    }
                    dosya.Add(new Paragraph("\n"));
                }
                dosya.Close();
                DialogResult result = MessageBox.Show("PDF dosyası başarıyla kaydedildi. Açmak ister misiniz ? ", "Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("explorer.exe", dosyaYolu);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("PDF dosyası kaydedilirken bir hata oluştu: " + e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
