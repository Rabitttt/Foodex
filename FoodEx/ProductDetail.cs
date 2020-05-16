using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodEx.DatabaseConfig;

namespace FoodEx
{
    public partial class ProductDetail : Form
    {
        Product product = new Product();
        public ProductDetail(int product_id)
        {
            InitializeComponent();
            product = DbProduct.get_product_from_id(product_id);
            fill_product_details();
            if(Seller.activeSeller != 0) //satıcı hesabi ise satın al butonlarını göremesini engelliyoruz
            {
                btn_buy.Enabled = false;
                btn_GivePoint.Enabled = false;
            }
            fill_comments();
        }

        List<Comment> comments_list = new List<Comment>();
        private int list_index = 1;

        private void fill_product_details()
        {
            lbl_id.Text = product.GetId().ToString();
            lbl_name.Text = product.GetName();
            lbl_type.Text = product.GetType();
            lbl_createDate.Text = product.GetCreate_date().ToString();
            lbl_price.Text = product.GetPrice().ToString();
            lbl_score.Text = product.GetScore().ToString();
            pictureBox_product.ImageLocation= product.GetImage();
            lbl_description.Text = product.GetDescription();
        }

        private void fill_comments()
        {
            comments_list = DbComment.comments_of_product(product.GetId());

            lbl_comment0_username.ForeColor = Color.Black;
            lbl_comment1_username.ForeColor = Color.Black;

            try
            {
                //1. yorum paneli
                if (comments_list[list_index - 1].GetSeller().GetId() != 0) //satıcı yorumu ise satıcının adını renkli bastırıcak
                {
                    lbl_comment0_username.Text = comments_list[list_index - 1].GetSeller().GetName();
                    lbl_comment0_username.ForeColor = Color.Salmon;
                    lbl_comment0_text.Text = comments_list[list_index - 1].GetText();
                }
                if (comments_list[list_index - 1].GetCustomer().GetId() != 0)
                {
                    lbl_comment0_username.Text = comments_list[list_index - 1].GetCustomer().GetName();
                    lbl_comment0_username.ForeColor = Color.Black;
                    lbl_comment0_text.Text = comments_list[list_index - 1].GetText();
                }
            }
            catch (Exception)
            {
                lbl_comment0_username.Text = "";
                lbl_comment0_text.Text = "";
            }
            try
            {
                //2. yorum paneli
                if (comments_list[list_index].GetSeller().GetId() != 0)
                {
                    lbl_comment1_username.Text = comments_list[list_index].GetSeller().GetName();
                    lbl_comment1_username.ForeColor = Color.Salmon;
                    lbl_comment1_text.Text = comments_list[list_index].GetText();
                }
                if (comments_list[list_index].GetCustomer().GetId() != 0)
                {
                    lbl_comment1_username.Text = comments_list[list_index].GetCustomer().GetName();
                    lbl_comment1_username.ForeColor = Color.Black;
                    lbl_comment1_text.Text = comments_list[list_index].GetText();
                }
            }
            catch (Exception)
            {
                lbl_comment1_username.Text = "";
                lbl_comment1_text.Text = "";
            }   

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void btn_addComment_Click(object sender, EventArgs e)
        {
            Comment comment = new Comment();
            comment.SetText(richTxtb_commentText.Text);
            comment.SetCreateTime(DateTime.Now);
            comment.SetProduct(this.product);
            comment.SetCustomer(DbCustomer.get_customer_from_id(Customer.activeCustomer));
            comment.SetSeller(DbSeller.get_seller_data_from_id(Seller.activeSeller));

            DbComment.add_comment(comment);
        }

        private void btn_slideComments_left_Click(object sender, EventArgs e)
        {
            if(list_index > 1) // listenin başına gelindiğinde dursun , index -1 e vs. inmesin
            {
                list_index -= 2;
                fill_comments();
            }
        }

        private void btn_slideComments_right_Click(object sender, EventArgs e)
        {
            if(comments_list.Count > list_index + 1) // gidilebilecek liste elemanı varsa
            {
                list_index += 2;
                fill_comments();
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Buy product.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Customer customer = new Customer();
                customer = DbCustomer.get_customer_from_id(Customer.activeCustomer);
                double userMoney = customer.GetMoney();
                double product_price;

                product_price = Convert.ToInt32(lbl_price.Text);

                if (userMoney >= product_price)
                {
                    userMoney = userMoney - product_price;
                    customer.SetMoney(userMoney);
                    DbCustomer.UpdateCustomer(customer);
                }
            }
        }

        private void btn_GivePoint_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = DbProduct.get_product_from_id(Convert.ToInt32(lbl_id.Text));
            int score;

            if(!string.IsNullOrEmpty(lbl_id.Text))
            {
                score = Convert.ToInt32(numericUpDown_score.Value);
                product.SetScore( DbProduct.get_product_from_id(Convert.ToInt32(lbl_id.Text)).GetScore() + score );


                DbProduct.UpdateProductScore(product);
            }
            else
            {
                MessageBox.Show("Score is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
