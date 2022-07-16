﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace QATestSpecflowSeleniumTrendyol.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Trendyol")]
    public partial class TrendyolFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Trendyol.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Trendyol", "\tTrendyol Complete Tests BDD, Test badge now TC-U\r\n\r\n![tcu](https://raw.githubuse" +
                    "rcontent.com/Berkantyuks/QA-Project-Test-Classification-Mark/main/TCM-114x40/114" +
                    "x40-tc-u.png)", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Visitor should be able search product and add to cart")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Common")]
        public void _01VisitorShouldBeAbleSearchProductAndAddToCart()
        {
            string[] tagsOfScenario = new string[] {
                    "Smoke",
                    "Common"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Visitor should be able search product and add to cart", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And("Search for product \"Laptop\" in search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("Verify search executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.When("Click first product in results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And("Verify product detail page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("Click add to cart button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("Click see cart button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("Verify product added to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Visitor should be able click add to favorites button and redirect login page")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Favorites")]
        public void _02VisitorShouldBeAbleClickAddToFavoritesButtonAndRedirectLoginPage()
        {
            string[] tagsOfScenario = new string[] {
                    "Smoke",
                    "Favorites"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Visitor should be able click add to favorites button and redirect login page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.And("Search for product \"Watch\" in search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("Verify search executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When("Click first product in results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And("Verify product detail page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("Click add to favorites button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("Verify login page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Visitor should be see product comments")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Comments")]
        public void _03VisitorShouldBeSeeProductComments()
        {
            string[] tagsOfScenario = new string[] {
                    "Smoke",
                    "Comments"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Visitor should be see product comments", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.And("Search for product \"Iphone 12\" in search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("Verify search executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When("Click first product in results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("Verify product detail page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("Verify visitor see product comments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Visitor should be able to see footer")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Footer")]
        public void _04VisitorShouldBeAbleToSeeFooter()
        {
            string[] tagsOfScenario = new string[] {
                    "Smoke",
                    "Footer"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Visitor should be able to see footer", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.When("Scroll to footer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("Verify footer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Move to top button should be work")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("MoveToTop")]
        public void _05MoveToTopButtonShouldBeWork()
        {
            string[] tagsOfScenario = new string[] {
                    "Smoke",
                    "MoveToTop"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Move to top button should be work", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 46
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 47
 testRunner.When("Scroll to footer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.And("Verify footer is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("Click move to top button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Then("Verify top of the page is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Visitor should be able search product using filters")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Filter")]
        [NUnit.Framework.TestCaseAttribute("Kamp Sandalyesi", "Quechua", "200", "350", "x", "", null)]
        [NUnit.Framework.TestCaseAttribute("iphone 11", "Apple", "10000", "14000", "", "x", null)]
        [NUnit.Framework.TestCaseAttribute("Alet Çantası", "Bosch", "300", "400", "x", "", null)]
        public void _06VisitorShouldBeAbleSearchProductUsingFilters(string searchQuery, string brand, string minPrice, string maxPrice, string photoReview, string freeCargo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "Filter"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("SearchQuery", searchQuery);
            argumentsOfScenario.Add("Brand", brand);
            argumentsOfScenario.Add("MinPrice", minPrice);
            argumentsOfScenario.Add("MaxPrice", maxPrice);
            argumentsOfScenario.Add("PhotoReview", photoReview);
            argumentsOfScenario.Add("FreeCargo", freeCargo);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Visitor should be able search product using filters", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 54
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
 testRunner.And(string.Format("Search for product \"{0}\" in search", searchQuery), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("Verify search executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And(string.Format("Set brand filter to \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And(string.Format("Set photo review filter if selected \"{0}\"", photoReview), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And(string.Format("Set free cargo filter if selected \"{0}\"", freeCargo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And(string.Format("Set price filter Min:\"{0}\" and Max:\"{1}\"", minPrice, maxPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.When("Click first product in results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And("Verify product detail page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("Verify product brand is \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then(string.Format("Verify product title contains \"{0}\"", searchQuery), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Visitor should be able see Sign-In form error messages")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("SignInErrors")]
        [NUnit.Framework.TestCaseAttribute("Null email", "", "pass123", "Lütfen geçerli bir e-posta adresi giriniz.", null)]
        [NUnit.Framework.TestCaseAttribute("Invalid email", "wthmail.lolx", "pass123", "Lütfen geçerli bir e-posta adresi giriniz.", null)]
        [NUnit.Framework.TestCaseAttribute("Null password", "berkant@gmail.com", "", "Lütfen şifrenizi giriniz.", null)]
        [NUnit.Framework.TestCaseAttribute("Unregistered email", "berkant@gmail.com", "pass123", "E-posta adresiniz ve/veya şifreniz hatalı.", null)]
        public void _07VisitorShouldBeAbleSeeSign_InFormErrorMessages(string description, string email, string password, string expectedMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "SignInErrors"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("ExpectedMessage", expectedMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Visitor should be able see Sign-In form error messages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 73
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 74
 testRunner.Given("Navigate to trendyol website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 75
 testRunner.And("Click login button in navbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("Verify login page opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.When(string.Format("Set email to \"{0}\" and password to \"{1}\" in signin form", email, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 78
 testRunner.And("Click login button to submit form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.Then(string.Format("Check exception message \"{0}\" in signin form", expectedMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
