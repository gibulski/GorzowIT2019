using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GorzowIT2019
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Wyraź swoją opinię", "Czy spotkania GorzówIT są ok?", "Tak", "Nie");
        }

        private async void OpenPageButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new LoginPage());

            await Navigation.PushAsync(new LoginPage());

        }


    }
}
