using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
    //this class acts as a buffer between the 
    //Product Categories form and the database
    public static class ProductCategoryBuffer
    {
        static string product_category;
        public static void setProductCatagory(string product_catagory)
        {
            ProductCategoryBuffer.product_category = product_catagory;
        }
        public static string getProductCatagory()
        {
            return product_category;
        }
        public static void flush()
        {
            ProductCategoryBuffer.product_category = "";
        }
    }

    partial class OracleDatabaseController
    {
        //performs an add query, if the query succeeds,
        //returns a true else returns a false
        public Boolean addProductCategory()
        {
            try
            {
                if (insert("PRODUCT_CATEGORIES", "PRODUCT_CATEGORY", "'" + ProductCategoryBuffer.getProductCatagory() + "'") > 0)
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
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }

        //performs a select query
        //returns a true if the query succeeds else returns a false
        public Boolean selectProductCategory()
        {
            try
            {
                if (select("*", "PRODUCT_CATEGORIES", "PRODUCT_CATEGORY='" + ProductCategoryBuffer.getProductCatagory() + "'"))
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
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }

        //performs a delete query
        //returns a true is the query succeeds else returns a false
        public Boolean deleteProductCategory()
        {
            try
            {
                if (delete("PRODUCT_CATEGORIES", "PRODUCT_CATEGORY='" + ProductCategoryBuffer.getProductCatagory() + "'") > 0)
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
            catch (Oracle.DataAccess.Client.OracleException oe)
            {
                Console.WriteLine(oe);
                connection.Close();
                return false;
            }
        }
    }
}
