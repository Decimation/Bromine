using OpenQA.Selenium;

namespace Bromine.Utilities
{
	public static class Highlights
	{
		public static void QHighlightClick(this IWebDriver driver, IWebElement element)
		{
			driver.QHighlightSelect(element);
			element.Click();
		}

		public static void QHighlightSelect(this IWebDriver driver, IWebElement element)
		{
			var jsDriver = (IJavaScriptExecutor) driver;

			const string HIGHLIGHT_JS =
				@"$(arguments[0]).css({ ""border-width"" : ""2px"", ""border-style"" : ""solid"", ""border-color"" : ""red"" });";
			jsDriver.ExecuteScript(HIGHLIGHT_JS, element);
		}
	}
}