using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SmartHomeSystem
{
    class User
    {
        int userId
        {
            get { return userId; }
            set { userId = value; }
        }
        int userType
        {
            get { return userType; }
            set { userType = value; }
        }
        string userName
        {
            get { return userName; }
            set { userName = value; }
        }
        string userPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        string userContact
        {
            get { return userContact; }
            set { userContact = value; }
        }

        public User(int id, int type, string name, string password, string contact)
        {
            this.userId = id;
            this.userType = type;
            this.userName = name;
            this.userPassword = password;
            this.userContact = contact;
        }


    }

    
}
