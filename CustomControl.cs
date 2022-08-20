using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpcore
{
    internal public class CustomControl
    {
        public void ComboBox(String ControlName, String Name);

        IWebElement combocontrol = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

        combocontrol.Clear();

        combocontrol.SendKeys("Almomd");

            Driver.FindElement(By.XPath("//body/div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']/div[2]/ul[1]/li[1]")).Click();

    }
}
