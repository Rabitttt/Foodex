using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodEx.DatabaseConfig;

namespace FoodEx
{
    public partial class Foods : UserControl
    {
        public Foods()
        {
            InitializeComponent();
        }

        List<Product> food_list = new List<Product>(); 
        private int index_of_foodlist = 1;

        public void first_open()
        {
            food_list.Clear();
            food_list = DbProduct.db_fill_FoodList("Main Menu");
            fill_products();

            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.DarkOrange;
            panel_desserts.BackColor = Color.White;
            
            

            if(Seller.activeSeller != 0)
            {
                btn_product0_buy.Enabled = false;
                btn_product1_buy.Enabled = false;
                btn_product2_buy.Enabled = false;
            }
            else
            {
                btn_product0_buy.Enabled = true;
                btn_product1_buy.Enabled = true;
                btn_product2_buy.Enabled = true;
            }
        }

        private void pictureBox_drinks_Click(object sender, EventArgs e)
        {
            panel_drinks.BackColor = Color.DarkOrange;
            panel_mainfoods.BackColor = Color.White;
            panel_desserts.BackColor = Color.White;
            food_list = DbProduct.db_fill_FoodList("Drinks");
            index_of_foodlist = 1;
            fill_products();
        }

        private void pictureBox_mainfood_Click(object sender, EventArgs e)
        {
            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.DarkOrange;
            panel_desserts.BackColor = Color.White;
            food_list = DbProduct.db_fill_FoodList("Main Menu");
            index_of_foodlist = 1;
            fill_products();
        }

        private void pictureBox_desserts_Click(object sender, EventArgs e)
        {
            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.White;
            panel_desserts.BackColor = Color.DarkOrange;
            food_list = DbProduct.db_fill_FoodList("Desserts");
            index_of_foodlist = 1;
            fill_products();
        }

        private void fill_products()
        {
            Product product = new Product();
            try
            {
                panel0.Visible = true;
                product = food_list[index_of_foodlist -1];
                lbl_product0_id.Text = product.GetId().ToString();
                lbl_product0_name.Text = product.GetName();
                picturbox_product0.ImageLocation = product.GetImage();
                lbl_product0_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product0_score.Text = product.GetScore().ToString();
                lbl_product0_price.Text = product.GetPrice().ToString();
            }
            catch (Exception) //eger listelenecek birşey yoksa panel gözükmesin
            {
                panel0.Visible = false;
            }
            try
            {
                panel1.Visible = true;
                product = food_list[index_of_foodlist];
                lbl_product1_id.Text = product.GetId().ToString();
                lbl_product1_name.Text = product.GetName();
                picturbox_product1.ImageLocation = product.GetImage();
                lbl_product1_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product1_score.Text = product.GetScore().ToString();
                lbl_product1_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            {
                panel1.Visible = false;
            }
            try
            {
                panel2.Visible = true;
                product = food_list[index_of_foodlist + 1];
                lbl_product2_id.Text = product.GetId().ToString();
                lbl_product2_name.Text = product.GetName();
                picturbox_product2.ImageLocation = product.GetImage();
                lbl_product2_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product2_score.Text = product.GetScore().ToString();
                lbl_product2_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            {
                panel2.Visible = false;
            }
        }
        
        private void btn_slideRight_Click(object sender, EventArgs e)
        {
            if (food_list.Count > index_of_foodlist + 2)
            {
                index_of_foodlist = index_of_foodlist + 3;
                fill_products();
            }
        }

        private void btn_slideLeft_Click(object sender, EventArgs e)
        {   
            if (index_of_foodlist > 1)
            {
                index_of_foodlist = index_of_foodlist - 3;
                fill_products();
            }
        }
        

        private void btn_product0_detail_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(lbl_product0_id.Text))
            {
                ProductDetail productDetailPage = new ProductDetail(Convert.ToInt32(lbl_product0_id.Text));
                productDetailPage.ShowDialog();
            }
        }

        private void btn_product1_detail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_product1_id.Text))
            {
                ProductDetail productDetailPage = new ProductDetail(Convert.ToInt32(lbl_product1_id.Text));
                productDetailPage.ShowDialog();
            }
        }

        private void btn_product2_detail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_product2_id.Text))
            {
                ProductDetail productDetailPage = new ProductDetail(Convert.ToInt32(lbl_product2_id.Text));
                productDetailPage.ShowDialog();
            }
        }

        public void buy_product(int product_number)
        {

            DialogResult dialog = MessageBox.Show($"Buy product.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Customer customer = new Customer();
                customer = DbCustomer.get_customer_from_id(Customer.activeCustomer);
                double userMoney = customer.GetMoney();
                double product_price;

                if (product_number == 0) //kaçıncı butona(0,1,2) basıldı kontrolu 
                {
                    product_price = Convert.ToInt32(lbl_product0_price.Text);
                }
                else if (product_number == 1)
                {
                    product_price = Convert.ToInt32(lbl_product1_price.Text);
                }
                else if (product_number == 2)
                {
                    product_price = Convert.ToInt32(lbl_product2_price.Text);
                }
                else
                {
                    return;
                }


                if (userMoney >= product_price)
                {
                    userMoney = userMoney - product_price;
                    customer.SetMoney(userMoney);
                    DbCustomer.UpdateCustomer(customer);
                }
            }
        }


        private void btn_product0_buy_Click(object sender, EventArgs e)
        {
            buy_product(0);
        }

        private void btn_product1_buy_Click(object sender, EventArgs e)
        {
            buy_product(1);
        }

        private void btn_product2_buy_Click(object sender, EventArgs e)
        {
            buy_product(2);
        }
    }
}
