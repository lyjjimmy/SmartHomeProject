using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SmartHomeSystem
{
    class User
    {
        /*Definitions for attributes*/
        private int userId
        {
            get { return userId; }
            set { userId = value; }
        }
        private int userType
        {
            get { return userType; }
            set { userType = value; }
        }
        private string userName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        private string userContact
        {
            get { return userContact; }
            set { userContact = value; }
        }

        /* Constructor for the User Class*/
        public User(int id, int type, string name, string password, string contact)
        {
            this.userId = id;
            this.userType = type;
            this.userName = name;
            this.userPassword = password;
            this.userContact = contact;
        }

        public bool addUser()
        {
            /*Should pass from WPF to this sub to add a user
             * hash the password, try catch structure,
             * return true for success, false for nope.avi */
            return true;
        }

        public bool removeUser()
        {
            /*Remove the user from database, try catch the statement...
             * return true for success, false for remove */
            return true;
        }

        public bool updateUser()
        {
            return true;
        }

    }

    
}
