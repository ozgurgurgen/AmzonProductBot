using AmzBot.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzBot.Classes.Other
{
    public class ReadFile
    {
        public void Read()
        {
            string dosya_yolu = Resources.CanadaProductPage;
            Console.WriteLine("dosya yolu = " + dosya_yolu);
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
    }
}
