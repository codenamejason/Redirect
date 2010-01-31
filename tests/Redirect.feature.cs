//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Tests
{
    using TechTalk.SpecFlow;
    
    
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Redirection")]
    public partial class RedirectionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Redirection", "In order to not upset the google\r\nAs a blogger who almost never has the time to b" +
                    "log\r\nI want to redirect my old url to my new one", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Redirect root request")]
        public virtual void RedirectRootRequest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Redirect root request", ((string[])(null)));
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I have entered a request to http://www.frickinsweet.com/ryanlanciaux.com");
            testRunner.And("the old url is frickinsweet.com/ryanlanciaux.com");
            testRunner.And("my new url is ryanlanciaux.com");
            testRunner.When("the request is made");
            testRunner.Then("the response url is http://www.ryanlanciaux.com");
            testRunner.And("the response has a 301 in the status");
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Redirect to correct path on new url")]
        public virtual void RedirectToCorrectPathOnNewUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Redirect to correct path on new url", ((string[])(null)));
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I have entered a request to http://www.frickinsweet.com/ryanlanciaux.com/page2");
            testRunner.And("the old url is frickinsweet.com/ryanlanciaux.com");
            testRunner.And("my new url is ryanlanciaux.com");
            testRunner.When("the request is made");
            testRunner.Then("the response url is http://www.ryanlanciaux.com/page2");
            testRunner.And("the response has a 301 in the status");
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Redirect returns false with garbage url")]
        public virtual void RedirectReturnsFalseWithGarbageUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Redirect returns false with garbage url", ((string[])(null)));
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("I have entered a request to http://www.frickinsweet.com/ryanlanciazx.com");
            testRunner.And("the old url is frickinsweet.com/ryanlanciaux.com");
            testRunner.And("my new url is ryanlanciaux.com");
            testRunner.When("the request is made");
            testRunner.Then("301 is not in the headers");
            testRunner.CollectScenarioErrors();
        }
    }
}