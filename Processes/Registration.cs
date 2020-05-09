using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PeerReviewSample.Processes
{
   
    class Registration:Database
    {
        public  void Register(User newUser)
        {
            InsertUser(newUser);
            InsertReviewerSpecialism(newUser);
     
        }
        private void InsertUser(User newUser)
        {
            string sqlQuery = "INSERT INTO users (firstname, surname, username,password)" +
                " VALUES ('" + newUser.Firstname + "','" + newUser.Surname + "'," +
               "'" + newUser.Username + "','" + newUser.Password + "')";
            this.Create(sqlQuery);
        }
        private int GetUserId()
        {
            string sqlQuery = "SELECT userId FROM  users ORDER BY userId DESC LIMIT 1;";
            return GetInteger(sqlQuery);
        }
        private void InsertReviewerSpecialism(User newUser)
        {
            string sqlQuery;
            int reviewerId = GetUserId();
            
            for (int i = 0; i < newUser.SpecialismList.Length; i++)
            {
                sqlQuery = "INSERT INTO reviewerspecialisms(reviewerId, specialism) " +
                    "values (" + reviewerId + ",'" + newUser.SpecialismList[i] + "');";
                Create(sqlQuery);
            }
        }
        
    }
}
