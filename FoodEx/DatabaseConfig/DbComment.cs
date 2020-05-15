using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FoodEx.DatabaseConfig
{
    class DbComment
    {
        private static string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public static void add_comment(Comment comment)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"INSERT INTO Comment(text,customerComment,sellerComment,create_date,product) VALUES('{comment.GetText()}','{comment.GetCustomer().GetId()}','{comment.GetSeller().GetId()}','{comment.GetCreateTime()}','{comment.GetProduct().GetId()}')";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Comment Added! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        public static List<Comment> select_all_comments() //tüm yorumları list şeklinde return ediyoruz
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {

                string sql_string = $"SELECT * FROM Comment"; //tüm yorumları getir

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    List<Comment> allComments = new List<Comment>();
                    Comment comment = new Comment();

                    try
                    {
                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            while(dataReader.Read())
                            {
                                comment.SetId(Convert.ToInt32(dataReader["id"]));                                
                                comment.SetText(dataReader["text"].ToString());                                
                                comment.SetCustomer(DbCustomer.get_customer_from_id(Convert.ToInt32(dataReader["customerComment"])));
                                comment.SetSeller(DbSeller.get_seller_data_from_id(Convert.ToInt32(dataReader["sellerComment"])));
                                comment.SetProduct(DbProduct.get_product_from_id(Convert.ToInt32(dataReader["product"])));

                                allComments.Add(comment); //listeye eklendi
                            }
                        }
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                    return allComments;
                }
            }
        }

        public static List<Comment> comments_of_product(int selected_product_id) //bir ürünün yorumlarını list şeklinde return ediyoruz
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {

                string sql_string = $"SELECT * FROM Comment WHERE product = '{selected_product_id}'"; //seçili ürünün yorumları

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    List<Comment> allComments = new List<Comment>();

                    try
                    {
                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Comment comment = new Comment();
                                comment.SetId(Convert.ToInt32(dataReader["id"]));
                                comment.SetText(dataReader["text"].ToString());
                                comment.SetCreateTime(Convert.ToDateTime(dataReader["create_date"]));
                                comment.SetCustomer(DbCustomer.get_customer_from_id(Convert.ToInt32(dataReader["customerComment"])));
                                comment.SetSeller(DbSeller.get_seller_data_from_id(Convert.ToInt32(dataReader["sellerComment"])));
                                comment.SetProduct(DbProduct.get_product_from_id(Convert.ToInt32(dataReader["product"])));

                                allComments.Add(comment); //listeye eklendi
                            }
                        }
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                    return allComments;
                }
            }
        }

        public static List<Comment> get_comments_of_active_user() //kullanıcının yaptığı yorumlar
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = ""; //default (hata olması durumu) if lere girip değişicek.
                if (Customer.activeCustomer != 0)
                {
                    sql_string = $"SELECT * FROM Comment WHERE customerComment = '{Customer.activeCustomer}' ";
                }
                if (Seller.activeSeller != 0)
                {
                    sql_string = $"SELECT * FROM Comment WHERE sellerComment = '{Seller.activeSeller}' ";
                }

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    List<Comment> allComments = new List<Comment>();

                    try
                    {
                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                Comment comment = new Comment();
                                comment.SetId(Convert.ToInt32(dataReader["id"]));
                                comment.SetText(dataReader["text"].ToString());
                                comment.SetCreateTime(Convert.ToDateTime(dataReader["create_date"]));
                                comment.SetCustomer(DbCustomer.get_customer_from_id(Convert.ToInt32(dataReader["customerComment"])));
                                comment.SetSeller(DbSeller.get_seller_data_from_id(Convert.ToInt32(dataReader["sellerComment"])));
                                comment.SetProduct(DbProduct.get_product_from_id(Convert.ToInt32(dataReader["product"])));

                                allComments.Add(comment); //listeye eklendi
                            }
                        }
                    }
                    catch (SQLiteException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                    return allComments;
                }
            }
        }
    }
}
