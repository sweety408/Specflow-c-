using MarsQA.Pages;
using MarsQA.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.FeatureSteps
{
    [Binding]
     class ProfileSteps : CommonDriver
    {
        [Given(@"click on profile submenu and verify the details")]
        public void GivenClickOnProfileSubmenuAndVerifyTheDetails()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

        }
    }
}
