﻿using FirstMVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstMVVM.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand SignUpCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private INavigation navigation;
        private string _message;
        public string Message
        { get
          {
                return _message;
          }
          set
          {
                _message = value;
                OnPropertyChanged("Message");
          }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {
            SignUpCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushAsync(new SignUp()));
            LoginCommand = new Command(Login);
        }
    

        public LoginViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            SignUpCommand = new Command(async()=> await navigation.PushAsync(new SignUp()));
        }

        public async void Login()
        {
            await App.AccountDb.Login(Username, Password);
            await App.Current.MainPage.Navigation.PushAsync(new Dashboard());
        }

        public async Task SignUp()
        {
            await navigation.PushAsync(new SignUp());
            //Message = "Hello";
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
