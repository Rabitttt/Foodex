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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            picturBox_productimage.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product = fill_product_data_from_Form(product);
            DbProduct.db_addNewProduct(product);
            this.Close();
        }

        private Product fill_product_data_from_Form(Product product)
        {
            product.SetName(txtb_name.Text);
            product.SetPrice(Convert.ToDouble(txtb_price.Text));
            product.SetType(cmbbox_type.Text);
            product.SetDescription(richtxtBox_description.Text);
            product.SetCreate_date(DateTime.Now);
            product.SetImage(picturBox_productimage.ImageLocation);
            product.SetOwner(DbSeller.get_active_user_data()); //return active seller for owner
            product.SetName(txtb_name.Text);
            product.SetScore(0);
            return product;
        }

        private void picturBox_productimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturBox_productimage.ImageLocation = openFileDialog1.FileName;
        }
    }
}
