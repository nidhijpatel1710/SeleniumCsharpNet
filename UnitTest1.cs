using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpcore
{
    public class Tests : DriverHelper, ITests
    {
        public static IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("setup");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("tomato");

            Driver.FindElement(By.XPath("//body/form[@id='form1']/div[3]/div[1]/div[2]/main[1]/div[1]/div[5]/div[2]/div[2]/div[1]/ul[1]/li[1]/label[1]/div[1]/div[1]/div[1]")).Click();

            string ComboControlName = "ContentPlaceHolder1_AllMealsCombo-awed";

            IWebElement combocontrol = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

            combocontrol.Clear();

            combocontrol.SendKeys("Almomd");

            Driver.FindElement(By.XPath("//body/div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']/div[2]/ul[1]/li[1]")).Click();

            Console.WriteLine("test1");
            Assert.Pass();
        }
    }
}