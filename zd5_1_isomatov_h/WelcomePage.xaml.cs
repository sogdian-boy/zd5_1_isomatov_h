using Xamarin.Forms;
using CreditCalculator;
namespace HelloApp
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля", "OK");
                return;
            }

            await Navigation.PushAsync(new MainPage());
        }
    }
}