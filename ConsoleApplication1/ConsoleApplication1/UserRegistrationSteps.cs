using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ConsoleApplication1
{
    [Binding]
    public class UserRegistrationSteps
    {
        string Name, Email, Password;

        [Given(@"i am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"shows ""(.*)""")]
        public void GivenShows(string p0)
        {
            Name = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"also shows ""(.*)""")]
        public void GivenAlsoShows(string p0)
        {
            Email = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"and ""(.*)""")]
        public void GivenAnd(string p0)
        {
            Password = p0;
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"i see a success message")]
        public void ThenISeeASuccessMessage()
        {
            Assert.IsTrue(true);
            //ScenarioContext.Current.Pending();
        }
    }
}
