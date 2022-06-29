using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmzBot.Classes.AmazonProductPage
{
    public class SelectCountry
    {
        IWebDriver driver;

        public SelectCountry(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Select()
        {
            Thread.Sleep(1000);
            IWebElement countryButton = driver.FindElement(By.XPath("//*[@id='glow-ingress-block']"));
            countryButton.Click();
            Thread.Sleep(1000);
            IWebElement dropDownList = driver.FindElement(By.XPath("//*[@id='GLUXSpecifyLocationDiv']/div[4]/span"));
            dropDownList.Click();
            Thread.Sleep(2000);

            IWebElement canadaItem = driver.FindElement(By.XPath("//*[@id='GLUXCountryList_1']"));
            canadaItem.Click();
            Thread.Sleep(1000);

            IWebElement doneButton = driver.FindElement(By.XPath("//*[@id='a-popover-2']/div/div[2]/span/span/span/button"));
            doneButton.Click();
        }
    }
}
