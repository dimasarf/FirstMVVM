using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Models
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
