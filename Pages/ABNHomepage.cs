// Under research and development on how to implement Fixtures and POM for data and elements

using System.Text.RegularExpressions;
using Fiable.StepDefinitions;
using Microsoft.Playwright;

namespace Fiable.Pages
{
    public class ABNHomepage
    {
        private readonly IPage _page;

        public ABNHomepage(Hooks hooks)
        {
            _page = hooks.Page;
        }

        public async Task GoTo()
        {
            await _page.GotoAsync("https://abr.business.gov.au/");
        }

        public async Task<string> GetTheSearchFieldValue()
        {
            var searchField = _page.Locator("//input[@id=\"SearchText\"]");
            await Assertions.Expect(searchField).ToBeEmptyAsync();
            return await searchField.InputValueAsync();
        }

        public async Task SearchName()
        {
            var searchField = _page.Locator("//input[@id=\"SearchText\"]");
            await searchField.FillAsync("ABN");
        }

        public async Task ClickSearchButton()
        {
            await _page.Locator("//input[@id=\"MainSearchButton\"]").ClickAsync();
        }
        public async Task<string> GetMatches()
        {
            var paragraph = _page.Locator("//div[@id=\"content\"]//form/p");
            string paragraphText = await paragraph.InnerTextAsync();
            var findWord = "Your search for ABN found";

            if (paragraphText.Contains(findWord, StringComparison.OrdinalIgnoreCase))
            {
                return findWord;
            } else{
                throw new Exception($"The word '{findWord}' was not found in the page.");
            }
        }
        public async Task ValidateNameColumn()
        {
            var table = _page.Locator("#resultsTable");
            var columnCells = table.Locator("tr td:nth-child(2)");
            int rowCount = await columnCells.CountAsync();

            for (int i = 0; i < rowCount; i++)
            {
                var cell = columnCells.Nth(i);
                string cellText = await cell.InnerTextAsync();

                if (string.IsNullOrEmpty(cellText))
                {
                    throw new Exception($"Failed: Cell at row {i + 1} is empty.");
                }

                if (!cellText.Contains("ABN", StringComparison.OrdinalIgnoreCase))
                {
                    throw new Exception($"Failed: Cell at row {i + 1} does not contain 'ABN'.");
                }
            }
        }
    }
}