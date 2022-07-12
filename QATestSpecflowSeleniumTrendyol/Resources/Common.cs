﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace QATestSpecflowSeleniumTrendyol.Resources
{
    public class Common
    {
        public const string SiteUrl = "https://trendyol.com";
        public const string ModalCloseElement = "//div[@class='modal-content']//div[@class='modal-close']";
        public const string PageLoadVerifyElement = "//div[@class='header']//a[@id='logo']";

        public const string PopupLocator = "//div[@class='popup']";
        public const string OverlayLocator = "//div[@class='overlay']";

        private IWebDriver _webDriver;
        private readonly IJavaScriptExecutor js;
        public readonly Actions action;


        // its a default wait time for expicit waits
        public const int DefaultWaitInSeconds = 5;

        public Common(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            js = (IJavaScriptExecutor)webDriver;
            action = new Actions(webDriver);
        }

        public void StartTest()
        {
            if (_webDriver.Url != SiteUrl)
            {
                _webDriver.Manage().Window.Maximize();
                _webDriver.Url = SiteUrl;
                CloseModalIfExists();

            }
        }

        public void EndTest()
        {
            _webDriver.Quit();
        }

        public void CloseModalIfExists()
        {
            VerifyPageLoad();
            #pragma warning disable CS8600
            IWebElement ModalClose = FindElementAndIgnoreErrors("XPath", ModalCloseElement);

            #pragma warning disable CS8604
            if (Exists(ModalClose))
            {
                ModalClose.Click();
            }
            #pragma warning restore CS8604
            #pragma warning restore CS8600

        }

        public void ClosePopupIfExists()
        {
            VerifyPageLoad();
            #pragma warning disable CS8600
            IWebElement PopupElement = FindElementAndIgnoreErrors("XPath", PopupLocator);
            IWebElement OverlayElement = FindElementAndIgnoreErrors("XPath", OverlayLocator);

            #pragma warning disable CS8604
            if (Exists(PopupElement))
            {
            #pragma warning disable CS8602
                OverlayElement.Click();
            #pragma warning restore CS8602
            }
            #pragma warning restore CS8604
            #pragma warning restore CS8600
        }

        public IWebElement? FindElementAndIgnoreErrors(string method, string locator)
        { 
            method = method.ToLower();
            switch (method)
            {
                case "xpath":
                    try 
                    { 
                        return _webDriver.FindElement(By.XPath(locator)); 
                    } 
                    catch(NoSuchElementException e) 
                    {
                        Console.WriteLine("Exception Ignored:  "+e);
                        return null; 
                    }
                case "id":
                    try
                    {
                        return _webDriver.FindElement(By.Id(locator));
                    }
                    catch (NoSuchElementException e)
                    {
                        Console.WriteLine("Exception Ignored:  " + e);
                        return null;
                    }
                case "css":
                    try
                    {
                        return _webDriver.FindElement(By.CssSelector(locator));
                    }
                    catch (NoSuchElementException e)
                    {
                        Console.WriteLine("Exception Ignored:  " + e);
                        return null;
                    }
                default:
                    try
                    {
                        return _webDriver.FindElement(By.XPath(locator));
                    }
                    catch (NoSuchElementException e)
                    {
                        Console.WriteLine("Exception Ignored: "+e);
                        return null;
                    }
            }
        }

        public static bool Exists(IWebElement element)
        {
            if (element == null)
            { return false; }
            return true;
        }

        public void WaitForPageLoad()
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(20));
            wait.Until(driver => js.ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void VerifyPageLoad()
        {
            WaitUntilElement(By.XPath(PageLoadVerifyElement));
            // This 3ms wait for prevent sync errors.
            System.Threading.Thread.Sleep(300);
        }

        public void ScrollToElement(IWebElement elementLocator)
        {
            // Aptal firefox için Scroll to el methodu.
            try
            {
                action.MoveToElement(elementLocator).Perform();
            }
            catch (MoveTargetOutOfBoundsException e)
            {
                Console.WriteLine(e);
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elementLocator);
            }
        }

        public void Sleep(int Time)
        {
            // Hand writed method, Sleep like in Robot Framework.
            int SecsToMs = Time * 1000;
            System.Threading.Thread.Sleep(SecsToMs);
        }

        public void WaitUntilElement(By elementLocator, string method = "Visible", int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(timeout));
                if (method == "Clickable")
                {
                    wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
                }
                else if (method == "Exists")
                {
                    wait.Until(ExpectedConditions.ElementExists(elementLocator));
                }
                else if (method == "Visible")
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
                }
                else
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));
                }
                Console.WriteLine(method);

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found.");
                throw;
            }
        }

        // taken from specflow website, WaitUntil method
        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
#pragma warning disable CS8603 // Possible null reference return.
            return wait.Until(driver =>
            {

                var result = getResult();
                if (!isResultAccepted(result))
                    return default;
                return result;

            });
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
