using FirstMVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Repositories
{
    public class EmployeeRepositories
    {
        readonly SQLiteAsyncConnection _employeeDb;

        public EmployeeRepositories(string FileName)
        {
            _employeeDb = new SQLiteAsyncConnection(FileName);
            _employeeDb.CreateTableAsync<Employee>().Wait();
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return _employeeDb.Table<Employee>().ToListAsync();
        }

        public Task<int> SaveEmployee(Employee employee)
        {
            if (employee.EmployeeId == 0)
                return _employeeDb.InsertAsync(employee);
            else
                return _employeeDb.UpdateAsync(employee);

        }

        public Task<int> DeleteEmployee(Employee employee)
        {
            return _employeeDb.DeleteAsync(employee);
        }

    }
}
