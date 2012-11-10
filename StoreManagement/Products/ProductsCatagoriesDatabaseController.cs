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
