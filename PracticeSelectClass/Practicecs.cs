using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace PracticeSelectClass
{
    public class Practicecs
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://formy-project.herokuapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[text()='Dropdown' and @class='btn btn-lg']")).Click();
            driver.FindElement(By.XPath("//button[@id='dropdownMenuButton']")).Click();
            //IWebElement hoverTo = driver.FindElement(By.XPath("//div[@class='dropdown-menu']/a[text()='File Upload']"));
            WebDriverWait wait = new WebDriverWait(driver , TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath("//div[@class='dropdown-menu']/a[text()='File Upload']")).Enabled);
            IWebElement hoverTo = driver.FindElement(By.XPath("//div[@class='dropdown-menu']/a[text()='File Upload']"));




            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", hoverTo);
            //IWebElement chooseButton = driver.FindElement(By.XPath("//button[text()='Choose']"));
            //chooseButton.SendKeys(@"C:\Users\admin\Desktop\Preparation\C# programs.txt");
            //
            IWebElement chooseButton = driver.FindElement(By.XPath("//input[@type='file']"));


            // Specify the file path (ensure this file exists on your system)
            string filePath = @"C:\Users\admin\Desktop\Preparation\C# programs.txt"; 

            // Send the file path to the input element
            chooseButton.SendKeys(filePath);





        }
        
        
    }
}
