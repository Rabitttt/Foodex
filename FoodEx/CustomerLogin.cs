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
    public partial class CustomerLogin : UserControl
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btn_Customerlogin_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.SetName(txtb_cl_Username.Text);
            customer.SetPassword(txtb_cl_Pasword.Text);
            DbCustomer.is_account_exist(customer);
            OpenPage.ActiveForm.Close();
        }

        private void lbl_showPasswordText_MouseMove(object sender, MouseEventArgs e)
        {
            txtb_cl_Pasword.UseSystemPasswordChar = false;
        }

        private void lbl_showPasswordText_MouseLeave(              object sender, EventArgs e)
        {
            txtb_cl_Pasword.UseSystemPasswordChar = true;
        }
    }
}
