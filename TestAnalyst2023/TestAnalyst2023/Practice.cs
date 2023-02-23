
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open Chrome browser and maximize

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