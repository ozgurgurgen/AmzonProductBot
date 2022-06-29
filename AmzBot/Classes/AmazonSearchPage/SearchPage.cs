using AmzBot.Classes.AmazonProductPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmzBot.Classes.AmazonSearchPage
{
    public class SearchPage
    {
        IWebDriver driver;
        int pageCount = 0;
        string pageLink = "amazon.com";
        bool isCountrSelected = false;
        List<string> bigAsinList;

        public void Open(string url, string skuName,string minPrice, string maxPrice, string puan)
        {

            bigAsinList = new List<string> { skuName };

            if (pageLink.Length < 12)
            {
                pageLink = url;
            }
            driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1300, 680);
            for (int i = 0; i <= pageCount; i++)
            {
                Console.WriteLine(pageLink);
                driver.Navigate().GoToUrl(pageLink);

                var timeSpan = driver.Manage().Timeouts().ImplicitWait;
                var isPageLoaded = false;
                while (!isPageLoaded)
                {
                    isPageLoaded = new WebDriverWait(driver, timeSpan).Until(
                    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                }
                //
                if (!isCountrSelected)
                {
                    new SelectCountry(driver).Select();
                    isCountrSelected = true;
                }
                //
                Thread.Sleep(1000);
                var timeSpan2 = driver.Manage().Timeouts().ImplicitWait;
                var isPageLoaded2 = false;
                while (!isPageLoaded2)
                {
                    isPageLoaded2 = new WebDriverWait(driver, timeSpan2).Until(
                    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                }

                IJavaScriptExecutor jsEx = (IJavaScriptExecutor)driver;
                jsEx.ExecuteScript("scroll(0, document.querySelector('body').scrollHeight)");

                string jsCommand =  "divler = document.querySelectorAll('.s-main-slot.s-result-list.s-search-results.sg-row > div'); asinString=''; \n" +
                                    "for(var i = 1; i<divler.length;i++){ \n" +
                                    "    try{ \n" +
                                    "        icerik = divler[i].getAttribute('data-asin'); \n" +
                                    "    } catch{console.log('asin bulunamadı' )} \n" +
                                    "    if(icerik != null && icerik !=''){\n" +
                                    "        pricePart1 = divler[i].innerText.indexOf('$') \n" +
                                    "        price = Number(divler[i].innerText.substring(pricePart1+1, pricePart1 + 6)) \n" +
                                    $"        if(price >= {minPrice} && price <= {maxPrice}) \n" +
                                    "            {try{ \n" +
                                    "                puan = divler[i].getElementsByClassName('a-icon-alt')[0].innerText \n" +
                                    "                puanPart1 = puan.indexOf(' ') \n" +
                                    "                puanNumber = Number(puan.substring(0,puanPart1)) \n" +
                                    "            }catch{ \n" +
                                    "               puanNumber = 0; \n" +
                                    "            } \n" +
                                    $"            if(puanNumber >= {puan}) \n" +
                                    "                {asinString += icerik + ',';} \n" +
                                    "            } \n" +
                                    "        } \n" +
                                    "}  \n" +
                                    "let p = document.createElement('p'); p.id = 'benEkledim'; p.innerText = asinString; document.querySelector('html').appendChild(p); ";

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                string liste = Convert.ToString(js.ExecuteScript(jsCommand));
                Thread.Sleep(1000);
                string asinFromJs;
                try
                {
                    asinFromJs = (string)js.ExecuteScript("return document.querySelector('#benEkledim').innerText");
                }
                catch (Exception)
                {

                    Thread.Sleep(1000);
                    asinFromJs = (string)js.ExecuteScript("return document.querySelector('#benEkledim').innerText");
                }

                bigAsinList.AddRange(asinFromJs.Split(',').ToList<string>());


                if (pageCount == 0)
                {
                    pageCount = Convert.ToInt32(js.ExecuteScript("return document.querySelectorAll('.s-pagination-strip > span')[document.querySelectorAll('.s-pagination-strip > span').length-1].innerText")) - 1;
                    Console.WriteLine(pageCount + 1);
                }
                pageLink = "";
                pageLink += Convert.ToString(js.ExecuteScript("var i = document.querySelectorAll('.a-section.a-text-center.s-pagination-container > span > a').length - 1; return document.querySelectorAll('.a-section.a-text-center.s-pagination-container > span > a')[i].getAttribute('href').slice(0,-1);")) + (i + 2);
                Console.WriteLine("page link: " + pageLink);
                var part1 = pageLink.IndexOf("page=") + 4;
                var part2 = pageLink.IndexOf("&qid") + 1;
                var cikanParca = pageLink.Substring(part1, part2 - part1);
                pageLink = pageLink.Replace(cikanParca, "=" + (i + 2) + "&");
                Console.WriteLine("çıkan parça: " + cikanParca);
                Console.WriteLine(pageLink);
                Console.WriteLine(i + 2);
                pageLink = "https://amazon.com" + pageLink;
                //Thread.Sleep(15000);
                Console.WriteLine("ASİN SAYISI GÜNCEL: " + bigAsinList.Count);
                Thread.Sleep(3000);

            }
            new Other.WriteFile().Txt(bigAsinList);
            DriversClose();
            //new NewTab(bigAsinList, driver).Execute();

        }
        public void DriversClose()
        {
            try
            {
                driver.Quit();
            }
            catch (NullReferenceException)
            {


            }
        }
    }
}
