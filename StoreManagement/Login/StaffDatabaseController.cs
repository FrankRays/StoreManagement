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

        //querry columns string has all the column names seperated by commas, and table string has teh table name
        public const string queryColumns = "STAFF_ID, USERNAME, PASSWORD,ADMIN,PHONE,F_NAME,L_NAME,EMAIL", table = "STAFF";

        //returns a string of query columns seperated by commas
        //used for insertion of columns
        public static string getQueryColumns()
        {
            return queryColumns;
        }


        //reutrns query values of columns seperated by commas
        public static string getQueryValues()
        {
            Console.WriteLine(Id + username + passwordHash + admin + phone + firstname + lastname + email);
            return (Id.ToString() +",'"+ username +"','"+ passwordHash +"','"+ (admin?"true":"false") +"','"+ phone +"','"+ firstname +"','"+ lastname +"','"+ email+"'");
        }

        //this function flushes the buffer i.e. it clears all the buffer values
        public static void flushBuffer()
        {
            Id = 0;
            username = passwordHash = phone = firstname = lastname = email = "";
            admin = loggedIn = false;
        }

        //set login sets the loggedIn bit of the buffer to true
        //it is used to denote whether the user from the buffer
        //is logged in or not
        public static void setLogin()
        {
            loggedIn = true;
        }

        //set loggedOut sets the loggedIn bit of the buffer to false
        //it is used to denote that the usert from the buffer is not logged in
        public static void setLogout()
        {
            loggedIn = false;
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


        //this function is used to check if the username and password
        //entered by the user is an admin and is used for single sign on
        //returns true if successful login, else false
        public Boolean checkLoginAdmin(string username, string password)
        {
            string tempPassword = "";
            string tempAdmin = "";
            select("*", "STAFF", "username='" + username + "'");
            while (reader.Read())
            {
                tempPassword = (string)reader["password"];
                tempAdmin = (string)reader["admin"];
            }
            if (tempPassword.Equals(password))
            {
                if (tempAdmin == "true")
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        //this function is used to insert the data
        //from the buffer to the database
        //returns true if success else false
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

        //this function is used to delete the data from
        //the database based on the value from the buffer
        //if success then returns true else false
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

        //this function is used to modify the data from
        //the database based on the value from the buffer
        //if success then returns true else false
        public Boolean modifyUser()
        {
            string set;
            set = "USERNAME='"+StaffBuffer.username+"',PASSWORD='"+StaffBuffer.passwordHash+
                "',F_NAME='"+StaffBuffer.firstname+"',L_NAME='"+StaffBuffer.lastname+"',ADMIN='"+(StaffBuffer.admin?"true":"false")+
                "',PHONE='"+StaffBuffer.phone+"',EMAIL='"+StaffBuffer.email+"'";
            if(update(StaffBuffer.table,set,"STAFF_ID="+StaffBuffer.Id.ToString()) > 0)
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


        //this function is used to select a record from the databse
        //from the table STAFF based on the STAFF_ID
        public void selectUserID()
        {
            select("*", StaffBuffer.table,"STAFF_ID='"+StaffBuffer.Id+"'");
            while (reader.Read())
            {
                StaffBuffer.username = (string)reader["USERNAME"];
                StaffBuffer.passwordHash = (string)reader["PASSWORD"];
                StaffBuffer.firstname = (string)reader["F_NAME"];
                StaffBuffer.lastname = (string)reader["L_NAME"];
                StaffBuffer.admin = (string)reader["ADMIN"] == "true" ? true : false;
                StaffBuffer.phone = (string)reader["PHONE"];
                StaffBuffer.email = (string)reader["EMAIL"];
            }
            connection.Close();
        }

        //this function is used to select a record from the databse
        //from the table STAFF based on the USERNAME
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
        public void getNextMaxStaffId()
        {
            selectMax("STAFF_ID","ID", StaffBuffer.table);
            while (reader.Read())
            {
                StaffBuffer.Id = Convert.ToInt32(reader["ID"].ToString())+1;
            }
            connection.Close();
        }
    }
}