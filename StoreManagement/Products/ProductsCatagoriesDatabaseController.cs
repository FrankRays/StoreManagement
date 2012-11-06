using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManagement
{
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
