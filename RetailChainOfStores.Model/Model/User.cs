using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RetailChainOfStores.Model.Model
{
    public class User : IComparable<User>
    {
        private int? _id;
        private string _userName;
        private string _password;
        private AccessLevel _accessLevel;

        public enum AccessLevel
        {
            Read,
            Write,
            Edit,
            Delete
        };

        public static Dictionary<string, User.AccessLevel> AccessLevels =
            new Dictionary<string, User.AccessLevel>()
            {
                { "Read", User.AccessLevel.Read },
                { "Write", User.AccessLevel.Write },
                { "Edit", User.AccessLevel.Edit },
                { "Delete", User.AccessLevel.Delete },
            };

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
            this.Id = null;
            this.UserAccessLevel = AccessLevel.Read;
        }

        public int? Id
        {
            get { return _id; }
            set 
            {
                if (_id != null)
                    throw new ArgumentException("Id is already matters");
                _id = value;
            }
        }

        public string UserName
        {
            get { return _userName; }
            set { 
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Username", "User name can not be is null or empty.");   
                _userName = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Password", "Password can not be is null or empty.");
                _password = value;
            }
        }

        public AccessLevel UserAccessLevel
        {
            get { return _accessLevel; }
            set { _accessLevel = value; }
        }

        public int CompareTo(User other)
        {
            if (this.Id > other._id)
            {
                return 1;
            }

            if (this.Id < other.Id)
            {
                return -1;
            }
            else return 0;
        }

       
    }
}
