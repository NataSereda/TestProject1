using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [TestFixture]
        public class SeleniumTest
        {
            [Test]
            public void TestMethod1()
            {
                IWebDriver driver = new ChromeDriver();

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl("https://lingva.ua/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(1000); /*Only for Demo*/
                //
                driver.FindElement(By.CssSelector("[href='https://srs.lingva.ua/']")).Click();
                driver.FindElement(By.Id("login-email-page")).SendKeys("kkrisqmb@cuenmex.com");
                Thread.Sleep(1000);  /*Only for Demo*/


                driver.FindElement(By.Id("login-password-page")).Click();
                driver.FindElement(By.Id("login-password-page")).Clear();
                driver.FindElement(By.Id("login-password-page")).SendKeys("qwerty");
                Thread.Sleep(1000);  /*Only for Demo*/


                driver.FindElement(By.CssSelector("#content > div > div > div.col-lg-6 > form > button")).Click();
                Thread.Sleep(1000);  /*Only for Demo*/

                IWebElement actuallogin = driver.FindElement(By.CssSelector("#main-menu > a.item.active > span"));
                Assert.AreEqual("Ваш кабiнет", actuallogin.Text);
                Thread.Sleep(1000);  /*Only for Demo*/
              

                driver.FindElement(By.CssSelector("#main-menu > div.right.menu > a > span")).Click();
                Thread.Sleep(1000);  /*Only for Demo*/


                IWebElement actuallogout = driver.FindElement(By.CssSelector("#content > div > div > div.col-lg-6 > form > button"));
                Assert.AreEqual("Увійти", actuallogout.Text);
                Thread.Sleep(1000);/*Only for Demo*/
                driver.Quit();


            }
        }
    }
}