﻿using OpenQA.Selenium;
using QATestSpecflowSeleniumTrendyol.Resources;

namespace QATestSpecflowSeleniumTrendyol.PO
{
    public class Cart
    {
        private readonly IWebDriver Driver;
        private readonly Common common;

        private const string CartVerifyLocator = "//div[@id='basket-app-container']";
        private const string ProductVerifyLocator = "//div[@class='pb-merchant-group'][1]";

        public Cart(IWebDriver webDriver)
        {
            Driver = webDriver;
            common = new Common(webDriver);
        }

        IWebElement ProductVerifyElement => Driver.FindElement(By.XPath(ProductVerifyLocator));

        public void VerifyPageLoad()
        {
            common.WaitForPageLoad();
            common.WaitUntilElement(By.XPath(CartVerifyLocator));
        }

        public void VerifyCartPageOpened()
        {
            common.WaitUntilElement(By.XPath(CartVerifyLocator), "Exists");
        }

        public void VerifyProductLink(string GivenUrl)
        {
            if (!GivenUrl.Contains(ReceivedUrl))
            {

            }
        }
    }
}
