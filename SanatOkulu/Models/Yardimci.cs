using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanatOkulu.Models
{
    public class Yardimci
    {
        public static string ResimKaydet(string path)
        {
            FileInfo fi = new FileInfo(path);
            string uzanti = fi.Extension;
            string yeniDosyaAd = Guid.NewGuid().ToString() + uzanti;
            string resimlerDizini = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string kaydetDizini = Path.Combine(resimlerDizini, "SanatOkulu");
            string kaydetYol = Path.Combine(resimlerDizini, yeniDosyaAd);

            if (!Directory.Exists(kaydetDizini))
            {
                Directory.CreateDirectory(kaydetDizini);
            }

            File.Copy(path, kaydetYol);
            return null;
        }
    }
}
