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
            lbl_name.Text = product.GetName();
            lbl_type.Text = product.GetType();
            lbl_createDate.Text = product.GetCreate_date().ToString();
            lbl_price.Text = product.GetPrice().ToString();
            lbl_score.Text = product.GetScore().ToString();
            pictureBox_product.ImageLocation= product.GetImage();
            lbl_description.Text = product.GetDescription();
            //açıklama uzun olabilir, belirtilen alana sıgması için formatlıyoruz
        }

        private void fill_comments()
        {

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
