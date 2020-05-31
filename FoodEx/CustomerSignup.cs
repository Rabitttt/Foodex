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
    public partial class CustomerSignup : UserControl
    {
        public CustomerSignup()
        {
            InitializeComponent();
        }

        private void btn_cs_signin_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.SetName(txtb_cs_Username.Text);
            customer.SetPassword(txtb_cs_Password.Text);
            customer.SetTelephone_number(txtbMasked_cs_telephone.Text);
            customer.SetBirth_date(dTP_cs_BirthDate.Value);
            customer.SetImage(pictureBox_cs.ImageLocation);
            if (form_is_valid(customer))
            {
                if(DbCustomer.db_AddNewCustomer(customer))
                {
                    DbCustomer.assign_ActiveUSer(customer);
                    OpenPage.ActiveForm.Close();
                }
            }
            else
            {
                return;
            }
            
        }

        private bool form_is_valid(Customer customer)
        {
            if (!customer.GetPassword().Equals(txtb_cs_ConfirmPasword.Text)) //parolarlar eşit mi
            {
                MessageBox.Show("Passwords is not same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(customer.GetName()))
            {
                MessageBox.Show("Username field is required. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void pictureBox_cs_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_cs.ImageLocation = openFileDialog1.FileName;
        }


    }
}
