using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.ComponentModel;
using System.Drawing;

namespace FoodEx.DatabaseConfig
{
    class DbSeller
    {
        private static string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public static void db_AddNewSeller(Seller seller)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"INSERT INTO Seller(name,password,telephone_number,company_name,address,join_date,image) VALUES('{seller.GetName()}','{seller.GetPassword()}','{seller.GetTelephone_number()}','{seller.GetCompany_name()}','{seller.GetAdress()}','{seller.GetJoin_date()}','{seller.GetImage()}')";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        Seller.activeSeller = command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Wellcome!  " + Seller.activeSeller, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (SQLiteException exception)
                    {
                        if (exception.ErrorCode == (int)SQLiteErrorCode.Constraint) //username is not unique
                        {
                            MessageBox.Show("Username is Already Taken!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }

        public static void assign_ActiveUSer(Seller seller)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring_LastInsertRowId = $"SELECT max(id) FROM Seller";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring_LastInsertRowId, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        Seller.activeSeller = Convert.ToInt32(command_sqlite.ExecuteScalar());
                        MessageBox.Show("" + Seller.activeSeller);
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        public static void is_account_exist(Seller seller)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring = $"SELECT id FROM Seller WHERE name = '{seller.GetName()}' AND password = '{seller.GetPassword()}'";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        if (command_sqlite.ExecuteScalar() == null)
                        {
                            MessageBox.Show("Didn't find result match with username and password.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            Seller.activeSeller = Convert.ToInt32(command_sqlite.ExecuteScalar());
                        }
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }
        public static Seller get_active_user_data()
        {
            Seller seller = new Seller();

            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring = $"SELECT * FROM Seller WHERE id = '{Seller.activeSeller}'";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                seller.SetId(Seller.activeSeller);
                                seller.SetName(dataReader["name"].ToString());
                                seller.SetPassword(dataReader["password"].ToString());
                                seller.SetTelephone_number(dataReader["telephone_number"].ToString());
                                seller.SetCompany_name(dataReader["company_name"].ToString());
                                seller.SetAddress(dataReader["address"].ToString());
                                seller.SetJoin_date(Convert.ToDateTime(dataReader["join_date"]));
                                seller.SetImage(dataReader["image"].ToString());
                            }
                        }
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            return seller;
        }
        public static Seller get_seller_data_from_id(int sellerId)
        {
            Seller seller = new Seller();

            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring = $"SELECT * FROM Seller WHERE id = '{sellerId}'";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        using (SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                seller.SetId(Convert.ToInt32(dataReader["id"]));
                                seller.SetName(dataReader["name"].ToString());
                                seller.SetPassword(dataReader["password"].ToString());
                                seller.SetTelephone_number(dataReader["telephone_number"].ToString());
                                seller.SetCompany_name(dataReader["company_name"].ToString());
                                seller.SetAddress(dataReader["address"].ToString());
                                seller.SetJoin_date(Convert.ToDateTime(dataReader["join_date"]));
                                seller.SetImage(dataReader["image"].ToString());
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            return seller;
        }

        public static void UpdateSeller(Seller seller)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"UPDATE Seller SET name = '{seller.GetName()}', password = '{seller.GetPassword()}', telephone_number = '{seller.GetTelephone_number()}', company_name = '{seller.GetCompany_name()}', address = '{seller.GetAdress()}', image = '{seller.GetImage()}' WHERE id = '{Seller.activeSeller}' ";

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

        public static void DeleteProfile()
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"DELETE FROM Seller WHERE id = '{Seller.activeSeller}' ";

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
