using RetailChainOfStores.Model.Model;
using RetailChainOfStores.Model.Repository;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.Model.Services
{
    public class LoginService : ILoginService
    {
        PostgresqlDataBase dataBase;

        public LoginService()
        {
            dataBase = new PostgresqlDataBase();
        }   

        public bool Login(ref User user)
        {
            bool isValidUser = dataBase.IsValidUserLogin(ref user);
            return isValidUser;
        }

        public bool Regist(ref User user)
        {
            bool isExistUser = dataBase.IsExistUserByName(user.UserName);

            if (isExistUser) 
            {
                return false;
            }
            else
            {
                user.Id = dataBase.AddNewUser(user);
                return true;
            }
        }
    }
}
