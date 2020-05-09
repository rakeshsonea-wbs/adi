using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace PeerReviewSample
{
    class Database
    {
        protected MySqlConnection connection;
        protected MySqlDataAdapter ad;
        protected DataTable dt;
        protected MySqlCommand cmd;
    
        public Database()
        {
            string connectionString = "Server=localhost;Port=3306;Database=peer_review_sample;Uid=root;Pwd=root;";
            connection = new MySqlConnection(connectionString);
        }

        protected void Create(string sqlQuery)
        {
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable Read(string sqlQuery)
        {
            dt = new DataTable();
            ad = new MySqlDataAdapter(sqlQuery, connection);
            new MySqlCommandBuilder(ad);
                connection.Open();
                ad.Fill(dt);
                connection.Close();
            return dt;
        }
        protected int GetInteger(string sqlQuery)
        {
            Int32 returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return returnValue;
        }
        protected string GetString(string sqlQuery)
        {
            string returnValue;
            cmd = new MySqlCommand(sqlQuery, connection);
            cmd.CommandType = CommandType.Text;
            connection.Open();
            returnValue =cmd.ExecuteScalar().ToString();
            connection.Close();
            return returnValue;
        }
    }
    
}
