using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    public static class OrdersBuffer
    {
        public static int id;
        public static string first_name, last_name, mode_of_payment, date_of_order, date_of_dispatch;
 
        public static void flushBuffer()
        {
            id = 0;
            first_name = last_name = mode_of_payment = date_of_order = date_of_dispatch = "";
        }
    }
    partial class OracleDatabaseController
    {
        
        public Boolean getAllRows()
        {
            try
            {
                select_distinct("SUPPLIER_NAME", "SUPPLIERS");
                if (!reader.HasRows)
                {
                    connection.Close();
                    return false;
                }
                while (reader.Read())
                {
                    ProductsBuffer.supplier_names.Add((string)reader["SUPPLIER_NAME"]);
                }
                connection.Close();
                return true;
            }
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }
        

        public int getNextMaxOrderId()
        {
            selectMax("ORDER_ID", "ID", "ORDERS");
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    OrdersBuffer.id = 0;
                }
                else
                {
                    OrdersBuffer.id = Convert.ToInt32(reader["ID"].ToString()) + 1;
                }

            }
            connection.Close();
            return 0;
        }

        public Boolean addOrderAttributes()
        {
            create("ORDER_" + OrdersBuffer.id.ToString(), "PRODUCT_NAME VARCHAR2(40) NOT NULL ENABLE, QUANTITY VARCHAR2(40) NOT NULL ENABLE,PRICE NUMBER NOT NULL ENABLE, PRIMARY KEY (PRODUCT_NAME) ENABLE");
            connection.Close();
            if (select("COUNT(1)", "ORDER_" + OrdersBuffer.id.ToString(), "ROWNUM=1"))
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
        public Boolean deleteOrderAttributes()
        {
            drop("ORDER_" + OrdersBuffer.id.ToString());
            connection.Close();
            if (!select("COUNT(1)", "ORDER_" + OrdersBuffer.id.ToString(), "ROWNUM=1"))
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
        public Boolean addOrder()
        {
            if (addOrderAttributes())
            {
                if (insert("ORDERS", "ORDER_ID,FNAME,LNAME,MODES_OF_PAYMENT,DATE_OF_ORDER,DATE_OF_DISPATCH", "'"
                    + OrdersBuffer.id.ToString() + "','"
                    + OrdersBuffer.first_name + "','"
                    + OrdersBuffer.last_name + "','"
                    + OrdersBuffer.mode_of_payment + "','"
                    + OrdersBuffer.date_of_order + "','"
                    + OrdersBuffer.date_of_dispatch + "'")
                    > 0)
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
            return false;
        }
        public Boolean selectOrder()
        {
            if (select("*", "ORDERS", "ORDER_ID='" + OrdersBuffer.id.ToString() + "'"))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        OrdersBuffer.id = Convert.ToInt32(reader["ORDER_ID"].ToString());
                        OrdersBuffer.first_name = reader["FNAME"].ToString();
                        OrdersBuffer.last_name = reader["LNAME"].ToString();
                        OrdersBuffer.mode_of_payment = reader["MODES_OF_PAYMENT"].ToString();
                        OrdersBuffer.date_of_order = reader["DATE_OF_ORDER"].ToString();
                        OrdersBuffer.date_of_dispatch = reader["DATE_OF_DISPATCH"].ToString();
                    }
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }
        public Boolean modifyOrder()
        {
            if (update("ORDERS",
                "ORDER_ID ='" + OrdersBuffer.id.ToString() + "'," +
                "FNAME='" + OrdersBuffer.first_name + "'," +
                "LNAME='" + OrdersBuffer.last_name + "'," +
                "MODES_OF_PAYMENT='" + OrdersBuffer.mode_of_payment + "'," +
                "DATE_OF_ORDER='" + OrdersBuffer.date_of_order + "'," +
                "DATE_OF_DISPATCH='" + OrdersBuffer.date_of_dispatch + "'"
                , "ORDER_ID='" + OrdersBuffer.id.ToString() + "'")
                > 0)
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
        public Boolean deleteOrder()
        {
            if (deleteOrderAttributes())
            {
                if (delete("ORDERS", "ORDER_ID='" + OrdersBuffer.id.ToString()+"'") > 0)
                {
                    connection.Close();
                    return true;
                }
            }
            return false;
        }
    }
}
