using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    static class StaffBuffer
    {
        public static string username;
        public static string passwordHash;
        public static string firstname, lastname;
        public static Boolean admin;
        public static Boolean loggedIn;
        public static int Id;
        public static string phone, email;
        public const string queryColumns = "STAFF_ID, USERNAME, PASSWORD,ADMIN,PHONE,F_NAME,L_NAME,EMAIL", table = "STAFF";

        public static string getQueryColumns()
        {
            return queryColumns;
        }

        public static string getQueryValues()
        {
            Console.WriteLine(Id + username + passwordHash + admin + phone + firstname + lastname + email);
            return (Id.ToString() +",'"+ username +"','"+ passwordHash +"','"+ admin +"','"+ phone +"','"+ firstname +"','"+ lastname +"','"+ email+"'");
        }
    }//end of Buffer class

    //extension of the oracle database controller class
    //for staff database controller
    partial class OracleDatabaseController
    {
        //this function sets the attributes of the logged in user to
        //the user controller class so it can be used whenever we need
        //active user's information
        private Boolean loginUser(string username, string password)
        {
            StaffBuffer.username = username;
            StaffBuffer.passwordHash = password;
            while (reader.Read())
            {
                StaffBuffer.Id = (int)reader["staff_id"];
                StaffBuffer.firstname = (string)reader["f_name"];
                StaffBuffer.lastname = (string)reader["l_name"];
                StaffBuffer.email = (string)reader["email"];
                StaffBuffer.phone = (string)reader["phone"];
                StaffBuffer.admin = (string)reader["admin"] == "true" ? true : false;
            }
            return false;
        }

        //this function is used to check if the username and password
        //entered by the user is correct, and accordingly authenticate the user
        //returns true if successful login, else false
        public Boolean checkLogin(string username, string password)
        {
            string tempPassword = "";
            select("*", "STAFF", "username='" + username + "'");
            while (reader.Read())
            {
                tempPassword = (string)reader["password"];
            }
            if (tempPassword.Equals(password))
            {
                //if the username and password match
                //then store all the user information
                //as Active User
                loginUser(username, password);
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public Boolean insertUser()
        {
            if (insert(StaffBuffer.table, StaffBuffer.getQueryColumns(), StaffBuffer.getQueryValues()) > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public Boolean deleteUser()
        {
            if (delete(StaffBuffer.table, "STAFF_ID=" + StaffBuffer.Id) > 0)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public void selectUserID()
        {
            select("*", StaffBuffer.table,"STAFF_ID='"+StaffBuffer.Id+"'");
            while (reader.Read())
            {
                StaffBuffer.username = (string)reader["USERNAME"];
                StaffBuffer.passwordHash = (string)reader["PASSWORD"];
                StaffBuffer.firstname = (string)reader["F_NAME"];
                StaffBuffer.lastname = (string)reader["L_NAME"];
                StaffBuffer.admin = (string)reader["admin"] == "true" ? true : false;
                StaffBuffer.phone = (string)reader["PHONE"];
                StaffBuffer.email = (string)reader["EMAIL"];
            }
            connection.Close();
        }
        public void selectUserUN()
        {
            select("*", StaffBuffer.table, "USERNAME='" + StaffBuffer.username+"'");
            while (reader.Read())
            {
                StaffBuffer.Id = Convert.ToInt32(reader["STAFF_ID"].ToString());
                StaffBuffer.passwordHash = (string)reader["PASSWORD"];
                StaffBuffer.firstname = (string)reader["F_NAME"];
                StaffBuffer.lastname = (string)reader["L_NAME"];
                StaffBuffer.admin = (string)reader["ADMIN"] == "true" ? true : false;
                StaffBuffer.phone = (string)reader["PHONE"];
                StaffBuffer.email = (string)reader["EMAIL"];
            }
            connection.Close();
        }
    }
}