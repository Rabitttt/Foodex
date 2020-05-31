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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ShowMainPage();
            OpenPageControl();
            foods1.first_open();
            start_menu_labels();
        }

        public void OpenPageControl()
        {
            Visible = false;
            OpenPage firstpage = new OpenPage();
            firstpage.ShowDialog();
            if (Customer.activeCustomer == 0 && Seller.activeSeller == 0) //Program kapatildi
            {
               this.Close();
            }
            else
            {
                this.Visible = true; 
            }
        }

        public void ShowMainPage()
        {
            foods1.BringToFront();
            menuItem_MainPage.BackColor = Color.SteelBlue;
            menuItem_Profile.BackColor = Color.FromArgb(646464);
            menuItem_AppDescription.BackColor = Color.FromArgb(646464);
            menuItem_Logout.BackColor = Color.FromArgb(646464);
        }
        public void ShowCustomerSelfProfile() //Self profile is Editable
        {
            customerSelfProfilePage1.BringToFront();
            menuItem_MainPage.BackColor = Color.FromArgb(646464);
            menuItem_Profile.BackColor = Color.SteelBlue;
            menuItem_AppDescription.BackColor = Color.FromArgb(646464);
            menuItem_Logout.BackColor = Color.FromArgb(646464);
        }
        public void ShowSellerSelfProfile() //Self profile is Editable
        {
            sellerSelfProfilePage1.BringToFront();
            menuItem_MainPage.BackColor = Color.FromArgb(646464);
            menuItem_Profile.BackColor = Color.SteelBlue;
            menuItem_AppDescription.BackColor = Color.FromArgb(646464);
            menuItem_Logout.BackColor = Color.FromArgb(646464);
        }
        public void ShowAppDescriptionPage()
        {
            appDescriptionPage1.BringToFront();
            menuItem_MainPage.BackColor = Color.FromArgb(646464);
            menuItem_Profile.BackColor = Color.FromArgb(646464);
            menuItem_AppDescription.BackColor = Color.SteelBlue;
            menuItem_Logout.BackColor = Color.FromArgb(646464);
        }

        private void menuItem_MainPage_Click(object sender, EventArgs e)
        {
            ShowMainPage();
            foods1.first_open();
        }
        private void menuItem_Profile_Click(object sender, EventArgs e)
        {
            if (Customer.activeCustomer != 0)
            {
                customerSelfProfilePage1.firts_open();
                ShowCustomerSelfProfile();
            }
            if (Seller.activeSeller != 0)
            {
                sellerSelfProfilePage1.first_open();
                ShowSellerSelfProfile();
            }
            
        }

        private void menuItem_AppDescription_Click(object sender, EventArgs e)
        {
            ShowAppDescriptionPage();
        }

        private void menuItem_Logout_Click(object sender, EventArgs e) //programı yeniden başlattık giriş ekranına döndü.
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToLongTimeString();
            lbl_clock.Text = clock;

            if (Customer.activeCustomer != 0)
            {
                lbl_active_usermoney.Text = DbCustomer.get_customer_from_id(Customer.activeCustomer).GetMoney().ToString(); //menudeki para değiştiğinde güncelleyebilmek için
            }
        }

        private void start_menu_labels()
        {
            timer1.Enabled = true; //timer
            
            if(Customer.activeCustomer != 0) //hangi turden kullanıcı açık ise ona gore atama yap
            {
                Customer customer = new Customer();
                customer = DbCustomer.get_customer_from_id(Customer.activeCustomer);
                lbl_active_username.Text = customer.GetName();
                lbl_dolar.Visible = true;
                lbl_active_usermoney.Visible = true;
                lbl_active_usermoney.Text = customer.GetMoney().ToString();

            }
            if(Seller.activeSeller != 0)
            {
                lbl_active_username.Text = DbSeller.get_seller_data_from_id(Seller.activeSeller).GetName();
                lbl_dolar.Visible = false;
                lbl_active_usermoney.Visible = false;

            }
        }

        private void sellerSelfProfilePage1_Load(object sender, EventArgs e)
        {

        }
    }
}
