namespace FoodEx
{
    partial class CustomerSignup
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
            this.panel_customerSignin = new System.Windows.Forms.Panel();
            this.pictureBox_cs = new System.Windows.Forms.PictureBox();
            this.txtbMasked_cs_telephone = new System.Windows.Forms.MaskedTextBox();
            this.dTP_cs_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cs_signin = new System.Windows.Forms.Button();
            this.lbl_cs_BirthDate = new System.Windows.Forms.Label();
            this.lbl_cs_Telephone = new System.Windows.Forms.Label();
            this.lbl_cs_ConfirmPassword = new System.Windows.Forms.Label();
            this.lbl_c_sUsername = new System.Windows.Forms.Label();
            this.lbl_cs_Password = new System.Windows.Forms.Label();
            this.txtb_cs_ConfirmPasword = new System.Windows.Forms.TextBox();
            this.txtb_cs_Password = new System.Windows.Forms.TextBox();
            this.txtb_cs_Username = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_customerSignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_customerSignin
            // 
            this.panel_customerSignin.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_customerSignin.Controls.Add(this.pictureBox_cs);
            this.panel_customerSignin.Controls.Add(this.txtbMasked_cs_telephone);
            this.panel_customerSignin.Controls.Add(this.dTP_cs_BirthDate);
            this.panel_customerSignin.Controls.Add(this.label2);
            this.panel_customerSignin.Controls.Add(this.btn_cs_signin);
            this.panel_customerSignin.Controls.Add(this.lbl_cs_BirthDate);
            this.panel_customerSignin.Controls.Add(this.lbl_cs_Telephone);
            this.panel_customerSignin.Controls.Add(this.lbl_cs_ConfirmPassword);
            this.panel_customerSignin.Controls.Add(this.lbl_c_sUsername);
            this.panel_customerSignin.Controls.Add(this.lbl_cs_Password);
            this.panel_customerSignin.Controls.Add(this.txtb_cs_ConfirmPasword);
            this.panel_customerSignin.Controls.Add(this.txtb_cs_Password);
            this.panel_customerSignin.Controls.Add(this.txtb_cs_Username);
            this.panel_customerSignin.Location = new System.Drawing.Point(0, 0);
            this.panel_customerSignin.Name = "panel_customerSignin";
            this.panel_customerSignin.Size = new System.Drawing.Size(492, 460);
            this.panel_customerSignin.TabIndex = 2;
            // 
            // pictureBox_cs
            // 
            this.pictureBox_cs.Image = global::FoodEx.Properties.Resources.addPicture;
            this.pictureBox_cs.Location = new System.Drawing.Point(152, 68);
            this.pictureBox_cs.Name = "pictureBox_cs";
            this.pictureBox_cs.Size = new System.Drawing.Size(141, 93);
            this.pictureBox_cs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cs.TabIndex = 46;
            this.pictureBox_cs.TabStop = false;
            this.pictureBox_cs.Click += new System.EventHandler(this.pictureBox_cs_Click);
            // 
            // txtbMasked_cs_telephone
            // 
            this.txtbMasked_cs_telephone.Location = new System.Drawing.Point(232, 288);
            this.txtbMasked_cs_telephone.Mask = "(999) 000-0000";
            this.txtbMasked_cs_telephone.Name = "txtbMasked_cs_telephone";
            this.txtbMasked_cs_telephone.Size = new System.Drawing.Size(100, 20);
            this.txtbMasked_cs_telephone.TabIndex = 28;
            // 
            // dTP_cs_BirthDate
            // 
            this.dTP_cs_BirthDate.Location = new System.Drawing.Point(232, 327);
            this.dTP_cs_BirthDate.Name = "dTP_cs_BirthDate";
            this.dTP_cs_BirthDate.Size = new System.Drawing.Size(172, 20);
            this.dTP_cs_BirthDate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(131, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "YEMEK SEPETİ";
            // 
            // btn_cs_signin
            // 
            this.btn_cs_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cs_signin.Location = new System.Drawing.Point(116, 368);
            this.btn_cs_signin.Name = "btn_cs_signin";
            this.btn_cs_signin.Size = new System.Drawing.Size(227, 51);
            this.btn_cs_signin.TabIndex = 16;
            this.btn_cs_signin.Text = "Create Account";
            this.btn_cs_signin.UseVisualStyleBackColor = true;
            this.btn_cs_signin.Click += new System.EventHandler(this.btn_cs_signin_Click);
            // 
            // lbl_cs_BirthDate
            // 
            this.lbl_cs_BirthDate.AutoSize = true;
            this.lbl_cs_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cs_BirthDate.Location = new System.Drawing.Point(113, 331);
            this.lbl_cs_BirthDate.Name = "lbl_cs_BirthDate";
            this.lbl_cs_BirthDate.Size = new System.Drawing.Size(97, 16);
            this.lbl_cs_BirthDate.TabIndex = 22;
            this.lbl_cs_BirthDate.Text = "Birtdh Date : ";
            // 
            // lbl_cs_Telephone
            // 
            this.lbl_cs_Telephone.AutoSize = true;
            this.lbl_cs_Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cs_Telephone.Location = new System.Drawing.Point(116, 293);
            this.lbl_cs_Telephone.Name = "lbl_cs_Telephone";
            this.lbl_cs_Telephone.Size = new System.Drawing.Size(95, 16);
            this.lbl_cs_Telephone.TabIndex = 23;
            this.lbl_cs_Telephone.Text = "Telephone : ";
            // 
            // lbl_cs_ConfirmPassword
            // 
            this.lbl_cs_ConfirmPassword.AutoSize = true;
            this.lbl_cs_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cs_ConfirmPassword.Location = new System.Drawing.Point(75, 255);
            this.lbl_cs_ConfirmPassword.Name = "lbl_cs_ConfirmPassword";
            this.lbl_cs_ConfirmPassword.Size = new System.Drawing.Size(136, 16);
            this.lbl_cs_ConfirmPassword.TabIndex = 24;
            this.lbl_cs_ConfirmPassword.Text = "Confirm Pasword : ";
            // 
            // lbl_c_sUsername
            // 
            this.lbl_c_sUsername.AutoSize = true;
            this.lbl_c_sUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c_sUsername.Location = new System.Drawing.Point(113, 183);
            this.lbl_c_sUsername.Name = "lbl_c_sUsername";
            this.lbl_c_sUsername.Size = new System.Drawing.Size(104, 16);
            this.lbl_c_sUsername.TabIndex = 25;
            this.lbl_c_sUsername.Text = "*User Name : ";
            // 
            // lbl_cs_Password
            // 
            this.lbl_cs_Password.AutoSize = true;
            this.lbl_cs_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cs_Password.Location = new System.Drawing.Point(131, 219);
            this.lbl_cs_Password.Name = "lbl_cs_Password";
            this.lbl_cs_Password.Size = new System.Drawing.Size(80, 16);
            this.lbl_cs_Password.TabIndex = 21;
            this.lbl_cs_Password.Text = "Pasword : ";
            // 
            // txtb_cs_ConfirmPasword
            // 
            this.txtb_cs_ConfirmPasword.Location = new System.Drawing.Point(232, 254);
            this.txtb_cs_ConfirmPasword.Name = "txtb_cs_ConfirmPasword";
            this.txtb_cs_ConfirmPasword.Size = new System.Drawing.Size(100, 20);
            this.txtb_cs_ConfirmPasword.TabIndex = 18;
            this.txtb_cs_ConfirmPasword.UseSystemPasswordChar = true;
            // 
            // txtb_cs_Password
            // 
            this.txtb_cs_Password.Location = new System.Drawing.Point(232, 218);
            this.txtb_cs_Password.Name = "txtb_cs_Password";
            this.txtb_cs_Password.Size = new System.Drawing.Size(100, 20);
            this.txtb_cs_Password.TabIndex = 19;
            this.txtb_cs_Password.UseSystemPasswordChar = true;
            // 
            // txtb_cs_Username
            // 
            this.txtb_cs_Username.Location = new System.Drawing.Point(232, 182);
            this.txtb_cs_Username.Name = "txtb_cs_Username";
            this.txtb_cs_Username.Size = new System.Drawing.Size(100, 20);
            this.txtb_cs_Username.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CustomerSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customerSignin);
            this.Name = "CustomerSignup";
            this.Size = new System.Drawing.Size(492, 460);
            this.panel_customerSignin.ResumeLayout(false);
            this.panel_customerSignin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_customerSignin;
        private System.Windows.Forms.PictureBox pictureBox_cs;
        private System.Windows.Forms.MaskedTextBox txtbMasked_cs_telephone;
        private System.Windows.Forms.DateTimePicker dTP_cs_BirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cs_signin;
        private System.Windows.Forms.Label lbl_cs_BirthDate;
        private System.Windows.Forms.Label lbl_cs_Telephone;
        private System.Windows.Forms.Label lbl_cs_ConfirmPassword;
        private System.Windows.Forms.Label lbl_c_sUsername;
        private System.Windows.Forms.Label lbl_cs_Password;
        private System.Windows.Forms.TextBox txtb_cs_ConfirmPasword;
        private System.Windows.Forms.TextBox txtb_cs_Password;
        private System.Windows.Forms.TextBox txtb_cs_Username;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
