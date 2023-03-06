using Npgsql;
using RetailChainOfStores.Model.Model;
using RetailChainOfStores.Model.Services;
using System;
using System.Collections.Generic;

namespace RetailChainOfStores.Model.Repository
{
    public class PostgresqlDataBase : IDisposable
    {
        private readonly string ConnectionString =
            @"Host=dpg-cg110me4dadfmcoo6r6g-a.oregon-postgres.render.com;
            Port=5432;
            Username=retailchainofstoresdatabase_908y_user;
            Password=LuEQn7n2QrVsGEeb4JOwajyKlGmyAg1o;Database=retailchainofstoresdatabase_908y;
            Pooling=false;
            CommandTimeout=300;
            Timeout=300;
            Keepalive=300;
            Connection Idle Lifetime=300;
            Tcp Keepalive=true;";

        private NpgsqlConnection Connection;
        private bool disposed = false;

        public PostgresqlDataBase()
        {
            Connection = new NpgsqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                Connection.Close();
                Connection.Dispose();
            }

            disposed = true;
        }

        ~PostgresqlDataBase()
        {
            Dispose(disposing: false);
        }
       
        public bool IsConnect()
        {
            if (this.Connection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region User
        public bool IsExitUser(User user)
        {
            bool isExistUser = false;

            return isExistUser;
        }

        public int AddNewUser(User user)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            string query
               = @"INSERT INTO users (user_name, password_hash) 
                    VALUES (@user_name, @password_hash) RETURNING user_id;";

            // set hash value
            var passwordHash = MD5Service.EncodeString(user.Password);

                using (var cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("user_name", user.UserName));
                    cmd.Parameters.Add(new NpgsqlParameter("password_hash", passwordHash));
                    var userId = cmd.ExecuteScalar();
                    return (int)userId;
                }
        }

        public void RemoveUser(int userId)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            string query = @"DELETE FROM users WHERE user_id = @user_id;";
           

                using (var cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("user_id", userId));
                    cmd.ExecuteNonQuery();
                }
        }

        public bool IsExistUser(int? userId)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            bool isExist = false;

            string query = @"SELECT 1 FROM users WHERE user_id = @user_id";

                using (var cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("user_id", userId));
                    isExist = cmd.ExecuteScalar() != null;
                }

            return isExist;
        }

        public bool IsExistUserByName(string userName)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            bool isExist = true;

            string query = @"SELECT * FROM users WHERE user_name = @username";

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                cmd.Parameters.Add(new NpgsqlParameter("username", userName));
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows) isExist = false;
                } 
            }

            return isExist;
        }

        public bool IsValidUserLogin(ref User user)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            string query = @"SELECT * FROM users WHERE user_name = @username";
            bool isValid = true;

            string passwordHash = MD5Service.EncodeString(user.Password);

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                cmd.Parameters.Add(new NpgsqlParameter("username", user.UserName));

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows) isValid = false;

                    while (reader.Read())
                    {
                        var _passwordHash = reader.GetString(2);

                        if (!MD5Service.CompareHashStrings(_passwordHash, passwordHash))
                        {
                            isValid = false;
                        }

                        var accessLevel = reader.GetString(3);
                        user.UserAccessLevel = User.AccessLevels[accessLevel];
                    }
                }
            }
            return isValid;
        }

        public User[] GetAllUsers()
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            List<User> users = new List<User>();

            string query = @"SELECT * FROM users";

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetValue(0);
                        var username = reader.GetString(1);
                        var accesslevel = reader.GetString(3);

                        var user = new User(username, "1");
                        user.UserAccessLevel = User.AccessLevels[accesslevel];
                        user.Id = int.Parse(userId.ToString());
                        users.Add(user);
                    }
                }
            }

            users.Sort();
            return users.ToArray();
        }

        public void SetUserAccessLevel(int userId, User.AccessLevel accessLevel)
        {
            if (!IsConnect())
                throw new System.Exception("No connect data base.");

            string query = @"UPDATE users SET access_level=@accessLevel WHERE user_id = @userId";

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                cmd.Parameters.Add(new NpgsqlParameter("userId", userId));
                cmd.Parameters.Add(new NpgsqlParameter("accessLevel", accessLevel.ToString()));
                cmd.ExecuteNonQuery();  
            }

        }

        #endregion

    }
}
