/*
 *  This project is a simlpe implmentation of store management database
 *  Copyright (C) 2012  Tanay Virkant Prabhu Desai
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.VisualBasic;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

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
        private DataSet dataSet;

        public OracleDatabaseController()
        {
            //initialize the connection using the connection string
            connection = new OracleConnection("Data Source=XE;User ID=tanay;password=tanay");
        }

        //to perform the select query on the database
        //an abstratcion for casting queries
        //returns true if success else false
        protected Boolean select(string columns, string table, string where)
        {
            try
            {
                query = "select " + columns + " from " + table + " where " + where;
                command = new OracleCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return false;
            }
        }

        //to perform the select query on the database
        //an abstratcion for casting queries
        //without where
        protected Boolean select(string columns, string table)
        {
            try
            {
                query = "select " + columns + " from " + table ;
                command = new OracleCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return false;
            }
        }

        protected Boolean select_distinct(string columns, string table)
        {
            try
            {
                query = "select distinct (" + columns + ") from " + table + "";
                command = new OracleCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                return false;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return false;
            }
        }

        //to perform the insert query on the database
        //an abstratcion for casting queries
        //returns the number of records inserted
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

        //to perform detele query on the database
        //an abstratcion for casting queries
        //returns true if success else false
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

        //to perform update query on the database
        //an abstratcion for casting queries
        //returns true if success else false
        protected int update(string table, string set, string where)
        {
            try
            {
                query = "update " + table +" set "+ set +" where " + where;
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

        //select max function for generation IDs
        //if succeded returns a non zero positive value 
        //else returns a zero value
        protected Boolean selectMax(string max,string select_as,  string from)
        {
            try
            {
                query = "select MAX(" + max + ") as "+select_as+" from " + from + "";
                command = new OracleCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                return true;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                return false;
            }
        }

        //creates a new table with the attribuetes 
        //as supplied in the attributes string
        protected int create(string table, string attributes)
        {
            try
            {
                query = "create table " + table + " ( " + attributes + " )";
                command = new OracleCommand(query, connection);
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (OracleException oe)
            {
                Console.WriteLine(oe);
                return 0;
            }
        }

        //drops a table
        protected int drop(string table)
        {
            try
            {
                query = "drop table " + table + "";
                command = new OracleCommand(query, connection);
                connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (OracleException oe)
            {
                Console.WriteLine(oe);
                return 0;
            }
        }

        //assign a dataset to a datagrid
        public DataGridView getDataSet(string table, DataGridView dataGridView)
        {
            try
            {
                query = "SELECT * FROM " + table;
                command = new OracleCommand(query, connection);
                connection.Open();
                adapter = new OracleDataAdapter(query,connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "test");
                dataGridView.DataSource = dataSet.Tables[0];
                connection.Close();
                return dataGridView;
            }
            catch (OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return new DataGridView();
            }
        }
        public List<string> getStringListForColumnFromTable(string table, string column)
        {
            List<string> tempList = new List<string>();
            try
            {
                select_distinct(column, table);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempList.Add(reader[column].ToString());
                    }
                    connection.Close();
                }
            }
            catch(OracleException oe)
            {
                Console.WriteLine(oe);
            }
            return tempList;
        }
    }
}