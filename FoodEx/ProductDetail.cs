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
            if(Seller.activeSeller != 0)
            {
                btn_buy.Enabled = false;
                btn_GivePoint.Enabled = false;
            }
        }
        
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

    }
}
