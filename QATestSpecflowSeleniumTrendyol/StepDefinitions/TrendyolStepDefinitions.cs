using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using QATestSpecflowSeleniumTrendyol.Drivers;
using QATestSpecflowSeleniumTrendyol.Resources;
using QATestSpecflowSeleniumTrendyol.PO;

namespace QATestSpecflowSeleniumTrendyol.StepDefinitions
{
    [Binding]
    public class TrendyolStepDefinitions
    {   
        //
        private readonly Common _driver;
        private readonly Navbar navbar;
        private readonly SearchResults searchResults;
        //

        public TrendyolStepDefinitions(SeleniumDriver driver)
        {
            _driver = new Common(driver.Current);
            navbar = new Navbar(driver.Current);
            searchResults = new SearchResults(driver.Current);
        }

        [Given(@"Navigate to trendyol website")]
        public void GivenNavigateToTrendyolWebsite()
        {
            // Given in hooks, its just for define BDD
        }

        [Given(@"Search for product ""([^""]*)"" in search")]
        public void GivenSearchForProductInSearch(string product)
        {
            navbar.SearchItem(product);
        }

        [Then(@"Click first product in results")]
        public void ThenClickFirstProductInResults()
        {
            searchResults.ClickFirstProduct();
        }

    }

}