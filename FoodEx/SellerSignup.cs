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
    public partial class SellerSignup : UserControl
    {
        public SellerSignup()
        {
            InitializeComponent();
            //pictureBox_ss.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
        }

        private void btn_ss_Signin_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.SetName(txtb_ss_Username.Text);
            seller.SetPassword(txtb_ss_Password.Text);
            seller.SetTelephone_number(txtbMasked_ss_Telephone.Text);
            seller.SetCompany_name(txtb_ss_Companyname.Text);
            seller.SetAddress(txtb_ss_Address.Text);
            seller.SetImage(pictureBox_ss.ImageLocation);
            //Burada seller nesnesi valid kontrolu yapılacak
            if (form_is_valid(seller))
            {
                DbSeller.db_AddNewSeller(seller);
            }
            else
            {
                return;
            }
            DbSeller.assign_ActiveUSer(seller);
            OpenPage.ActiveForm.Close();

        }
        private bool form_is_valid(Seller seller)
        {
            if (!seller.GetPassword().Equals(txtb_ss_Confirmpassword.Text)) //parolarlar eşit mi
            {
                MessageBox.Show("Passwords is not same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(seller.GetName()))
            {
                MessageBox.Show("Username field is required. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void pictureBox_ss_Click(object sender, EventArgs e)//choose image with open file dialog
        {
            openFileDialog1.ShowDialog();
            pictureBox_ss.ImageLocation = openFileDialog1.FileName;
        }

    }
}
