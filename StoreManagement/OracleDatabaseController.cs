using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Oracle.DataAccess.Client;

namespace StoreManagement
{
    partial class OracleDatabaseController
    {
        //Objects required to communicate with the database
        private OracleConnection connection;
        private OracleCommand command;
        private string query;
        private OracleDataReader reader;
        private OracleDataAdapter adapter;

        public OracleDatabaseController()
        {
            //initialize the connection using the connection string
            connection = new OracleConnection("Data Source=XE;User ID=tanay;password=tanay");
        }

        //to perform the select query on the database
        //an abstratcion for casting queries
        protected void select(string columns, string table, string where)
        {
            try
            {
                query = "select " + columns + " from " + table + " where " + where;
                command = new OracleCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
            }
        }

        //
        //
        protected int insert(string table, string columns, string values)
        {
            try
            {
                query = "insert into " + table + " ( " + columns + " ) values ( " + values+" )";
                command = new OracleCommand(query, connection);
                connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                return command.ExecuteNonQuery();
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return 0;
            }
        }

        //
        //
        protected int delete(string table, string where)
        {
            try
            {
                query = "delete from " + table + " where " + where;
                command = new OracleCommand(query, connection);
                connection.Open();
                command.CommandType = System.Data.CommandType.Text;
                return command.ExecuteNonQuery();
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return 0;
            }
        }
    }
}