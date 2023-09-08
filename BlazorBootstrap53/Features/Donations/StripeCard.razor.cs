using BlazorBootstrap53.Settings;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BlazorBootstrap53.Features.Donations;

public partial class StripeCard
{
	[Inject] public IOptions<DonationSettings>? DonationSettings { get; set; }

	private string? StripeBuyButtonId;
	private string? StripePublishableKey;

	protected override void OnInitialized()
	{
		base.OnInitialized();
		StripeBuyButtonId = DonationSettings!.Value.StripeBuyButtonId;
		StripePublishableKey = DonationSettings!.Value.StripePublishableKey;
	}
}
