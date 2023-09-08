using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBootstrap53.Features;

public partial class ToastTest
{
	[Inject] public IToastService? Toast { get; set; }

	protected override void OnInitialized()
	{
		Toast!.ShowSuccess("Test");
		base.OnInitialized();

	}
}
