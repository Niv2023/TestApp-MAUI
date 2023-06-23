using TestApp.Models;
using LocalizationResourceManager.Maui;
namespace TestApp;

public partial class App : Application
{
	public App(ILocalizationResourceManager localizationResource)
	{
		InitializeComponent();
		AppData.Init(localizationResource);
		MainPage = new AppShell();
	}
}
