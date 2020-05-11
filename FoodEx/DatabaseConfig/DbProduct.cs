using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using FoodEx.DatabaseConfig;

namespace FoodEx.DatabaseConfig
{
    class DbProduct
    {
        private static string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public static void db_addNewProduct(Product product)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"INSERT INTO Product(name,price,type,description,image,create_date,owner,score) VALUES('{product.GetName()}','{product.GetPrice()}','{product.GetType()}','{product.GetDescription()}','{product.GetImage()}','{product.GetCreate_date()}','{Seller.activeSeller}','{product.GetScore()}')";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Product Successfuly Added!  " + Seller.activeSeller, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }
        public static DataSet db_GetAllProducts_of_Seller() //for data grid view
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"SELECT Product.name,Product.price,Product.type,Product.description,Product.create_date,Product.score,Seller.name [SellerName],Seller.id [SellerId],Product.id [ProductId],Product.image From Seller INNER JOIN Product ON Seller.id = Product.owner WHERE Seller.id = {Seller.activeSeller}";
                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql_string, sqlitedb_connstr);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Product");
                        return dataSet;
                }
                
            }
        }

        public static Product get_product_from_id(int product_id)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"SELECT * FROM Product WHERE id = {product_id} "; //default
               
                 Seller seller = new Seller();
                Product product = new Product();
                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {

                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                product.SetId(Convert.ToInt32(dataReader["id"]));
                                product.SetName(dataReader["name"].ToString());
                                product.SetPrice(Convert.ToDouble(dataReader["price"]));
                                product.SetType(dataReader["type"].ToString());
                                product.SetDescription(dataReader["description"].ToString());
                                product.SetImage(dataReader["image"].ToString());
                                product.SetCreate_date(Convert.ToDateTime(dataReader["create_date"]));
                                product.SetScore(Convert.ToInt16(dataReader["score"]));

                                seller.SetId(Convert.ToInt32(dataReader["owner"]));
                                product.SetOwner(DbSeller.get_seller_data_from_id(seller.GetId())); //Product.owner nesne tutuyor fakat Veri tabanından int id şeklinde aldıgımız için çektiğimiz id nin nesnesini alıyoruz

                            }
                        }
                        return product;
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    return product;
                }
            }
        }

        //public static List<Product> db_fill_FoodList()
        //{
        //    using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
        //    {
        //        string sql_string = $"SELECT * FROM Product WHERE type = 'Main Menu' "; //default

        //        MessageBox.Show(sql_string);

        //        Product product = new Product();
        //        Seller seller = new Seller();
        //        List<Product> food_list = new List<Product>();
        //        using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
        //        {
        //            try
        //            {

        //                command_sqlite.Connection.Open();
        //                SQLiteDataReader dataReader = command_sqlite.ExecuteReader();
        //                while (dataReader.Read())
        //                {
        //                    product.SetId(Convert.ToInt32(dataReader["id"]));
        //                    product.SetName(dataReader["name"].ToString());
        //                    product.SetPrice(Convert.ToDouble(dataReader["price"]));
        //                    product.SetType(dataReader["type"].ToString());
        //                    product.SetDescription(dataReader["description"].ToString());
        //                    product.SetImage(dataReader["image"].ToString());
        //                    product.SetCreate_date(Convert.ToDateTime(dataReader["create_date"]));
        //                    product.SetScore(Convert.ToInt16(dataReader["score"]));

        //                    seller.SetId(Convert.ToInt32(dataReader["owner"]));
        //                    product.SetOwner(DbSeller.get_seller_data_from_id(seller.GetId())); //Product.owner nesne tutuyor fakat Veri tabanından int id şeklinde aldıgımız için çektiğimiz id nin nesnesini alıyoruz

        //                    food_list.Add(product);
        //                    //stack.Push(product); //Database'den çektiğimiz ürünü ana ekranda gösterebilmek için stacke ya ekledik
        //                }
        //            }
        //            catch (SQLiteException exception)
        //            {
        //                MessageBox.Show(exception.Message);
        //            }
        //            return food_list;
        //        }
        //    }
        //}
        //public static List<Product> db_fill_FoodList_drinks()
        //{
        //    using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
        //    {
        //        string sql_string = $"SELECT * FROM Product WHERE type = 'Drinks' ";

        //        MessageBox.Show(sql_string);

        //        Product product = new Product();
        //        Seller seller = new Seller();
        //        List<Product> food_list = new List<Product>();
        //        using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
        //        {
        //            try
        //            {

        //                command_sqlite.Connection.Open();
        //                SQLiteDataReader dataReader = command_sqlite.ExecuteReader();
        //                while (dataReader.Read())
        //                {
        //                    product.SetId(Convert.ToInt32(dataReader["id"]));
        //                    product.SetName(dataReader["name"].ToString());
        //                    product.SetPrice(Convert.ToDouble(dataReader["price"]));
        //                    product.SetType(dataReader["type"].ToString());
        //                    product.SetDescription(dataReader["description"].ToString());
        //                    product.SetImage(dataReader["image"].ToString());
        //                    product.SetCreate_date(Convert.ToDateTime(dataReader["create_date"]));
        //                    product.SetScore(Convert.ToInt16(dataReader["score"]));

        //                    seller.SetId(Convert.ToInt32(dataReader["owner"]));
        //                    product.SetOwner(DbSeller.get_seller_data_from_id(seller.GetId())); //Product.owner nesne tutuyor fakat Veri tabanından int id şeklinde aldıgımız için çektiğimiz id nin nesnesini alıyoruz

        //                    food_list.Add(product);
        //                    //stack.Push(product); //Database'den çektiğimiz ürünü ana ekranda gösterebilmek için stacke ya ekledik
        //                }
        //            }
        //            catch (SQLiteException exception)
        //            {
        //                MessageBox.Show(exception.Message);
        //            }
        //            return food_list;
        //        }
        //    }
        //}
        //public static List<Product> db_fill_FoodList_desserts()
        //{
        //    using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
        //    {
        //        string sql_string = $"SELECT * FROM Product WHERE type = 'Desserts' ";

        //        MessageBox.Show(sql_string);

        //        Product product = new Product();
        //        Seller seller = new Seller();
        //        List<Product> food_list = new List<Product>();
        //        using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
        //        {
        //            try
        //            {

        //                command_sqlite.Connection.Open();
        //                SQLiteDataReader dataReader = command_sqlite.ExecuteReader();
        //                while (dataReader.Read())
        //                {
        //                    product.SetId(Convert.ToInt32(dataReader["id"]));
        //                    product.SetName(dataReader["name"].ToString());
        //                    product.SetPrice(Convert.ToDouble(dataReader["price"]));
        //                    product.SetType(dataReader["type"].ToString());
        //                    product.SetDescription(dataReader["description"].ToString());
        //                    product.SetImage(dataReader["image"].ToString());
        //                    product.SetCreate_date(Convert.ToDateTime(dataReader["create_date"]));
        //                    product.SetScore(Convert.ToInt16(dataReader["score"]));

        //                    seller.SetId(Convert.ToInt32(dataReader["owner"]));
        //                    product.SetOwner(DbSeller.get_seller_data_from_id(seller.GetId())); //Product.owner nesne tutuyor fakat Veri tabanından int id şeklinde aldıgımız için çektiğimiz id nin nesnesini alıyoruz

        //                    food_list.Add(product);
        //                    //stack.Push(product); //Database'den çektiğimiz ürünü ana ekranda gösterebilmek için stacke ya ekledik
        //                }
        //            }
        //            catch (SQLiteException exception)
        //            {
        //                MessageBox.Show(exception.Message);
        //            }
        //            return food_list;
        //        }
        //    }
        //}

        public static Stack<Product> db_fill_FoodList(string type)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"SELECT * FROM Product WHERE type = 'Main Menu' "; //default
                if(type.Equals("Main Menu"))
                {
                    sql_string = $"SELECT * FROM Product WHERE type = 'Main Menu' ";
                }
                if(type.Equals("Drinks"))
                {
                    sql_string = $"SELECT * FROM Product WHERE type = 'Drinks' ";
                }
                if(type.Equals("Desserts"))
                {
                    sql_string = $"SELECT * FROM Product WHERE type = 'Desserts' ";
                }

                Seller seller = new Seller();
                Stack<Product> food_list = new Stack<Product>();
                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {

                        command_sqlite.Connection.Open();
                        using(SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        { 
                        while (dataReader.Read())
                        {
                            Product product = new Product();
                            product.SetId(Convert.ToInt32(dataReader["id"]));
                            product.SetName(dataReader["name"].ToString());
                            product.SetPrice(Convert.ToDouble(dataReader["price"]));
                            product.SetType(dataReader["type"].ToString());
                            product.SetDescription(dataReader["description"].ToString());
                            product.SetImage(dataReader["image"].ToString());
                            product.SetCreate_date(Convert.ToDateTime(dataReader["create_date"]));
                            product.SetScore(Convert.ToInt16(dataReader["score"]));

                            seller.SetId(Convert.ToInt32(dataReader["owner"]));
                            product.SetOwner(DbSeller.get_seller_data_from_id(seller.GetId())); //Product.owner nesne tutuyor fakat Veri tabanından int id şeklinde aldıgımız için çektiğimiz id nin nesnesini alıyoruz

                            food_list.Push(product);
                            //stack.Push(product); //Database'den çektiğimiz ürünü ana ekranda gösterebilmek için stacke ya ekledik
                        }
                        }
                        return food_list;
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    return food_list;
                }
            }
        }
        public static void UpdateSelectedProduct(Product product)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"UPDATE Product SET name = '{product.GetName()}', price = '{product.GetPrice()}', type = '{product.GetType()}', description = '{product.GetDescription()}', image = '{product.GetImage()}' WHERE id = '{product.GetId()}' ";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }
        public static void DeleteSelectedProduct(Product product)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"DELETE FROM Product WHERE id = '{product.GetId()}' ";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Deleted successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }
    }
}
