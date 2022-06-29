using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmzBot.Classes.AmazonSearchPage
{
    public class NewTab
    {
        List<string> asinList;
        IWebDriver driver;

        public NewTab(List<string> asinList, IWebDriver driver)
        {
            this.asinList = asinList;
            this.driver = driver;
        }
        public void Execute()
        {
            // driver.Navigate().GoToUrl("https://google.com.tr");
            //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            var list = new AmazonProductPage.AmazonProductInfo(asinList, driver).Execute();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            new Other.WriteFile().Txt(list);
        }
    }
}
