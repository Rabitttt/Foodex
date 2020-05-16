namespace FoodEx
{
    partial class SellerSignup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_SellerSignin = new System.Windows.Forms.Panel();
            this.pictureBox_ss = new System.Windows.Forms.PictureBox();
            this.txtbMasked_ss_Telephone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.btn_ss_Signin = new System.Windows.Forms.Button();
            this.lbl_ss_Address = new System.Windows.Forms.Label();
            this.lbl_ss_Companyname = new System.Windows.Forms.Label();
            this.txtb_ss_Username = new System.Windows.Forms.TextBox();
            this.lbl_ss_Telephone = new System.Windows.Forms.Label();
            this.txtb_ss_Password = new System.Windows.Forms.TextBox();
            this.lbl_ss_ConfirmPasword = new System.Windows.Forms.Label();
            this.txtb_ss_Confirmpassword = new System.Windows.Forms.TextBox();
            this.lbl_ss_Username = new System.Windows.Forms.Label();
            this.lbl_ss_Password = new System.Windows.Forms.Label();
            this.txtb_ss_Companyname = new System.Windows.Forms.TextBox();
            this.txtb_ss_Address = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_SellerSignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ss)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_SellerSignin
            // 
            this.panel_SellerSignin.BackColor = System.Drawing.Color.Peru;
            this.panel_SellerSignin.Controls.Add(this.pictureBox_ss);
            this.panel_SellerSignin.Controls.Add(this.txtbMasked_ss_Telephone);
            this.panel_SellerSignin.Controls.Add(this.lbl_baslik);
            this.panel_SellerSignin.Controls.Add(this.btn_ss_Signin);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_Address);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_Companyname);
            this.panel_SellerSignin.Controls.Add(this.txtb_ss_Username);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_Telephone);
            this.panel_SellerSignin.Controls.Add(this.txtb_ss_Password);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_ConfirmPasword);
            this.panel_SellerSignin.Controls.Add(this.txtb_ss_Confirmpassword);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_Username);
            this.panel_SellerSignin.Controls.Add(this.lbl_ss_Password);
            this.panel_SellerSignin.Controls.Add(this.txtb_ss_Companyname);
            this.panel_SellerSignin.Controls.Add(this.txtb_ss_Address);
            this.panel_SellerSignin.Location = new System.Drawing.Point(0, 0);
            this.panel_SellerSignin.Name = "panel_SellerSignin";
            this.panel_SellerSignin.Size = new System.Drawing.Size(492, 460);
            this.panel_SellerSignin.TabIndex = 3;
            // 
            // pictureBox_ss
            // 
            this.pictureBox_ss.Image = global::FoodEx.Properties.Resources.addPicture;
            this.pictureBox_ss.Location = new System.Drawing.Point(182, 48);
            this.pictureBox_ss.Name = "pictureBox_ss";
            this.pictureBox_ss.Size = new System.Drawing.Size(141, 93);
            this.pictureBox_ss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ss.TabIndex = 44;
            this.pictureBox_ss.TabStop = false;
            this.pictureBox_ss.Click += new System.EventHandler(this.pictureBox_ss_Click);
            // 
            // txtbMasked_ss_Telephone
            // 
            this.txtbMasked_ss_Telephone.Location = new System.Drawing.Point(255, 270);
            this.txtbMasked_ss_Telephone.Mask = "(999) 000-0000";
            this.txtbMasked_ss_Telephone.Name = "txtbMasked_ss_Telephone";
            this.txtbMasked_ss_Telephone.Size = new System.Drawing.Size(100, 20);
            this.txtbMasked_ss_Telephone.TabIndex = 28;
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_baslik.Location = new System.Drawing.Point(152, 16);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(201, 29);
            this.lbl_baslik.TabIndex = 43;
            this.lbl_baslik.Text = "YEMEK SEPETİ";
            // 
            // btn_ss_Signin
            // 
            this.btn_ss_Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ss_Signin.Location = new System.Drawing.Point(124, 377);
            this.btn_ss_Signin.Name = "btn_ss_Signin";
            this.btn_ss_Signin.Size = new System.Drawing.Size(231, 45);
            this.btn_ss_Signin.TabIndex = 30;
            this.btn_ss_Signin.Text = "Create Seller Account";
            this.btn_ss_Signin.UseVisualStyleBackColor = true;
            this.btn_ss_Signin.Click += new System.EventHandler(this.btn_ss_Signin_Click);
            // 
            // lbl_ss_Address
            // 
            this.lbl_ss_Address.AutoSize = true;
            this.lbl_ss_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_Address.Location = new System.Drawing.Point(156, 345);
            this.lbl_ss_Address.Name = "lbl_ss_Address";
            this.lbl_ss_Address.Size = new System.Drawing.Size(78, 16);
            this.lbl_ss_Address.TabIndex = 38;
            this.lbl_ss_Address.Text = "Address : ";
            // 
            // lbl_ss_Companyname
            // 
            this.lbl_ss_Companyname.AutoSize = true;
            this.lbl_ss_Companyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_Companyname.Location = new System.Drawing.Point(104, 307);
            this.lbl_ss_Companyname.Name = "lbl_ss_Companyname";
            this.lbl_ss_Companyname.Size = new System.Drawing.Size(130, 16);
            this.lbl_ss_Companyname.TabIndex = 39;
            this.lbl_ss_Companyname.Text = "Company Name : ";
            // 
            // txtb_ss_Username
            // 
            this.txtb_ss_Username.Location = new System.Drawing.Point(255, 160);
            this.txtb_ss_Username.Name = "txtb_ss_Username";
            this.txtb_ss_Username.Size = new System.Drawing.Size(100, 20);
            this.txtb_ss_Username.TabIndex = 36;
            // 
            // lbl_ss_Telephone
            // 
            this.lbl_ss_Telephone.AutoSize = true;
            this.lbl_ss_Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_Telephone.Location = new System.Drawing.Point(139, 271);
            this.lbl_ss_Telephone.Name = "lbl_ss_Telephone";
            this.lbl_ss_Telephone.Size = new System.Drawing.Size(95, 16);
            this.lbl_ss_Telephone.TabIndex = 40;
            this.lbl_ss_Telephone.Text = "Telephone : ";
            // 
            // txtb_ss_Password
            // 
            this.txtb_ss_Password.Location = new System.Drawing.Point(255, 196);
            this.txtb_ss_Password.Name = "txtb_ss_Password";
            this.txtb_ss_Password.Size = new System.Drawing.Size(100, 20);
            this.txtb_ss_Password.TabIndex = 35;
            this.txtb_ss_Password.UseSystemPasswordChar = true;
            // 
            // lbl_ss_ConfirmPasword
            // 
            this.lbl_ss_ConfirmPasword.AutoSize = true;
            this.lbl_ss_ConfirmPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_ConfirmPasword.Location = new System.Drawing.Point(98, 233);
            this.lbl_ss_ConfirmPasword.Name = "lbl_ss_ConfirmPasword";
            this.lbl_ss_ConfirmPasword.Size = new System.Drawing.Size(136, 16);
            this.lbl_ss_ConfirmPasword.TabIndex = 41;
            this.lbl_ss_ConfirmPasword.Text = "Confirm Pasword : ";
            // 
            // txtb_ss_Confirmpassword
            // 
            this.txtb_ss_Confirmpassword.Location = new System.Drawing.Point(255, 232);
            this.txtb_ss_Confirmpassword.Name = "txtb_ss_Confirmpassword";
            this.txtb_ss_Confirmpassword.Size = new System.Drawing.Size(100, 20);
            this.txtb_ss_Confirmpassword.TabIndex = 34;
            this.txtb_ss_Confirmpassword.UseSystemPasswordChar = true;
            // 
            // lbl_ss_Username
            // 
            this.lbl_ss_Username.AutoSize = true;
            this.lbl_ss_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_Username.Location = new System.Drawing.Point(136, 161);
            this.lbl_ss_Username.Name = "lbl_ss_Username";
            this.lbl_ss_Username.Size = new System.Drawing.Size(104, 16);
            this.lbl_ss_Username.TabIndex = 42;
            this.lbl_ss_Username.Text = "*User Name : ";
            // 
            // lbl_ss_Password
            // 
            this.lbl_ss_Password.AutoSize = true;
            this.lbl_ss_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ss_Password.Location = new System.Drawing.Point(154, 197);
            this.lbl_ss_Password.Name = "lbl_ss_Password";
            this.lbl_ss_Password.Size = new System.Drawing.Size(80, 16);
            this.lbl_ss_Password.TabIndex = 37;
            this.lbl_ss_Password.Text = "Pasword : ";
            // 
            // txtb_ss_Companyname
            // 
            this.txtb_ss_Companyname.Location = new System.Drawing.Point(255, 306);
            this.txtb_ss_Companyname.Name = "txtb_ss_Companyname";
            this.txtb_ss_Companyname.Size = new System.Drawing.Size(100, 20);
            this.txtb_ss_Companyname.TabIndex = 32;
            // 
            // txtb_ss_Address
            // 
            this.txtb_ss_Address.Location = new System.Drawing.Point(255, 341);
            this.txtb_ss_Address.Name = "txtb_ss_Address";
            this.txtb_ss_Address.Size = new System.Drawing.Size(100, 20);
            this.txtb_ss_Address.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SellerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_SellerSignin);
            this.Name = "SellerSignup";
            this.Size = new System.Drawing.Size(492, 460);
            this.panel_SellerSignin.ResumeLayout(false);
            this.panel_SellerSignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_SellerSignin;
        private System.Windows.Forms.PictureBox pictureBox_ss;
        private System.Windows.Forms.MaskedTextBox txtbMasked_ss_Telephone;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Button btn_ss_Signin;
        private System.Windows.Forms.Label lbl_ss_Address;
        private System.Windows.Forms.Label lbl_ss_Companyname;
        private System.Windows.Forms.TextBox txtb_ss_Username;
        private System.Windows.Forms.Label lbl_ss_Telephone;
        private System.Windows.Forms.TextBox txtb_ss_Password;
        private System.Windows.Forms.Label lbl_ss_ConfirmPasword;
        private System.Windows.Forms.TextBox txtb_ss_Confirmpassword;
        private System.Windows.Forms.Label lbl_ss_Username;
        private System.Windows.Forms.Label lbl_ss_Password;
        private System.Windows.Forms.TextBox txtb_ss_Companyname;
        private System.Windows.Forms.TextBox txtb_ss_Address;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
