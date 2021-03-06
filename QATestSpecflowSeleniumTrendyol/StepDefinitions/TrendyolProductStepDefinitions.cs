using QATestSpecflowSeleniumTrendyol.Drivers;
using QATestSpecflowSeleniumTrendyol.PO;

namespace QATestSpecflowSeleniumTrendyol.StepDefinitions
{
    [Binding]
    public class TrendyolProductStepDefinitions
    {
        private readonly ProductSeller productSeller;
        private readonly SubMethods subMethods;
        private readonly ProductDetail productDetail;
        private readonly Cart cart;


        public TrendyolProductStepDefinitions(SeleniumDriver driver)
        {
            productSeller = new ProductSeller(driver.Current);
            subMethods = new SubMethods(driver.Current);
            productDetail = new ProductDetail(driver.Current);
            cart = new Cart(driver.Current);
        }

        private string ProductSellerName;
        private string ProductUrl;

        [When(@"Get product seller name")]
        public void WhenGetProductSellerName()
        {
            ProductSellerName = productDetail.GetProductSellerName();
        }

        [When(@"Click product seller page link")]
        public void WhenClickProductSellerPageLink()
        {
            productDetail.ClickProductSellerLink();
        }

        [When(@"Verify seller page opened")]
        public void WhenVerifySellerPageOpened()
        {
            productSeller.VerifyPageLoad();
        }

        [Then(@"Verify the product seller with received name")]
        public void ThenVerifyTheSellerReceived()
        {
            productSeller.CheckProductSellerNameByGiven(ProductSellerName);
        }

        [When(@"Get Product base link")]
        public void WhenGetProductBaseLink()
        {
            ProductUrl = productDetail.GetProductBaseUrl();
        }

        [When(@"Verify Product added to cart by received base link")]
        public void WhenVerifyProductAddedToCartByReceivedBaseLink()
        {
            cart.VerifyProductAddedToCartByGivenLink(ProductUrl);
        }

        [When(@"Click ""([^""]*)"" Button for ""([^""]*)"" times")]
        public void WhenClickButtonForTimes(string Button, string ForTimes)
        {
            cart.ClickProductIncreaseButtonByGivenTimes(ForTimes, ProductUrl);
        }

        [Then(@"verify that the number of products is increased correctly by ""([^""]*)""")]
        public void ThenVerifyThatTheNumberOfProductsIsIncreasedCorrectlyBy(string ForTimes)
        {
            cart.VerifyProductNumberIncreaseByGiven(ForTimes, ProductUrl, 1);
        }

        [When(@"Click delete button by received base link")]
        public void WhenClickDeleteButtonByReceivedBaseLink()
        {
            cart.ClickProductDeleteButtonByGiven(ProductUrl);
        }

        [Then(@"Verify the product is deleted")]
        public void ThenVerifyTheProductIsDeleted()
        {
            cart.VerifyProductIsDeletedByGiven(ProductUrl);
        }
    }
}
