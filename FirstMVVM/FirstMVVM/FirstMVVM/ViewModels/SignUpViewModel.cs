using FirstMVVM.Models;
using FirstMVVM.Repositories;
using FirstMVVM.Views;
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
    public class SignUpViewModel : INotifyPropertyChanged
    {
        private string _username, _password, _email;
        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }
        public ICommand CreateAccountCommand { get; set; }
        public Task<List<Account>> Accounts { get; set; }

        public SignUpViewModel()
        {
            CreateAccountCommand = new Command(CreateAccount);
            Accounts = App.AccountDb.GetAccounts();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void CreateAccount()
        {
            Account account = new Account
            {
                Username = Username,
                Password = Password,
                Email = Email
            };
            App.AccountDb.CreateAccount(account);
            //Application.Current.MainPage.Navigation.PushAsync(new Login());
        }

        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }


    }
}
