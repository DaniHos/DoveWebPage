using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TechTalk.SpecFlow;
using DoveWebPage.Utility;

namespace DoveWebPage.CommonMethod
{
    public class CommonMethods
    {
        public void OpenUrl()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
        }

        public void SearchShampoo()
        {
            BaseClass.driver.FindElement(By.XPath("//button[@class='o-navbar-label js-search-btn']")).Click();
            
            //BaseClass.driver.FindElement(By.XPath("//input[@class='c-global-search__textbox form-control typeahead tt-input']")).SendKeys("Shampoo");
            //Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//form[@id='globalSearch']//input[@placeholder='Type something here...']")).SendKeys("Shampoo");
        }

        public void ClickOn()
        {
            //BaseClass.driver.FindElement(By.XPath("//form[@id='globalSearch']//input[@placeholder='Type something here...']")).Click();
            //Thread.Sleep(3000);
            //BaseClass.driver.FindElement(By.XPath("//form[@id='globalSearch']//input[@placeholder='Type something here...']")).SendKeys("Shampoo");
            
            BaseClass.driver.FindElement(By.XPath("//form[@id='globalSearch']//button[@class='hidden-xs o-btn o-btn--ternary js-btn-search']")).Click();
           
        }

        public void VerifyShampoo()
        {
            string text=BaseClass.driver.FindElement(By.XPath("//h2[contains(text(),'Baby Shampoo')]")).Text;
            if (text.Contains("Shampoo"))
            {
                Console.WriteLine("Shampoo is present");
            }
            else
            {
                Console.WriteLine("Shampoo is Not present");
            }

        }

        public void OpenUrl1()
        {
            
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
        }

        public void Discovermore()
        {
           
            BaseClass.driver.FindElement(By.XPath("//a[@data-title='Discover more']")).Click();
        }

        public void TextVerification()
        {
            
            string text1 = BaseClass.driver.FindElement(By.XPath("//div[@class='c-social-media-gallery-header clearfix']//h2[@class='o-text__heading-2']")).Text;
            if(text1.Contains("The Real Women behind #StopTheBeautyTest"))
            {
                Console.WriteLine("Text is present");

            }
            else
            {
                Console.WriteLine("Text is Absent");
            }
        }

        public void OpenUrl2()
        {
            
            BaseClass.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
        }

        public void Termsofuse()
        {
            
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.dove.com/in/terms-of-use.html']")).Click();
        }

        public void Prohibiteduser()
        {
            
            string text2 = BaseClass.driver.FindElement(By.XPath("//p[3]")).Text;
            if (text2.Contains("Prohibited Uses"))
                {
                Console.WriteLine("Prohibited Uses is present");
            }
            else
            {
                Console.WriteLine("Not present");
            }


        }

        public void scr(string name)
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may135\source\repos\DoveWebPage\Screenshot" + name + ".png");
        }



    }
}
