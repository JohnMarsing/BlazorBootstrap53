namespace BlazorBootstrap53.Features.Donations;

public partial class Index
{
	protected Enums.NavItem currentNavItem = Enums.NavItem.Stripe;

	private void OnButtonClicked(Enums.NavItem tabItem)
	{
		currentNavItem = tabItem;
		StateHasChanged();
	}
}
