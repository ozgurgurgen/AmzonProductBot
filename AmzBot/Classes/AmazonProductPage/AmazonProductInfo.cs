using AmzBot.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace AmzBot.Classes.AmazonProductPage
{
    public class AmazonProductInfo
    {
        List<string> asinList;
        List<object> productsInfos = new List<object>() { "" };
        IWebDriver driver;

        public AmazonProductInfo(List<string> asinList, IWebDriver driver)
        {
            this.asinList = asinList;
            this.driver = driver;
        }

        public List<object> Execute()
        {
            for (int i = 1; i < asinList.Count - 1; i++)
            {
                Open(asinList[i], "ca", i);
            }
            for (int i = 1; i < asinList.Count - 1; i++)
            {
                Open(asinList[i], "us", i);
            }
            return productsInfos;
        }

        public void Open(string asin, string countryCode, int step)
        {
            Console.WriteLine("GELEN ASIN: " + asin);
            //driver = new ChromeDriver();
            //driver.Manage().Window.Size = new System.Drawing.Size(1300, 680);
            var jsCode = "";
            if (countryCode.Equals("ca"))
            {
                string url = "https://www.amazon.ca/dp/" + asin;
                Console.WriteLine("Kanada URL: " + url);
                driver.Navigate().GoToUrl(url);
                jsCode = Resources.CanadaProductPage;
            }
            else if (countryCode.Equals("us"))
            {
                string url = "https://www.amazon.com/dp/" + asin;
                Console.WriteLine("Amerika URL: " + url);
                driver.Navigate().GoToUrl(url);
                jsCode = Resources.AmericaProductPage;

            }



            var timeSpan = driver.Manage().Timeouts().ImplicitWait;
            var isPageLoaded = false;
            while (!isPageLoaded)
            {
                isPageLoaded = new WebDriverWait(driver, timeSpan).Until(
d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                Console.WriteLine(isPageLoaded);
            }
            //new SelectCountry(driver).Select();



            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string liste = Convert.ToString(js.ExecuteScript(jsCode));
            Thread.Sleep(1000);
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            string productInfoFromJs;
            try
            {
                productInfoFromJs = (string)js.ExecuteScript("return document.querySelector('#benEkledim').innerText");
                // productInfoFromJs = (string)js.ExecuteScript("while(true){if(document.querySelector('#benEkledim') != null){return document.querySelector('#benEkledim').innerText; break;}}");
            }
            catch (Exception)
            {

                Thread.Sleep(1000);
                productInfoFromJs = (string)js.ExecuteScript("return document.querySelector('#benEkledim').innerText");
            }
            if (!productInfoFromJs.Equals("-1"))
            {
                var productInfo = productInfoFromJs.Split(',');
                Console.WriteLine("Ürün Bilgileri: " + productInfo[0]);
                if (countryCode.Equals("ca"))
                {
                    productsInfos?.Add(productInfoFromJs);
                }
                else if (countryCode.Equals("us"))
                {
                    productsInfos[step] = productInfoFromJs + productsInfos[step];
                }
                //new AddDataGrid().Execute(productInfo.ToList<object>());
                dosyayaYaz(productInfo.ToList<object>());
            }
            else
            {
                productsInfos?.Add(-1);
                Console.WriteLine("ürün yok");
            }
            //

        }
        public void dosyayaYaz(List<object> asinList)
        {
            string dosya_yolu = $@"{GetFolderPath(SpecialFolder.Desktop)}\WppError.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            string errors = "";
            for (int i = 0; i < asinList.Count; i++)
            {
                sw.WriteLine($"{i + 1} => " + asinList[i]);
                errors += $"{i + 1} => {asinList[i]} \n";
            }


            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }

    }
}
