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
    public partial class SellerSelfProfilePage : UserControl
    {
        public SellerSelfProfilePage()
        {
            InitializeComponent();
        }

        List<Comment> comments_list = new List<Comment>();
        private int comment_list_index = 1;

        public void first_open()
        {
            Seller seller = new Seller();
            Product product = new Product();
            seller = DbSeller.get_active_user_data();
            fill_user_data(seller);
            fill_dataGridView_by_productsOfSeller();
        }
        private void fill_user_data(Seller seller)
        {
            txtb_username.Text = seller.GetName();
            txtb_companyname.Text = seller.GetCompany_name();
            maskedTxtb_telephone.Text = seller.GetTelephone_number();
            richTxtb_address.Text = seller.GetAdress();
            lbl_joindate.Text = seller.GetJoin_date().ToString();
            pictureBox_seller.ImageLocation = seller.GetImage();
        }

        
        private void fill_dataGridView_by_productsOfSeller()
        {
            DataSet dataSet = DbProduct.db_GetAllProducts_of_Seller();
            dataGridView_productsOfSeller.DataSource = dataSet.Tables[0];
        }
        private void fill_product_detail()
        {
            
                txtb_product_name.Text = dataGridView_productsOfSeller.CurrentRow.Cells["name"].Value.ToString();
                txtb_product_price.Text = dataGridView_productsOfSeller.CurrentRow.Cells["price"].Value.ToString();
                cmbbox_product_type.Text = dataGridView_productsOfSeller.CurrentRow.Cells["type"].Value.ToString();
                richTxtb_description.Text = dataGridView_productsOfSeller.CurrentRow.Cells["description"].Value.ToString();
                lbl_product_createDate.Text = dataGridView_productsOfSeller.CurrentRow.Cells["create_date"].Value.ToString();
                lbl_product_score.Text = dataGridView_productsOfSeller.CurrentRow.Cells["score"].Value.ToString();
                pictureBox_product.ImageLocation = dataGridView_productsOfSeller.CurrentRow.Cells["image"].Value.ToString();
            
        }

        private void dataGridView_productsOfSeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fill_product_detail();
            fill_comments();
        }

        private void btn_seller_AddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct newProductPage = new AddProduct();
            newProductPage.ShowDialog();
            fill_dataGridView_by_productsOfSeller();
        }

        private void btn_seller_update_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.SetId(Seller.activeSeller);
            seller.SetName(txtb_username.Text);
            seller.SetPassword(DbSeller.get_seller_data_from_id(Seller.activeSeller).GetPassword()); //bu aşamada parola güncellensin istemiyoruz eski parolayı tekrar yazdırıyorum.
            seller.SetTelephone_number(maskedTxtb_telephone.Text);
            seller.SetCompany_name(txtb_companyname.Text);
            seller.SetAddress(richTxtb_address.Text);
            seller.SetImage(pictureBox_seller.ImageLocation);

            DialogResult dialog = MessageBox.Show("Update changed fields.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(seller.GetName()) || string.IsNullOrEmpty(seller.GetPassword()))
                {
                    MessageBox.Show("Username field is required. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DbSeller.UpdateSeller(seller);
                }

            }
        }

        private void pictureBox_user_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_seller.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_seller_deleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete this account.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DbSeller.DeleteProfile();
                Seller.activeSeller = 0;
                Application.Restart(); //Hesap silindi , giriş sayfasına dön
            }

        }

        private void btn_product_Update_Click(object sender, EventArgs e)
        {
            
            try
            {

            Product product = new Product();
            product.SetId( Convert.ToInt32(dataGridView_productsOfSeller.CurrentRow.Cells["ProductId"].Value));
            product.SetName(txtb_product_name.Text);
            product.SetPrice(Convert.ToInt32(txtb_product_price.Text));
            product.SetType(cmbbox_product_type.Text);
            product.SetDescription(richTxtb_description.Text);
            product.SetImage(pictureBox_product.ImageLocation);

            DialogResult dialog = MessageBox.Show("Update changed fields.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DbProduct.UpdateSelectedProduct(product);
            }
            fill_dataGridView_by_productsOfSeller();
            fill_product_detail();

            }
            catch (Exception)// bir şekilde boş dgv ye tıklarsa sorun çıkarmasın
            {
            }
        }

        private void btn_product_DeleteProduct_Click(object sender, EventArgs e)
        {
          

            try
            {

            Product product = new Product();
            product.SetId(Convert.ToInt32(dataGridView_productsOfSeller.CurrentRow.Cells["ProductId"].Value));
            
            DialogResult dialog = MessageBox.Show("Delete Selected Product.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DbProduct.DeleteSelectedProduct(product);
            }
            fill_dataGridView_by_productsOfSeller();
            fill_product_detail();
            comment_list_index = 1; //index sıfırlanmış oldu
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fill_comments()
        {
            try
            {

            
            comments_list = DbComment.comments_of_product(Convert.ToInt32(dataGridView_productsOfSeller.CurrentRow.Cells["ProductId"].Value));

            panel_comment0.Visible = true;
            panel_comment1.Visible = true;

            try
            {
                
                lbl_comment0_text.Text = comments_list[comment_list_index - 1].GetText();
                lbl_comment0_createDate.Text = comments_list[comment_list_index - 1].GetCreateTime().ToString();
                
                if(comments_list[comment_list_index - 1].GetSeller().GetId() != 0)
                {
                    picturebox_comment0_userimage.ImageLocation = comments_list[comment_list_index - 1].GetSeller().GetImage();
                    lbl_comment0_username.Text = comments_list[comment_list_index - 1].GetSeller().GetName();
                }
                else
                {
                    picturebox_comment0_userimage.ImageLocation = comments_list[comment_list_index - 1].GetCustomer().GetImage();
                    lbl_comment0_username.Text = comments_list[comment_list_index - 1].GetCustomer().GetName();
                }
            }
            catch (Exception)
            {
                panel_comment0.Visible = false;
            }
            try
            {
                
                lbl_comment1_text.Text = comments_list[comment_list_index].GetText();
                lbl_comment1_createDate.Text = comments_list[comment_list_index].GetCreateTime().ToString();

                if (comments_list[comment_list_index].GetSeller().GetId() != 0)
                {
                    picturebox_comment1_userimage.ImageLocation = comments_list[comment_list_index].GetSeller().GetImage();
                    lbl_comment1_username.Text = comments_list[comment_list_index].GetSeller().GetName();
                }
                else
                {
                    picturebox_comment1_userimage.ImageLocation = comments_list[comment_list_index].GetCustomer().GetImage();
                    lbl_comment1_username.Text = comments_list[comment_list_index].GetCustomer().GetName();
                }
            }
            catch (Exception)
            {
                panel_comment1.Visible = false;
            }
            }
            catch (Exception) // bir şekilde boş dgv ye tıklarsa sorun çıkarmasın
            {


            }
        }

        private void btn_slideComments_left_Click(object sender, EventArgs e)
        {
            if (comment_list_index > 1) // listenin başına gelindiğinde dursun , index -1 e vs. inmesin
            {
                comment_list_index -= 2;
                fill_comments();
            }
        }

        private void btn_slideComments_right_Click(object sender, EventArgs e)
        {
            if (comments_list.Count > comment_list_index + 1) // gidilebilecek liste elemanı varsa
            {
                comment_list_index += 2;
                fill_comments();
            }
        }

        private void pictureBox_seller_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_seller.ImageLocation = openFileDialog1.FileName;
        }

        private void pictureBox_product_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_product.ImageLocation = openFileDialog1.FileName;
        }
    }
}
