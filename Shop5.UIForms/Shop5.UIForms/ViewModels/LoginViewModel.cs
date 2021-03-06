﻿

namespace Shop5.UIForms.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Shop5.UIForms.Views;
    using Xamarin.Forms;

    public class LoginViewModel 
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(this.Login);

        public LoginViewModel ()
        {
            this.Email = "erikaitm546@gmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an email", "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "You must enter a password",
                    "Accept");
                return;
            }


            if (!this.Email.Equals("erikaitm546@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    "Incorrect user or password",
                    "Accept");
                return;
            }

            //await Application.Current.MainPage.DisplayAlert("Ok", "Fuck yeah!!!", "Accept");

            MainViewModel.GetInstance().Products = new ProductViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
        }
    }

}
