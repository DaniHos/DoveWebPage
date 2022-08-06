using System;
using TechTalk.SpecFlow;
using DoveWebPage.CommonMethod;

namespace DoveWebPage.stepFile
{
    [Binding]
    public class DoveWebPageSteps
    {
        CommonMethods obj = new CommonMethods();
        [Given(@"Load the given Dove web page")]
        public void GivenLoadTheGivenDoveWebPage()
        {
            obj.OpenUrl();
        }
        
        [When(@"we click on search and type Shampoo")]
        public void WhenWeClickOnSearchAndTypeShampoo()
        {
            obj.SearchShampoo();
        }
        
        [When(@"click on search button")]
        public void WhenClickOnSearchButton()
        {
            obj.scr("SearchValidation1");
            obj.ClickOn();
        }
        
        [Then(@"page opens and we verify the text Shampoo")]
        public void ThenPageOpensAndWeVerifyTheTextShampoo()
        {
            obj.VerifyShampoo();
            obj.scr("SearchValidation");
        }

        [Given(@"Load the  Dove web page")]
        public void GivenLoadTheDoveWebPage()
        {
            obj.OpenUrl1();
        }

        [When(@"we click on Discover more in home page")]
        public void WhenWeClickOnDiscoverMoreInHomePage()
        {
            obj.Discovermore();
        }

        [Then(@"page should open and verify the text “The Real Women behind""")]
        public void ThenPageShouldOpenAndVerifyTheTextTheRealWomenBehind()
        {
            obj.TextVerification();
            obj.scr("Discovermore");
        }

        [Given(@"Load webpage")]
        public void GivenLoadWebpage()
        {
            obj.OpenUrl2();
        }

        [When(@"we click on Terms of use")]
        public void WhenWeClickOnTermsOfUse()
        {
            obj.Termsofuse();
        }

        [Then(@"page should open and verify Prohibited User text")]
        public void ThenPageShouldOpenAndVerifyProhibitedUserText()
        {
            obj.Prohibiteduser();
            obj.scr("Termsofuse");
        }


    }
}
