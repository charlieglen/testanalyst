
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.WebAuthn;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Timers;
using System.Globalization;



// Open Chrome browser and maximize
// If Selenium Chrome driver was not installed. You have to download and add the file path manually inside ChromeDriver()

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch Turnup Portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify username box and enter a valid username
IWebElement userBox = driver.FindElement(By.Id("UserName"));
userBox.SendKeys("hari");

// Identify the password box and enter a valid password
IWebElement passwordBox = driver.FindElement(By.Id("Password"));
passwordBox.SendKeys("123123");

// Click remember me checkbox
IWebElement rememberBox = driver.FindElement(By.Id("RememberMe"));
rememberBox.Click();

// Click log in button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// Check if log in was successful
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));


if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Log in successful");
}
else
{
    Console.WriteLine("Log in failed");
}

// Create a new Time record

// Navigate to time and material page

IWebElement administrationDropdodwn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdodwn.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

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

Thread.Sleep(2000);
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();

// Check if new Time record has been created

IWebElement newRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newRecord.Text == "Charlie")
{
    Console.WriteLine("Record created");
}
else
{
    Console.WriteLine("Record creation failed");
}


// Edit newly created record

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

IWebElement Price = driver.FindElement(By.Id("Price"));
Price.Clear();
editPricePerUnit.SendKeys("23234");

// Saving after edit

Thread.Sleep(1000);
IWebElement saveButtonAfterEdit = driver.FindElement(By.Id("SaveButton"));
saveButtonAfterEdit.Click();

// Go to last page after edit

Thread.Sleep(1000);
IWebElement goToLastPageAfterEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageAfterEdit.Click();

IWebElement editedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
IWebElement editedPricePerUnit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));


if (editedRecord.Text == "Edited Code")
{
    if (editedDescription.Text == "Edited Description")
 
        {
            Console.WriteLine("Edit Successful");
        }
}
else
{
    Console.WriteLine("Edit Failed");
}



// Delete a newly created/edited record


IWebElement deleteRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteRecord.Click();

IAlert alert = driver.SwitchTo().Alert();
alert.Accept();









