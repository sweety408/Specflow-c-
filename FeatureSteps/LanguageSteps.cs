using MarsQA.Pages;
using MarsQA.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.FeatureSteps
{
    [Binding]
     class LanguageSteps : CommonDriver
    {
        [Given(@"i want add language details and check")]
        public void GivenIWantAddLanguageDetailsAndCheck()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

            // page object for Language Page
            Languagepage languageObj = new Languagepage();
            languageObj.LanguageSteps(Driver);

            //Add language test cases
            languageObj.LanguageSteps(Driver);
        }
        
        [Given(@"i want to update the language")]
        public void GivenIWantToUpdateTheLanguage()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

            // page object for Language Page
            Languagepage languageObj = new Languagepage();

            // Update language test cases
            languageObj.UpdateLanguage(Driver);
        }
        
        [Given(@"i want to delete language")]
        public void GivenIWantToDeleteLanguage()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

            // page object for Language Page
            Languagepage languageObj = new Languagepage();
            languageObj.LanguageSteps(Driver);

            // Delete language test cases
            languageObj.DeleteLanguage(Driver);
        }
    }
}
