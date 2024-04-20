using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap53.Features.ThresholdCovenant;

public static class DynamicComponentPaths
{
	public static string BookSectionCards = "BlazorBootstrap53.Features.ThresholdCovenant.BookSections.";
}

public static class Strongs
{
	public static MarkupString H(string number)
	{
		return (MarkupString)$"<sup><a href='https://www.blueletterbible.org/lexicon/{number}/kjv/wlc/0-1/' target='blank' title='Blue Letter Bible WLC Lexicon {number}'>{number}</a></sup>";
	}

	public static MarkupString G(string number)
	{
		return (MarkupString)$"<sup><a href='https://www.blueletterbible.org/lexicon/{number}/kjv/tr/0-1/>' target='blank' title='Blue Letter Bible TR Lexicon {number}'{number}</a></sup>";
	}

}

// Ignore Spelling: Strongs, kjv, wlc