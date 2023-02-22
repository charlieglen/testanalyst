// Open a browser  - maximise window
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch the URL

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify the username text box and enter a valid username
IWebElement usernameBox = driver.FindElement(By.Id("UserName"));
usernameBox.SendKeys("hari");


// Identify the password text box and enter a valid password
IWebElement passwordBox = driver.FindElement(By.Id("Password"));
passwordBox.SendKeys("123123");

// Locate log in button and click
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// Check if the log in was successful
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Log in successful");
}
else
{
    Console.WriteLine("Log in failed!");
}


//CHARLIE