using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBD.Models
{
    public class Friend
    {
        public Friend()
        {
        }
        public Friend(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}

