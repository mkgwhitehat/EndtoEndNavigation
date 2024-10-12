using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace practice;

public class SelectClass
{

    public static void Pp1(string[] args)
    {

        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://demoqa.com/select-menu";
        driver.Manage().Window.Maximize();
        
        IList<IWebElement> iframes = driver.FindElements(By.TagName("iframe"));
        IWebElement header = driver.FindElement(By.TagName("h1"));
        string headerId = header.GetAttribute("id");
        string strg = driver.FindElement(By.TagName("h1")).GetAttribute("id");
        for (int i =0;i<iframes.LongCount();i++)

        {
            driver.SwitchTo().Frame(i);
            try
            {
                IWebElement drpDown = driver.FindElement(By.XPath("//select[@id='cars']"));
                SelectElement sel = new SelectElement(drpDown);
                sel.SelectByText("Volvo");
                sel.SelectByText("Audi");
                break;

            }
                catch(Exception e)

            {
                Console.WriteLine(e);

            }
            finally
            {
                driver.SwitchTo().DefaultContent();
            }
        }
        
        //IList<IWebElement> allInOne = sel.Options;
        //foreach(IWebElement wl in allInOne )
        //{
        //    Console.WriteLine(wl.Text);
        //}
        Console.ReadLine();



    }
}