using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace AmzBot.Classes.Other
{
    public class WriteFile
    {
        public void Txt(List<string> asinList)
        {

            string dosya_yolu = $@"{GetFolderPath(SpecialFolder.Desktop)}\" + asinList[0] + ".txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs;
            if (File.Exists(dosya_yolu))
            {
                fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
                fs.Close();

            }
            else
            {
                fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
                fs.Close();
            }

            // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            //StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            string errors = "";
            for (int i = 1; i < asinList.Count; i++)
            {
                if (asinList[i] != "")
                {
                    File.AppendAllText(dosya_yolu, Environment.NewLine + asinList[i]);
                    //sw.WriteLine(asinList[i]);
                }
            }


            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            //sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            //sw.Close();

            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }
        public void Txt(List<object> asinList)
        {

            string dosya_yolu = $@"{GetFolderPath(SpecialFolder.Desktop)}\" + asinList[0] + ".txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs;
            if (File.Exists(dosya_yolu))
            {
                fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
                fs.Close();

            }
            else
            {
                fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
                fs.Close();
            }

            // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            //StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            string errors = "";
            for (int i = 1; i < asinList.Count; i++)
            {
                if (asinList[i] != "")
                {
                    File.AppendAllText(dosya_yolu, Environment.NewLine + asinList[i]);
                    //sw.WriteLine(asinList[i]);
                }
            }


            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            //sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            //sw.Close();

            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }

        public void Error(Exception exception)
        {

            string dosya_yolu = $@"{GetFolderPath(SpecialFolder.Desktop)}\" + "AmazonLog.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs;
            if (File.Exists(dosya_yolu))
            {
                fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
                fs.Close();

            }
            else
            {
                fs = new FileStream(dosya_yolu, FileMode.Create, FileAccess.Write);
                fs.Close();
            }

            // FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            //StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            File.AppendAllText(dosya_yolu, Environment.NewLine + exception.Message + " ==> Date: =>" + DateTime.Now.ToLongDateString());
            //sw.WriteLine(asinList[i]);


            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            //sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            //sw.Close();

            //İşimiz bitince kullandığımız nesneleri iade ettik.

        }
    }
}
