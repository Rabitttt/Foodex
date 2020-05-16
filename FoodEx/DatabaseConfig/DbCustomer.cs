using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace FoodEx.DatabaseConfig
{
    class DbCustomer
    {
        private static string sqlitedb_connstr = @"Data Source =" + Application.StartupPath + "\\database.db; version=3;";

        public static void db_AddNewCustomer(Customer customer)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"INSERT INTO Customer(name,password,telephone_number,birth_date,money,image) VALUES('{customer.GetName()}','{customer.GetPassword()}','{customer.GetTelephone_number()}','{customer.GetBirth_date()}','{100}','{customer.GetImage()}')";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                        MessageBox.Show("Wellcome!" + Customer.activeCustomer, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public static void assign_ActiveUSer(Customer customer)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring_LastInsertRowId = $"SELECT max(id) FROM Customer";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring_LastInsertRowId, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        Customer.activeCustomer = Convert.ToInt32(command_sqlite.ExecuteScalar());
                        MessageBox.Show("" + Customer.activeCustomer);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }
        public static bool is_account_exist(Customer customer)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring_loginuser = $"SELECT id FROM Customer WHERE name = '{customer.GetName()}' AND password = '{customer.GetPassword()}'";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring_loginuser, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        if (command_sqlite.ExecuteScalar() == null)
                        {
                            MessageBox.Show("Didn't find result match with username and password.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            Customer.activeCustomer = Convert.ToInt32(command_sqlite.ExecuteScalar());
                            return true;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    return false;
                }
            }
        }
        public static Customer get_customer_from_id(int customer_id)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sqlstring_loginuser = $"SELECT * FROM Customer WHERE id = {customer_id}";
                Customer customer = new Customer();

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sqlstring_loginuser, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        using(SQLiteDataReader dataReader = command_sqlite.ExecuteReader())
                        {
                        if (dataReader.Read())
                        {
                            customer.SetId(Convert.ToInt32(dataReader["id"]));
                            customer.SetName(dataReader["name"].ToString());
                            customer.SetPassword(dataReader["password"].ToString());
                            customer.SetTelephone_number(dataReader["telephone_number"].ToString());
                            customer.SetBirth_date(Convert.ToDateTime(dataReader["birth_date"]));
                            customer.SetMoney(Convert.ToDouble(dataReader["money"]));
                            customer.SetImage(dataReader["image"].ToString());
                        }

                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    return customer;
                }
            }
        }
        public static void UpdateCustomer(Customer customer)
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"UPDATE Customer SET name = '{customer.GetName()}', password = '{customer.GetPassword()}', telephone_number = '{customer.GetTelephone_number()}', birth_date = '{customer.GetBirth_date()}', money = '{customer.GetMoney()}', image = '{customer.GetImage()}' WHERE id = '{Customer.activeCustomer}' ";

                using (SQLiteCommand command_sqlite = new SQLiteCommand(sql_string, connection_sqlite))
                {
                    try
                    {
                        command_sqlite.Connection.Open();
                        command_sqlite.ExecuteNonQuery();
                    }
                    catch (SQLiteException exception)
                    {
                        if (exception.ErrorCode == (int)SQLiteErrorCode.Constraint) //username is not unique
                        {
                            MessageBox.Show("Username is Already Taken!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }
        public static void DeleteProfile()
        {
            using (SQLiteConnection connection_sqlite = new SQLiteConnection(sqlitedb_connstr))
            {
                string sql_string = $"DELETE FROM Customer WHERE id = '{Customer.activeCustomer}' ";

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
