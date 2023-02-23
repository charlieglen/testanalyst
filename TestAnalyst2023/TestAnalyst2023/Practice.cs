
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
    Console.WriteLine("Log in fail");
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
// Check if new Time record has been created


// Go to the last page

Thread.Sleep(2000);
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();

IWebElement newRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newRecord.Text == "Charlie")
{
    Console.WriteLine("Record Created");
}
else
{
    Console.WriteLine("Record creation failed");
}

