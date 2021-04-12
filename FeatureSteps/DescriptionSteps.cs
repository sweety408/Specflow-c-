using MarsQA.Pages;
using MarsQA.Utilities;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.FeatureSteps 
{
    [Binding]
     class DescriptionSteps : CommonDriver
    {
        [Given(@"Add decription details")]
        public void GivenAddDecriptionDetails()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

            // page object for description Page
            Description DesObj = new Description();
            DesObj.DescriptionSteps(Driver);

            // Add description Testcases
            DesObj.DescriptionSteps(Driver);
        }
        
        [Given(@"I want to Update descriptipn details")]
        public void GivenIWantToUpdateDescriptipnDetails()
        {
            // page bject for Profile Page
            ProfilePage profileObj = new ProfilePage();
            profileObj.GotoProfilePage(Driver);

            // page object for description Page
            Description DesObj = new Description();
            DesObj.DescriptionSteps(Driver);

            //Update language
            DesObj.UpdateDescription(Driver);
        }
    }
}
