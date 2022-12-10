using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management
{

    class Account
    {
        private string _name;
        private string _password;
        public List<string> users = new List<string>();
        public List<string> ID = new List<string>();
        public List<string> passwords = new List<string>();
        public List<string> balance = new List<string>();

        public void getsAccounts()
        {
            StreamReader sr = new StreamReader("AccountList.txt");
            string line = "";
            while((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                ID.Add(components[1]);
                passwords.Add(components[2]);
                balance.Add(components[3]);
            }
        }
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
