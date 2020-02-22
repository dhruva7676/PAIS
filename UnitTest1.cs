using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;
namespace PAIS
{
    [TestFixture]
    public class SRN
    {
        [Test]
        public void SRtoSRN()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Others");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }


        [Test]
        public void SRtoSRN1()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Printing");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void SRtoSRN2()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Repair");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void SRtoSRN3()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Others");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void SRtoSRN4()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void HOD()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'Service Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_4")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void HOI()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'Service Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_1")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void WO()
        {
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            //((IJavaScriptExecutor)driver).ExecuteScript("window.resizeTo(1600, 900);");

            //string Url1 = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver1 = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);


            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t19")).Click();
            Task.Delay(2000).Wait();

            //acceptNextAlert = true;
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Data Will be lost\\. Do you want to continue[\\s\\S]$"));
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropdownlistPoType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DropDownListBU")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDept")).Click();
            Task.Delay(2000).Wait();


            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            var element1 = driver.FindElement(By.XPath("//a[contains(text(),'2')]"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.XPath("//a[contains(text(),'2')]")).Click();
            Task.Delay(2000).Wait();

            //IWebElement web = driver.FindElement(By.Id("//a[contains(text(),'2')]")).Click();
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            //driver.FindElement(By.XPath("//a[contains(text(),'2')]")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//span[@id='GridViewDept_LabelDID_4']")).Click();
            Task.Delay(2000).Wait();
            //driver.Close();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Repair");
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSR_CheckBoxMarkPR_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSubSRLine_CheckBoxMarkSRLine_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSubSRLine_CheckBoxMarkSRLine_1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSubPrLine")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDebsearch")).Click();
            Task.Delay(2000).Wait();

            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_2 | ]]
            driver.FindElement(By.Id("GridViewVendor_LabelVID_3")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm"))).SelectByText("Quarterly");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose"))).SelectByText("BOTH");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            Task.Delay(2000).Wait();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment")).Click();
            // new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment"))).SelectByText("Yes");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment")).Click();
            Task.Delay(2000).Wait();

            //driver.SwitchTo().Window(driver.WindowHandles.Last());
            //Task.Delay(2000).Wait();
            //driver.Close();
            //Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip")).Click();
            //Task.Delay(2000).Wait();

            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_3 | ]]
            driver.FindElement(By.Id("GridViewShipLocation_LabelVID_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();



            //var element4 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm"));


            //var script4 = "arguments[0].scrollIntoView(false);";
            //IJavaScriptExecutor js4 = (IJavaScriptExecutor)driver;
            //js4.ExecuteScript("arguments[0].scrollIntoView();", element4);
            //js4.ExecuteScript(script4, element4);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm")).Click();
            //Task.Delay(2000).Wait();

            //driver.Close();
            //Task.Delay(2000).Wait();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm"))).SelectByText("Quarterly");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPayterm")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose"))).SelectByText("BOTH");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).Click();
            //Task.Delay(2000).Wait();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment"))).SelectByText("Yes");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlAdvancePayment")).Click();
            //Task.Delay(2000).Wait();
            var element3 = driver.FindElement(By.Id("DropDownListTermCond"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonShip")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            new SelectElement(driver.FindElement(By.Id("DropDownListTermCond"))).SelectByText("CONG1");
            driver.FindElement(By.Id("DropDownListTermCond")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='View WO File'])[1]/following::tr[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_0")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_0")).SendKeys("100");
            Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_1")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_1")).SendKeys("100");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_2")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_2")).SendKeys("100");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_3")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_3 | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_3")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_3")).SendKeys("100");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_4")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_4 | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_4")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_4")).SendKeys("100");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_5")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_5 | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_5")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_5")).SendKeys("100");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_6")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | id=ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_6 | ]]
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_6")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWODetails_UnitPriceText_6")).SendKeys("100");
            Task.Delay(2000).Wait();*/
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='WO Entry'])[2]/following::div[2]")).Click();
            Task.Delay(2000).Wait();
            //acceptNextAlert = true;

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            //driver.FindElement(By.XPath("//a[contains(text(),'2')]")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element5 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit"));
            var script5 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js5 = (IJavaScriptExecutor)driver;
            js5.ExecuteScript(script5, element5);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Data Will be lost\\. Do you want to continue[\\s\\S]$"));
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();

        }
        [Test]
        public void F_Exec()
        {
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);


            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'WO Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtFinanceSanNum")).SendKeys("54564");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void F_Dir()
        {
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void DDP()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void PD()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu5");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void Dispatch()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t24")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_6")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDispatch"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDispatch")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }



        [Test]
        public void Srn_entry()
        {
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t5")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnWOItem")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtSerWOID")).SendKeys("0000279");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnSerDetails")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWO_RadioMarkWO_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubWO")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewWOLineDesc_CheckBoxMarkWO_0")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Button1")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpCompSRNType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpCompSRNType"))).SelectByText("Others");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextPurpose")).SendKeys("mahe");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TextComment")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvNo")).SendKeys("1215646");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate")).SendKeys("14/01/2020");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtInvDate")).Click();
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();

            //driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void Head()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void buyer()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t31"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t31")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();

            //driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("HyperLinkLogout"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void Inward()
        {
            string Url = "http://172.16.18.106/CFAS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t3")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu"))).SelectByText("GMAHE");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL"))).SelectByText("Bills");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonVDsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='vendCode']")).SendKeys("PUR0000005");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='btnSearch']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridView_Vendor_Label2_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DeliveryTypeDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DeliveryTypeDL"))).SelectByText("Letter");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_UssUnitsDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_UssUnitsDL"))).SelectByText("Conference");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SubjectTb")).SendKeys("new one");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CommentsTb")).SendKeys("new one for test");
            Task.Delay(2000).Wait();


            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_ImageButton1_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnExit")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("ATHMG");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_ImageButton1_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_8")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewGRNDesc_RadioGRN_1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmitGRN")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_InvoiceShortNarration_0")).SendKeys("ojoiejnihniubsdiun");
            Task.Delay(2000).Wait();

            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonVDsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='vendCode']")).SendKeys("PUR0000009");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='btnSearch']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridView_Vendor_Label2_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();*/



            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/


            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("Label3"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void Inward_entry()
        {
            string Url = "http://172.16.18.106/CFAS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t3")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlVoucherType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlVoucherType"))).SelectByText("Without PO Reference");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu"))).SelectByText("GMAHE");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlinwardbu")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL"))).SelectByText("Bills");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SectionDL")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonVDsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='vendCode']")).SendKeys("PUR0000005");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='btnSearch']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridView_Vendor_Label2_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DeliveryTypeDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DeliveryTypeDL"))).SelectByText("Letter");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_UssUnitsDL")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_UssUnitsDL"))).SelectByText("Conference");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_SubjectTb")).SendKeys("new one");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_CommentsTb")).SendKeys("new one for test");
            Task.Delay(2000).Wait();


            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_ImageButton1_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnExit")).Click();
            Task.Delay(2000).Wait();


            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("ATHMG");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlPOBusinessUnit")).Click();
            Task.Delay(2000).Wait();*/


            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBillDetailsBT")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_ImageButton1_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_RadioMarkPO_8")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_brnSubPo")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewGRNDesc_RadioGRN_1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmitGRN")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_BillEntry_InvoiceShortNarration_0")).SendKeys("ojoiejnihniubsdiun");
            Task.Delay(2000).Wait();

            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonVDsearch")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='vendCode']")).SendKeys("PUR0000009");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//input[@id='btnSearch']")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("GridView_Vendor_Label2_0")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Task.Delay(2000).Wait();*/



            var element2 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/


            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element3 = driver.FindElement(By.Id("Label3"));
            var script3 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js3 = (IJavaScriptExecutor)driver;
            js3.ExecuteScript(script3, element3);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_AddBtnTb")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void Voucher()
        {
            string Url = "http://172.16.18.106/CFAS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("Label2")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox1")).SendKeys("fasu1");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBox2")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Button1")).Click();
            Task.Delay(2000).Wait();

            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();

            //driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEdit_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnApprove"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BtnApprove")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("Label3")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
    }
}
