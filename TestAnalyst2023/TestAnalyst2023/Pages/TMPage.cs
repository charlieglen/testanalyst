using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyst2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on Create new

            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            Thread.Sleep(1000);

            // Select Time option from dropdown list

            IWebElement typecodeSelect = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeSelect.Click();

            IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypeCode.Click();

            // Input coded into code textbox

            IWebElement inputCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            inputCode.SendKeys("Charlie");

            // Input description in the Description text box

            IWebElement inputDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            inputDescription.SendKeys("Charlie");

            // Input price unit in the PriceUnit text box

            IWebElement inputPricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputPricePerUnit.SendKeys("1000");

            // Click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            // Go to the last page

        }


        public void EditTM(IWebDriver driver)
        {
            // Edit newly created record
            /*
            IWebElement editRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editRecord.Click();

            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editCode.Clear();
            editCode.SendKeys("Edited Code");

            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            editDescription.Clear();
            editDescription.SendKeys("Edited Description");

            IWebElement editPricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPricePerUnit.Click();

            IWebElement price = driver.FindElement(By.Id("Price"));
            price.Clear();
            editPricePerUnit.SendKeys("23234");
            */

            Thread.Sleep(2000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            IWebElement editRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editRecord.Click();

            // Input coded into code textbox
            Thread.Sleep(2000);
            IWebElement inputCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            inputCode.Clear();
            inputCode.SendKeys("Charlie");

            // Input description in the Description text box

            IWebElement inputDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            inputDescription.Clear();
            inputDescription.SendKeys("Charlie");

            // Input price unit in the PriceUnit text box

            IWebElement inputPricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputPricePerUnit.Click();

            IWebElement price = driver.FindElement(By.Id("Price"));
            price.Clear();
            //editPricePerUnit.SendKeys("23234");
            inputPricePerUnit.SendKeys("23234");




            // Saving after edit

            Thread.Sleep(1000);
            //IWebElement saveButtonAfterEdit = driver.FindElement(By.Id("SaveButton"));
            //saveButtonAfterEdit.Click();

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            
        }
        public void DeleteTM(IWebDriver driver)
        {

            // Go to last page after edit

            Thread.Sleep(1000);
            IWebElement goToLastPageAfterEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageAfterEdit.Click();

            IWebElement deleteRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteRecord.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            
        }

    }
}
