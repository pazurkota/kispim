using System;
using Microsoft.Maui.Controls;

namespace kispim.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void AddTransaction_OnClicked(object? sender, EventArgs e)
	{
		await Navigation.PushAsync(new TransactionPage(null));
	}
}

