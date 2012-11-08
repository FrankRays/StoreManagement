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
        public Boolean getAllSupplierRows()
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

        public Boolean addOrderAttributes()
        {
            return false;
        }
        public Boolean deleteOrderAttributes()
        {
            return false;
        }
        public Boolean addOrder()
        {
            if (addOrderAttributes())
            {
            }
            return false;
        }
        public Boolean selectOrder()
        {
            return false;
        }
        public Boolean modifyOrder()
        {
            return false;
        }
        public Boolean deleteOrder()
        {
            if (deleteOrderAttributes())
            {
            }
            return false;
        }
    }
}
