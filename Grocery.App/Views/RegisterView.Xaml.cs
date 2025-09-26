using System.Net.Mail;

namespace Grocery.App.Views;

public partial class RegisterView : ContentPage
{
    public RegisterView()
    {
        InitializeComponent();
    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text?.Trim();
        string email = EmailEntry.Text?.Trim();
        string password = PasswordEntry.Text;

        // ✅ Check of email geldig is met System.Net.Mail
        if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
        {
            MessageLabel.Text = "Voer een geldig e-mailadres in.";
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            MessageLabel.Text = "Voer een wachtwoord in.";
            return;
        }

        // Alles klopt → door naar AppShell
        Application.Current.MainPage = new AppShell();
    }

    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}