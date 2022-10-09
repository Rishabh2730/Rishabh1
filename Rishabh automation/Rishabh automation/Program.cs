//open chrome browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

IWebDriver driver = new ChromeDriver();

//naviagte to Turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

//identify username textbox and enter valid username

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
   

//identify password textbox and enter valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it

IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
Loginbutton.Click();

//check if user is logged in successfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")); 

if (helloHari.Text== "Hello hari!")
{
    Console.WriteLine("Login was successful,test passed");

}
else
{
    Console.WriteLine("test failed");

}
//create material record


//navigate to time and material page
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
administrationDropdown.Click();

IWebElement TimeandMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TimeandMaterial.Click();
Thread.Sleep(1000);


//Click on "Create new" button
IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNew.Click();

//Select material from typecode dropdown

IWebElement TypeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
TypeCodeDropdown.Click();
Thread.Sleep(1000);

IWebElement MaterialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_option_selected\"]"));
MaterialOption.Click();

//Enter code into code textbox
IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));
CodeTextbox.SendKeys("rish");

//Enter the description on description textbox

IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
DescriptionTextbox.SendKeys("first automation");

//Enter the price per unit in price per unit textbox

IWebElement inputtag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
inputtag.Click();

IWebElement PricePerUnit = driver.FindElement(By.Id("Price"));
PricePerUnit.SendKeys("27.00");

//click on save button

IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(2000);

//check if new material record has been created

IWebElement GoToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
GoToLastPage.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


if (newCode.Text =="rish")

    {
    Console.WriteLine("Material record created successfully");

}
else
{
    Console.WriteLine("Material record not created");

}
























