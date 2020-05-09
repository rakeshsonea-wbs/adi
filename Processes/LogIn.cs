using PeerReviewSample.Utilities;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace PeerReviewSample.Processes
{
    class LogIn:Database
    {
        private string username;
        private string encryptedPassword;
        private int userId;
        public LogIn(int userId)
        {
            this.userId = userId;
        }
        public LogIn(string username, string password)
        {
            this.username = username;
            encryptedPassword = Encrypter.Encrypt(password);
        }
        public Boolean Authenticate()
        {
            return IsUsernameExist() && IsPasswordCorrect();
        }
        private Boolean IsUsernameExist()
        {
            string sqlQuery = "SELECT count(username) FROM  users WHERE username='"+username+"';";
            return  runBooleanQuery(sqlQuery);
        }
        private Boolean IsPasswordCorrect()
        {
            string sqlQuery = "SELECT count(username) FROM  users WHERE password='" + encryptedPassword + "';";
            return runBooleanQuery(sqlQuery);
        }
        private Boolean runBooleanQuery(string sqlQuery)
        {
            int count;
            count = GetInteger(sqlQuery);
            return (count == 0) ? false : true;
        }
        public int GetUserId()
        {
            string sqlQuery = "SELECT userId FROM  users WHERE username='" + username + "';";
            return GetInteger(sqlQuery);
        }
        public String GetFullName()
        {
            string fullName;
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string sqlQuery = "SELECT CONCAT(firstname,' ', surname) AS FullName FROM  users WHERE userId=" + userId + ";";
            fullName= GetString(sqlQuery);
            return myTI.ToTitleCase(fullName);

        }
    }
}
