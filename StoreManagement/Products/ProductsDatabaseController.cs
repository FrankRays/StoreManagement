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

namespace StoreManagement
{
    public static class ProductsBuffer
    {
        public static List<string> supplier_names = new List<string>();
        public static List<string> product_categories = new List<string>();
        public static int id;
        public static string product_name;
        public static string active_supplier_name;
        public static string active_product_catagory;
        public static int wholesale_cost;
        public static int retail_cost;

        public static void clearLists()
        {
            supplier_names.Clear();
            product_categories.Clear();
        }

        public static void flushBuffer()
        {
            id = wholesale_cost = retail_cost = 0;
            product_name = active_supplier_name = active_product_catagory = "";
        }
    }
    partial class OracleDatabaseController
    {
        
        public Boolean getAllSupplierRowsForProducts()
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
        
        public Boolean getAllProductCategoryRows()
        {
            try
            {
                select_distinct("PRODUCT_CATEGORY", "PRODUCT_CATEGORIES");
                if (!reader.HasRows)
                {
                    connection.Close();
                    return false;
                }
                while (reader.Read())
                {
                    ProductsBuffer.product_categories.Add((string)reader["PRODUCT_CATEGORY"]);
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

        public void getNextMaxProductId()
        {
            selectMax("PRODUCT_ID", "ID", "PRODUCTS");
            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    ProductsBuffer.id = 0;
                } 
                else
                {
                    ProductsBuffer.id = Convert.ToInt32(reader["ID"].ToString()) + 1;
                }
                
            }
            connection.Close();
        }

        public Boolean addProduct()
        {
            if (insert("PRODUCTS",
                "PRODUCT_ID,PRODUCT_NAME,SUPPLIER_NAME,PRODUCT_CATEGORY,WHOLESALE_COST,RETAIL_COST",
                "'" + ProductsBuffer.id + "','" + ProductsBuffer.product_name + "','" + ProductsBuffer.active_supplier_name +
                "','" + ProductsBuffer.active_product_catagory + "','" +
                ProductsBuffer.wholesale_cost + "','" + ProductsBuffer.retail_cost + "'") > 0)//if qurey returns int > 0
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

        public Boolean selectProduct()
        {
            if (select("*", "PRODUCTS", "PRODUCT_ID='" + ProductsBuffer.id + "'"))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductsBuffer.id = Convert.ToInt32(reader["PRODUCT_ID"].ToString());
                        ProductsBuffer.product_name = reader["PRODUCT_NAME"].ToString();
                        ProductsBuffer.active_supplier_name = reader["SUPPLIER_NAME"].ToString(); ;
                        ProductsBuffer.active_product_catagory = reader["PRODUCT_CATEGORY"].ToString(); ;
                        ProductsBuffer.wholesale_cost = Convert.ToInt32(reader["WHOLESALE_COST"].ToString());
                        ProductsBuffer.retail_cost = Convert.ToInt32(reader["RETAIL_COST"].ToString());
                    }
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public Boolean modifyProduct()
        {
            if (update("PRODUCTS",
                "PRODUCT_ID='" + ProductsBuffer.id +
                "',PRODUCT_NAME='" + ProductsBuffer.product_name +
                "',SUPPLIER_NAME='" + ProductsBuffer.active_supplier_name +
                "',PRODUCT_CATEGORY='" + ProductsBuffer.active_product_catagory +
                "',WHOLESALE_COST='" + ProductsBuffer.wholesale_cost.ToString() +
                "',RETAIL_COST='" + ProductsBuffer.retail_cost.ToString() + "'",
                "PRODUCT_ID='" + ProductsBuffer.id.ToString() + "'")
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

        public Boolean deleteProduct()
        {
            if (delete("PRODUCTS", "PRODUCT_ID='" + ProductsBuffer.id + "'") > 0)
            {
                connection.Close();
                ProductsBuffer.flushBuffer();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
