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
    public partial class SellerLogin : UserControl
    {
        public SellerLogin()
        {
            InitializeComponent();
        }

        private void btn_sl_login_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.SetName(txtb_sl_username.Text);
            seller.SetPassword(txtb_sl_password.Text);
            DbSeller.is_account_exist(seller);
            OpenPage.ActiveForm.Close();
        }

        private void lbl_showPasswordText_MouseMove(object sender, MouseEventArgs e)
        {
            txtb_sl_password.UseSystemPasswordChar = false;
        }
        private void lbl_showPasswordText_MouseLeave(object sender, EventArgs e)
        {
            txtb_sl_password.UseSystemPasswordChar = true;
        }
    }
}
