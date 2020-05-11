using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodEx
{
    public partial class OpenPage : Form
    {
        public OpenPage()
        {
            InitializeComponent();
            ShowPanelCustomerLogin();
            customerLogin1.BringToFront();
        }

        public void ShowPanelCustomerLogin()
        {
            menuItem_UserLogin.BackColor = Color.SteelBlue;
            MenuItem_UserSignin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanyLogin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanySignin.BackColor = Color.FromArgb(646464);
        }
        public void ShowPanelCustomerSignin()
        {
            menuItem_UserLogin.BackColor = Color.FromArgb(646464);
            MenuItem_UserSignin.BackColor = Color.SteelBlue;
            MenuItem_CompanyLogin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanySignin.BackColor = Color.FromArgb(646464);
        }
        public void ShowPanelSellerLogin()
        {
            menuItem_UserLogin.BackColor = Color.FromArgb(646464);
            MenuItem_UserSignin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanyLogin.BackColor = Color.SteelBlue;
            MenuItem_CompanySignin.BackColor = Color.FromArgb(646464);
        }
        public void ShowPanelSellerSignin()
        {
            menuItem_UserLogin.BackColor = Color.FromArgb(646464);
            MenuItem_UserSignin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanyLogin.BackColor = Color.FromArgb(646464);
            MenuItem_CompanySignin.BackColor = Color.SteelBlue;
        }

        private void menuItem_UserLogin_Click(object sender, EventArgs e)
        {
            customerLogin1.BringToFront();
            ShowPanelCustomerLogin();
        }

        private void MenuItem_UserSignin_Click(object sender, EventArgs e)
        {
            customerSignup1.BringToFront();
            ShowPanelCustomerSignin();
        }

        private void MenuItem_CompanyLogin_Click(object sender, EventArgs e)
        {
            sellerLogin1.BringToFront();
            ShowPanelSellerLogin();
        }

        private void MenuItem_CompanySignin_Click(object sender, EventArgs e)
        {
            sellerSignup1.BringToFront();
            ShowPanelSellerSignin();
        }
    }
}
