using FirstMVVM.Repositories;
using FirstMVVM.Services;
using FirstMVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FirstMVVM
{
    public partial class App : Application
    {
        static AccountRepositories _accountDb;
        static EmployeeRepositories _employeeDb;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }

        public static AccountRepositories AccountDb
        {
            get
            {
                if (_accountDb == null)
                    _accountDb = new AccountRepositories(DependencyService.Get<ILocalFileHelper>().GetLocalPath("Account.db3"));
                return _accountDb;
            }
        }

        public static EmployeeRepositories EmployeeDb
        {
            get
            {
                if (_employeeDb == null)
                    _employeeDb = new EmployeeRepositories(DependencyService.Get<ILocalFileHelper>().GetLocalPath("Employee.db3"));
                return _employeeDb;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
