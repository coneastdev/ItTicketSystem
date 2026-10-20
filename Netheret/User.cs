using System;
using System.Collections.Generic;
using System.Text;

namespace Netheret
{
    internal class User
    {
        string Id;
        string Email;
        string Password;
        bool Admin;

        public User(string id, string email, string password, bool admin = false)
        {
            Id = id;
            Email = email;
            Password = password;
            Admin = admin;
        }
    }
}
