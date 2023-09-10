using Ardalis.SmartEnum;

namespace BlazorBootstrap53.Features.Donations.Enums;

public abstract class NavItem : SmartEnum<NavItem>
{
	#region Id's
	private static class Id
	{
		internal const int Stripe = 1;  
		internal const int Zelle = 2;
		internal const int Check = 3;
	}
	#endregion

	#region  Declared Public Instances
	public static readonly NavItem Stripe = new StripeSE();
	public static readonly NavItem Zelle = new ZelleSE();
	public static readonly NavItem Check = new CheckSE();
	// SE=SmartEnum
	#endregion

	private NavItem(string name, int value) : base(name, value) { } // Constructor

	#region Extra Fields
	public abstract string ButtonId { get; }
	public abstract string Target { get; }
	public abstract string AriaControls { get; }
  public abstract string AriaActive(NavItem currentNavItem);
  public abstract string NavLinkActive(NavItem currentNavItem);
  public abstract string TabPageActive(NavItem currentNavItem);
  //public abstract string Icon { get; }
  #endregion

  #region Private Instantiation
  private sealed class StripeSE : NavItem
	{
		public StripeSE() : base($"{nameof(Id.Stripe)}", Id.Stripe) { }
		public override string ButtonId => $"{nameof(Id.Stripe).ToLower()}-tab"; 
		public override string Target => $"#{nameof(Id.Stripe).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Stripe).ToLower()}";
    public override string AriaActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Stripe ? "true" : "false"; ;
    }
    public override string NavLinkActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Stripe ? " active" : ""; ;
    }
    public override string TabPageActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Stripe ? " show active" : ""; ;
    }

  }

  private sealed class ZelleSE : NavItem
	{
		public ZelleSE() : base($"{nameof(Id.Zelle)}", Id.Zelle) { }
		public override string ButtonId => $"{nameof(Id.Zelle).ToLower()}-tab";
		public override string Target => $"#{nameof(Id.Zelle).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Zelle).ToLower()}";
    public override string AriaActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Zelle ? "true" : "false"; ;
    }
    public override string NavLinkActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Zelle ? " active" : ""; ;
    }
    public override string TabPageActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Zelle ? " show active" : ""; ;
    }

  }

  private sealed class CheckSE : NavItem
	{
		public CheckSE() : base($"{nameof(Id.Check)}", Id.Check) { }
		public override string ButtonId => $"{nameof(Id.Check).ToLower()}-tab";
		public override string Target => $"#{nameof(Id.Check).ToLower()}";
		public override string AriaControls => $"{nameof(Id.Check).ToLower()}";
    public override string AriaActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Check ? "true" : "false"; ;
    }
    public override string NavLinkActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Check ? " active" : ""; ;
    }
    public override string TabPageActive(NavItem currentNavItem)
    {
      return currentNavItem == NavItem.Check ? " show active" : ""; ;
    }


  }


  #endregion

  // Ignore Spelling: Zelle
}
