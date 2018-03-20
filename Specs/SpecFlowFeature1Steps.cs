using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Specs
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            //CODE HERE
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //MORE CODE HERE
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.IsTrue(true);
        }
    }
}
