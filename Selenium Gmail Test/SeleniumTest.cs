using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;


namespace Selenium_Gmail_Test
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\Users\\anast\\Desktop\\Selenium Gmail Test\\Selenium Gmail Test\\drivers");
        }

        [Test]
        public void Test1()
        {
            
            driver.Navigate().GoToUrl("https://gmail.com");        //open Gmail url
            driver.Manage().Window.Maximize();                    //maximize window
            Thread.Sleep(2000);                                  //wait

            IWebElement x = driver.FindElement(By.Id("identifierId"));      //locate email input form
            x.SendKeys("t05112174@gmail.com");                              //type email
            Thread.Sleep(2000);                                             //wait
            x.SendKeys(Keys.Enter);                                         //press enter 
            Console.WriteLine("Email value is entered");                    //console output message
            Thread.Sleep(2000);                                             //wait
            
            IWebElement x1 = driver.FindElement(By.Name("Passwd"));         //locate password input form
            x1.SendKeys("01234567891312");                                  //type passowrd
            Thread.Sleep(2000);                                             //wait
            x1.SendKeys(Keys.Enter);                                        //press enter
            Console.WriteLine("Logged in");                                 //console output message
            Thread.Sleep(3000);                                             //wait

            //IWebElement x3 = driver.FindElement(By.Id(":1s"));            //locate primary tab
            //x3.Click();                                                   //click primary tab

            int emailCount = driver.FindElements(By.CssSelector(".zA.zE")).Count;       //locate number of total emails
            Console.WriteLine("Total number of emails: " + emailCount);                //console output total emails

            int y = 4;   //choose a random email
            IWebElement nthEmail = driver.FindElement(By.CssSelector(".zA.zE:nth-child(" + y + ")"));   //locate yth email
            string sender = nthEmail.FindElement(By.CssSelector(".yX.xY")).Text;                        //locate email sender
            string subject = nthEmail.FindElement(By.CssSelector(".y6")).Text;                          //locate email subject
            Console.WriteLine("Sender of " + y + "th email: " + sender);                                //console output email sender
            Console.WriteLine("Subject of " + y + "th email: " + subject);                              //console output email subject
            
            Thread.Sleep(30000);      //wait
            driver.Quit();            //close browser
        }

        
    }
}