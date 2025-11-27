namespace kispim;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void AddTransaction_OnClicked(object? sender, EventArgs e)
	{
		await DisplayAlert("Alert", "Transaction added successfully!", "OK");
	}
}

