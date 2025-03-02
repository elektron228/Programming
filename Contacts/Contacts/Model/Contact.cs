using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    internal class Contact
    {
        private string _name;
        private string _email;
        private string _phone;

        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }

        public Contact(string name, string email, string phone) 
        {
            Name = name;
            Email = email;  
            Phone = phone;  
        }
    }
}
