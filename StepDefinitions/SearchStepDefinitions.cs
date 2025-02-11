using Microsoft.Playwright;
using Fiable.Pages;

namespace Fiable.StepDefinitions
{
    [Binding]
    public sealed class SearchStepDefinitions(Hooks hooks, ABNHomepage abnHomePage)
    {
        private readonly IPage _page = hooks.Page;
        private readonly ABNHomepage _abnHomePage = abnHomePage;

        [Given("I go to ABN lookup website")]
        public async Task GivenIGoToABNLookupWebsite()
        {
            await _abnHomePage.GoTo();
        }

        [Given("the search field is empty")]
        public async Task GivenTheSearchFieldIsEmpty()
        {
            await _abnHomePage.GetTheSearchFieldValue();
        }

        [When("I enter a keyword in the search field")]
        public async Task WhenIEnterAKeywordInTheSearchField()
        {
            await _abnHomePage.SearchName();
        }

        [When("I click the search button")]
        public async Task WhenIClickTheSearchButton()
        {
            await _abnHomePage.ClickSearchButton();
        }

        [Then("I should see search results")]
        public async Task ThenIShouldSeeSearchResults()
        {
            string foundWord = await _abnHomePage.GetMatches();
        }

        [Then("I should see keyword matches responses in the name column")]
        public async Task ThenIShouldSeeKeywordMatchesResponsesInTheNameColumn()
        {
            await _abnHomePage.ValidateNameColumn();
        }
    }
}
