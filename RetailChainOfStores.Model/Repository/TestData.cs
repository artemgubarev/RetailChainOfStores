using RetailChainOfStores.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.Model.Repository
{
    public class TestData
    {
        PostgresqlDataBase _postgresqlDataBase = new PostgresqlDataBase();

        public User[] CreateUsers()
        {
            var users = new User[10]
            {
                new User("Misha", "miwawws"),
                new User("Artembek", "artembekwws"),
                new User("Beka", "bekawws"),
                new User("Tema", "temawws"),
                new User("Grisha", "grishawws"),
                new User("Sema", "semawws"),
                new User("Chigur", "chigurwws"),
                new User("Chugun", "chugunwws"),
                new User("Vasya", "vasyawws"),
                new User("Игроь Викторович", "nstu2023"),
            };

            return users;
        }

        public void AddUsers() 
        {
            var users = CreateUsers();
            foreach (var item in users)
            {
                _postgresqlDataBase.AddNewUser(item);
            }
        }
    }
}
