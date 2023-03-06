using RetailChainOfStores.Model.Model;
using RetailChainOfStores.Model.Repository;
using System;
using System.CodeDom;

namespace TestConsoleApp
{
    public class PostgresqlDataBaseTest
    {
        private PostgresqlDataBase dataBase;
        public PostgresqlDataBaseTest()
        {
            dataBase = new PostgresqlDataBase();
        }

        public void TestConnect()
        {
            var isConnect = dataBase.IsConnect();   

            if (isConnect)
            {
                Console.WriteLine("Postgresql data base is connect");
            }
            else
            {
                Console.WriteLine("Postgresql data base is disconnect");
            }
        }

        public void TestAddNewUser()
        {
            var user = new User("testUser", "testPassword");
            var userId = dataBase.AddNewUser(user);

            Console.WriteLine("Add new user in users data table with user_id = {0}", userId);
        }


        public void TestRemoveUser(int userId)
        {
            dataBase.RemoveUser(userId);
            Console.WriteLine("Remove user in users data table with user_id = {0}", userId);
        }

        public void TestIsExistUser(int userId)
        {
            var isExist = dataBase.IsExistUser(userId);
            if (isExist)
            {
                Console.WriteLine("User is exist");
            }
            else
            {
                Console.WriteLine("User is not exist");
            }
        }

        public void TestIsValidUserLogin()
        {
            //var result = dataBase.IsValidUserLogin("testUser", "testPassword");

            //if (result) Console.WriteLine("Login succes");
            //else Console.WriteLine("Login failed");
        }

        public void TestIsExistUserByName()
        {
            string name = "testUser";
            var result = dataBase.IsExistUserByName(name);

            if (result) Console.WriteLine("User is exist");
            else Console.WriteLine("User is not exist");
        }
    }
}
