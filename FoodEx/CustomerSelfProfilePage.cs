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
    public partial class CustomerSelfProfilePage : UserControl
    {
        public CustomerSelfProfilePage()
        {
            InitializeComponent();
        }

        List<Comment> comments_list = new List<Comment>();
        private int list_index = 1;

        public void firts_open()
        {
            fill_user_details();
            fill_comments();
        }

        private void fill_user_details()
        {
            Customer customer = new Customer();
            customer = DbCustomer.get_customer_from_id(Customer.activeCustomer);

            pictureBox_user.ImageLocation = customer.GetImage();
            txtb_name.Text = customer.GetName();
            maskedtxtb_telephone.Text = customer.GetTelephone_number();
            dateTimePicker1.Text = customer.GetBirth_date().ToString();
            numericUpdown_money.Value = Convert.ToDecimal(customer.GetMoney());
        }

        private void fill_comments()
        {
            comments_list = DbComment.get_comments_of_active_user();

            try
            {
                lbl_product0_name.Text = comments_list[list_index - 1].GetProduct().GetName();
                lbl_sellername0.Text = comments_list[list_index - 1].GetProduct().GetOwner().GetName();
                rtxtb_comment0.Text = comments_list[list_index - 1].GetText();
                picturebox_product0.ImageLocation = comments_list[list_index - 1].GetProduct().GetImage();
            }
            catch (Exception)
            {
                lbl_product0_name.Text = "";
                lbl_sellername0.Text = "";
                rtxtb_comment0.Text = "";
                picturebox_product0.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
            }
            try
            {
                lbl_product1_name.Text = comments_list[list_index].GetProduct().GetName();
                lbl_sellername1.Text = comments_list[list_index].GetProduct().GetOwner().GetName();
                rtxtb_comment1.Text = comments_list[list_index].GetText();
                picturebox_product1.ImageLocation = comments_list[list_index].GetProduct().GetImage();
            }
            catch (Exception)
            {
                lbl_product1_name.Text = "";
                lbl_sellername1.Text = "";
                rtxtb_comment1.Text = "";
                picturebox_product1.ImageLocation = "C:\\Users\\Selman\\Desktop\\images\\addPicture.png";
            }
        }

        private void btn_user_update_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.SetName(txtb_name.Text);
            customer.SetPassword(DbCustomer.get_customer_from_id(Customer.activeCustomer).GetPassword()); //bu aşamada parola güncellensin istemiyoruz eski parolayı tekrar yazdırıyorum.
            customer.SetTelephone_number(maskedtxtb_telephone.Text);
            customer.SetBirth_date(dateTimePicker1.Value);
            customer.SetImage(pictureBox_user.ImageLocation);
            customer.SetMoney(Convert.ToInt32(numericUpdown_money.Value));

            DialogResult dialog = MessageBox.Show("Update changed fields.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(customer.GetName()) || string.IsNullOrEmpty(customer.GetPassword()))
                {
                    MessageBox.Show("Username field is required. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DbCustomer.UpdateCustomer(customer);
                    MessageBox.Show("Updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
                
        }

        private void pictureBox_user_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_user.ImageLocation = openFileDialog1.FileName;
        }

        private void btn_user_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete this account.", "Okey", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DbCustomer.DeleteProfile();
                Customer.activeCustomer = 0;
                Application.Restart(); //Hesap silindi giriş sayfasına dön
            }

        }

        private void btn_slideComments_left_Click(object sender, EventArgs e)
        {
            if (list_index > 1) // listenin başına gelindiğinde dursun , index -1 e vs. inmesin
            {
                list_index -= 2;
                fill_comments();
            }
        }

        private void btn_slideComments_right_Click(object sender, EventArgs e)
        {
            if (comments_list.Count > list_index +1) // gidilebilecek liste elemanı varsa
            {
                list_index += 2;
                fill_comments();
            }
        }
    }
}
