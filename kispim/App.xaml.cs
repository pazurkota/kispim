using kispim.Pages;
using Microsoft.Maui.Controls;

namespace kispim;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
