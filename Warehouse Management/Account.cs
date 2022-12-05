using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{

    class Account
    {
        private string _name;
        private string _password;

        public string Name { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Password { get => _password; set => _password = value; }

        public Account()
        {

        }
    }
}
