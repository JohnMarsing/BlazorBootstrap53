using Ardalis.SmartEnum;

namespace BlazorBootstrap53.Enums;

[Flags]
public enum PageListType
{
	None = 0,
	SitemapPage = 1,
	Footer = 2,
	Layout = 4,
	Reply = 8
}

public abstract class Nav : SmartEnum<Nav>
{

	#region Id's
	private static class Id
	{
		internal const int Home = 1;
		internal const int About = 2;
		internal const int Donate = 3;
		internal const int Location = 4;
		internal const int Sitemap = 5;
		internal const int Contact = 6;
		internal const int ThresholdCovenant = 7;
		internal const int Store = 8;
		internal const int SampleCode = 9;
		internal const int DarkModeSupport = 10;
		internal const int Carousel = 11;
		internal const int Accordion = 12;
		internal const int Planner = 13;
		internal const int Pagination = 14;
		internal const int ToastTest = 15;

		/*
		 Index 
		 Features\Accordion 

		 Features\Calendar\Planner\
		 Features\Test\Pagination\ 
		 Features\Test\Toast\Index @page "/ToastTest"

			public static class DarkModeSupport
			{
				public const string Index = "/DarkModeSupport";
				public const string Title = "Dark Mode Support";
				public const string Icon = "fas fa-lightbulb"; 
			}


			public static class Carousel
			{
				public const string Index = "/Carousel";
				public const string Title = "Carousel";
				public const string Icon = "fas fa-image";
			}		 

		 */
	}
	#endregion

	#region  Declared Public Instances
	public static readonly Nav Home = new HomeSE();
	public static readonly Nav About = new AboutSE();
	public static readonly Nav Donate = new DonateSE();
	public static readonly Nav Location = new LocationSE();
	public static readonly Nav Sitemap = new SitemapSE();
	public static readonly Nav Contact = new ContactSE();
	public static readonly Nav ThresholdCovenant = new ThresholdCovenantSE();
	public static readonly Nav Store = new StoreSE();
	public static readonly Nav SampleCode = new SampleCodeSE();
	#endregion

	private Nav(string name, int value) : base(name, value)  // Constructor
	{
	}

	#region Extra Fields
	public abstract string Index { get; }
	public abstract string Title { get; }
	public abstract string Icon { get; }
	public abstract int Sort { get; }
	public abstract bool IsPartOfList(PageListType pageListType);
	public abstract PageListType PageListType { get; }
	#endregion

	#region Private Instantiation
	private sealed class HomeSE : Nav
	{
		public HomeSE() : base($"{nameof(Id.Home)}", Id.Home) { }
		public override string Index => "/";
		public override string Title => "Home";
		public override string Icon => "fas fa-home";
		public override int Sort => Id.Home;
		public override PageListType PageListType => PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class AboutSE : Nav
	{
		public AboutSE() : base($"{nameof(Id.About)}", Id.About) { }
		public override string Index => "/About";
		public override string Title => "About";
		public override string Icon => "fas fa-info";
		public override int Sort => Id.About;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class DonateSE : Nav
	{
		public DonateSE() : base($"{nameof(Id.Donate)}", Id.Donate) { }
		public override string Index => "/Donate";
		public override string Title => "Donate";
		public override string Icon => "fas fa-donate";
		public override int Sort => Id.Donate;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class LocationSE : Nav
	{
		public LocationSE() : base($"{nameof(Id.Location)}", Id.Location) { }
		public override string Index => "/Location";
		public override string Title => "Location";
		public override string Icon => "fas fa-map-signs";
		public override int Sort => Id.Location;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class SitemapSE : Nav
	{
		public SitemapSE() : base($"{nameof(Id.Sitemap)}", Id.Sitemap) { }
		public override string Index => "/Sitemap";
		public override string Title => "Sitemap";
		public override string Icon => "fas fa-sitemap";
		public override int Sort => Id.Sitemap;
		public override PageListType PageListType => PageListType.Footer | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ContactSE : Nav
	{
		public ContactSE() : base($"{nameof(Id.Contact)}", Id.Contact) { }
		public override string Index => "/Contact";
		public override string Title => "Contact";
		public override string Icon => "far fa-comment-dots";
		public override int Sort => Id.Contact;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class ThresholdCovenantSE : Nav
	{
		public ThresholdCovenantSE() : base($"{nameof(Id.ThresholdCovenant)}", Id.ThresholdCovenant) { }
		public override string Index => "/ThresholdCovenant";
		public override string Title => "Threshold Covenant";
		public override string Icon => "fas fa-broom";
		public override int Sort => Id.ThresholdCovenant;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout | PageListType.Footer;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class StoreSE : Nav
	{
		public StoreSE() : base($"{nameof(Id.Store)}", Id.Store) { }
		public override string Index => "/Store";
		public override string Title => "Store";
		public override string Icon => "fas fa-shopping-cart";
		public override int Sort => Id.Store;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}

	private sealed class SampleCodeSE : Nav
	{
		public SampleCodeSE() : base($"{nameof(Id.SampleCode)}", Id.SampleCode) { }
		public override string Index => "/SampleCode";
		public override string Title => "Sample Code";
		public override string Icon => "fas fa-vial";
		public override int Sort => Id.SampleCode;
		public override PageListType PageListType => PageListType.SitemapPage | PageListType.Layout;
		public override bool IsPartOfList(PageListType pageListType) => (PageListType & pageListType) == pageListType;
	}
	#endregion

}