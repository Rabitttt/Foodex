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

        public void first_open()
        {
            Seller seller = new Seller();
            Product product = new Product();
            seller = DbSeller.get_active_user_data();
            fill_user_data(seller);
            fill_dataGridView_by_productsOfSeller();
            fill_product_detail();
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

        private void btn_product_DeleteProduct_Click(object sender, EventArgs e)
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
        }
    }
}
