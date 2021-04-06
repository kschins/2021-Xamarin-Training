using Xamarin.Forms;
using System;

namespace Magenic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel(Navigation);
        }

        private async void OnLogInButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomeTabbedPage());
        }
    }
}
