using System;
using TechTalk.SpecFlow;
using ValidRegistrationPRJ1.PageObject;

namespace ValidRegistrationPRJ1.StepDefinitions
{
    [Binding]
    class ValidRegistraionStepDefinitions
        
    {

        Registration registration;

        public ValidRegistraionStepDefinitions()
        {
            registration = new Registration();
        
        }
        [Given(@"I navigate to the wesbite")]
        public void GivenINavigateToTheWesbite()
        {
            registration.NavigateToWebsite();
        }

        [Given(@"I Click on SignUp")]
        public void GivenIClickOnSignUp()
        {
            registration.ClickOnSignUP();
        }

        [Given(@"I Enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registration.EnterUsername();
        }

        [Given(@"I Enter my email")]
        public void GivenIEnterMyEmail()
        {
            registration.EnterEmail();
        }

        [Given(@"I Enter passowrd")]
        public void GivenIEnterPassowrd()
        {
            registration.EnterPassword();
        }

        [When(@"I Click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registration.Enterlogin();
        }

        [Then(@"I Should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            throw new PendingStepException();
        }
    }
}
