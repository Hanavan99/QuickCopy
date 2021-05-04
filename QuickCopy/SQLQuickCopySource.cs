using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class SQLQuickCopySource : IQuickCopySource
    {

        public string URL { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private readonly SqlConnection conn;
        private readonly string userPassword;
        private readonly int userID;

        public SQLQuickCopySource(string url, string database, string username, string password, string userUsername, string userPassword)
        {
            URL = url;
            Database = database;
            Username = username;
            Password = password;
            this.userPassword = userPassword;

            // connect to database
            conn = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", URL, Database, Username, Password));
            conn.Open();

            SHA256CryptoServiceProvider hash = new SHA256CryptoServiceProvider();

            // get user ID
            SqlCommand command = new SqlCommand("SELECT ID FROM QuickCopy.Users WHERE UserName = @UserName AND PasswordHash = @PasswordHash AND LoginEnabled = 1", conn);
            command.Parameters.AddWithValue("@UserName", userUsername);
            command.Parameters.AddWithValue("@PasswordHash", hash.ComputeHash(System.Text.Encoding.Unicode.GetBytes(userPassword)));
            object ret = command.ExecuteScalar();
            if (ret != null)
            {
                userID = (int)ret;
            }
            else
            {
                throw new InvalidOperationException("Failed to log in to QuickCopy as user " + userUsername + ": username or password is incorrect or login not enabled");
            }
        }

        public string GetData(string key)
        {
            SqlCommand command = new SqlCommand("SELECT [Data] FROM QuickCopy.Users WHERE ID = @UserID", conn);
            command.Parameters.AddWithValue("@UserID", userID);
            object ret = command.ExecuteScalar();
            return ret.Equals(DBNull.Value) ? null : EncryptionHandler.Decrypt(key, (byte[]) ret);
        }

        public void PutData(string key, string json)
        {
            SqlCommand command = new SqlCommand("UPDATE QuickCopy.Users SET [Data] = @Data WHERE ID = @UserID", conn);
            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@Data", EncryptionHandler.Encrypt(key, json));
            command.ExecuteNonQuery();
        }
    }
}
