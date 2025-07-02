using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluMarketProgrami
{
    internal class Yedekle
    {
        public Yedekle()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Veri Yedek Dosyası|0.bak";
            saveFileDialog.FileName = "Barkodlu Satış Programı-" + DateTime.Now.ToShortDateString();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    var dbHedef = saveFileDialog.FileName;
                    string dbKaynak = @"C:\dbs\Barkod.mdf";
                    using(var db = new BarkodEntities())
                    {
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "] TO DISK='" + dbHedef + "'";
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,cmd);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedekleme Tamamlandı","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                catch(Exception e)
                {
                        MessageBox.Show(e.ToString());
                }
            }
        }
    }
}
