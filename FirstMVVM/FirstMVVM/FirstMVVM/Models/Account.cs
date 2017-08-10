using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Models
{
    public class Account
    {
        [PrimaryKey]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
