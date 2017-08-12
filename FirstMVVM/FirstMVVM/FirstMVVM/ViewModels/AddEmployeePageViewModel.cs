using FirstMVVM.Models;
using FirstMVVM.Repositories;
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
    public class AddEmployeePageViewModel : INotifyPropertyChanged
    {
        private string _employeeName, _department;
        private int _age;

        public event PropertyChangedEventHandler PropertyChanged;

        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }
        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        public int Age   { get; set; }
        public ICommand AddEmployeeCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public AddEmployeePageViewModel()
        {
            AddEmployeeCommand = new Command(AddEmployee);
            CancelCommand = new Command(Cancel);
        }

        private void Cancel(object obj)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        private void AddEmployee(object obj)
        {
            Employee emp = new Employee()
            {
                Name = EmployeeName,
                Department = Department                
            };
            App.EmployeeDb.SaveEmployee(emp);
        }

        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
