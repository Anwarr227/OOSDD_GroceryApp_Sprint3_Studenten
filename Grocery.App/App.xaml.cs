using Grocery.App.Views;

namespace Grocery.App;

public partial class App : Application
{
    public App(LoginView loginPage)
    {
        InitializeComponent();
        // Wrap in NavigationPage so we can PushAsync to Register
        MainPage = new NavigationPage(loginPage);
    }
}