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

        Stack<Product> food_list_left = new Stack<Product>();
        Stack<Product> food_list_right = new Stack<Product>();

        public void first_open()
        {
            food_list_right = DbProduct.db_fill_FoodList("Main Menu");

            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.DarkOrange;
            panel_desserts.BackColor = Color.White;
            
            fill_product_slide_left();

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
            clear_panels();
            food_list_right.Clear();
            food_list_left.Clear();
            food_list_right = DbProduct.db_fill_FoodList("Drinks");
            fill_product_slide_left();
        }

        private void pictureBox_mainfood_Click(object sender, EventArgs e)
        {
            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.DarkOrange;
            panel_desserts.BackColor = Color.White;
            clear_panels();
            food_list_right.Clear();
            food_list_left.Clear();
            food_list_right = DbProduct.db_fill_FoodList("Main Menu");
            fill_product_slide_left();
        }

        private void pictureBox_desserts_Click(object sender, EventArgs e)
        {
            panel_drinks.BackColor = Color.White;
            panel_mainfoods.BackColor = Color.White;
            panel_desserts.BackColor = Color.DarkOrange;
            clear_panels();
            food_list_right.Clear();
            food_list_left.Clear();
            food_list_right = DbProduct.db_fill_FoodList("Desserts");
            fill_product_slide_left();
        }

        private void fill_product_slide_left()
        {
            Product product = new Product();
            try
            {
                product = (food_list_right.Pop());
                food_list_left.Push(product);
                lbl_product0_id.Text = product.GetId().ToString();
                lbl_product0_name.Text = product.GetName();
                picturbox_product0.ImageLocation = product.GetImage();
                lbl_product0_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product0_score.Text = product.GetScore().ToString();
                lbl_product0_price.Text = product.GetPrice().ToString();
            }
            catch (Exception) //try catch liste bittiğinde dönen empty değerını catch ile yakalayıp yeni ürün listelememek için kullanılmıştır.
            { }
            try
            {
                product = (food_list_right.Pop());
                food_list_left.Push(product);
                lbl_product1_id.Text = product.GetId().ToString();
                lbl_product1_name.Text = product.GetName();
                picturbox_product1.ImageLocation = product.GetImage();
                lbl_product1_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product1_score.Text = product.GetScore().ToString();
                lbl_product1_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            { }
            try
            {
                product = (food_list_right.Pop());
                food_list_left.Push(product);
                lbl_product2_id.Text = product.GetId().ToString();
                lbl_product2_name.Text = product.GetName();
                picturbox_product2.ImageLocation = product.GetImage();
                lbl_product2_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product2_score.Text = product.GetScore().ToString();
                lbl_product2_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            { }
        }
        private void fill_product_slide_right()
        {
            Product product = new Product();
            try
            {
                product = (food_list_left.Pop());
                food_list_right.Push(product);
                lbl_product0_id.Text = product.GetId().ToString();
                lbl_product0_id.Text = product.GetId().ToString();
                lbl_product0_name.Text = product.GetName();
                picturbox_product0.ImageLocation = product.GetImage();
                lbl_product0_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product0_score.Text = product.GetScore().ToString();
                lbl_product0_price.Text = product.GetPrice().ToString();
            }
            catch (Exception) //try catch liste bittiğinde dönen empty değerını catch ile yakalayıp yeni ürün listelememek için kullanılmıştır.
            { }
            try
            {
                product = (food_list_left.Pop());
                food_list_right.Push(product);
                lbl_product1_id.Text = product.GetId().ToString();
                lbl_product1_name.Text = product.GetName();
                picturbox_product1.ImageLocation = product.GetImage();
                lbl_product1_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product1_score.Text = product.GetScore().ToString();
                lbl_product1_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            { }
            try
            {
                product = (food_list_left.Pop());
                food_list_right.Push(product);
                lbl_product2_id.Text = product.GetId().ToString();
                lbl_product2_name.Text = product.GetName();
                picturbox_product2.ImageLocation = product.GetImage();
                lbl_product2_sellername.Text = DbSeller.get_seller_data_from_id(product.GetOwner().GetId()).GetName();
                lbl_product2_score.Text = product.GetScore().ToString();
                lbl_product2_price.Text = product.GetPrice().ToString();
            }
            catch (Exception)
            { }
        }

        private void btn_slideRight_Click(object sender, EventArgs e)
        {
            fill_product_slide_right();
        }

        private void btn_slideLeft_Click(object sender, EventArgs e)
        {
            fill_product_slide_left();
        }
        
        private void clear_panels()
        {
            lbl_product0_id.Text = "";
            lbl_product0_name.Text = "";
            lbl_product0_price.Text = "";
            lbl_product0_score.Text = "";
            lbl_product0_sellername.Text = "";
            picturbox_product0.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
            
            lbl_product1_id.Text = "";
            lbl_product1_name.Text = "";
            lbl_product1_price.Text = "";
            lbl_product1_score.Text = "";
            lbl_product1_sellername.Text = "";
            picturbox_product1.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
            
            lbl_product2_id.Text = "";
            lbl_product2_name.Text = "";
            lbl_product2_price.Text = "";
            lbl_product2_score.Text = "";
            lbl_product2_sellername.Text = "";
            picturbox_product2.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";

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
