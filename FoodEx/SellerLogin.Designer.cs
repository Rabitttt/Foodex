namespace FoodEx
{
    partial class SellerLogin
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
            this.panel_sellerLogin = new System.Windows.Forms.Panel();
            this.lbl_showPasswordText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_sl_kullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_sl_parola = new System.Windows.Forms.Label();
            this.txtb_sl_password = new System.Windows.Forms.TextBox();
            this.txtb_sl_username = new System.Windows.Forms.TextBox();
            this.btn_sl_login = new System.Windows.Forms.Button();
            this.panel_sellerLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sellerLogin
            // 
            this.panel_sellerLogin.BackColor = System.Drawing.Color.Chocolate;
            this.panel_sellerLogin.Controls.Add(this.lbl_showPasswordText);
            this.panel_sellerLogin.Controls.Add(this.label7);
            this.panel_sellerLogin.Controls.Add(this.lbl_sl_kullaniciAdi);
            this.panel_sellerLogin.Controls.Add(this.lbl_sl_parola);
            this.panel_sellerLogin.Controls.Add(this.txtb_sl_password);
            this.panel_sellerLogin.Controls.Add(this.txtb_sl_username);
            this.panel_sellerLogin.Controls.Add(this.btn_sl_login);
            this.panel_sellerLogin.Location = new System.Drawing.Point(0, 0);
            this.panel_sellerLogin.Name = "panel_sellerLogin";
            this.panel_sellerLogin.Size = new System.Drawing.Size(492, 460);
            this.panel_sellerLogin.TabIndex = 3;
            // 
            // lbl_showPasswordText
            // 
            this.lbl_showPasswordText.AutoSize = true;
            this.lbl_showPasswordText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_showPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showPasswordText.Location = new System.Drawing.Point(340, 182);
            this.lbl_showPasswordText.Name = "lbl_showPasswordText";
            this.lbl_showPasswordText.Size = new System.Drawing.Size(20, 16);
            this.lbl_showPasswordText.TabIndex = 23;
            this.lbl_showPasswordText.Text = "👁️";
            this.lbl_showPasswordText.MouseLeave += new System.EventHandler(this.lbl_showPasswordText_MouseLeave);
            this.lbl_showPasswordText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_showPasswordText_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(147, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "YEMEK SEPETİ";
            // 
            // lbl_sl_kullaniciAdi
            // 
            this.lbl_sl_kullaniciAdi.AutoSize = true;
            this.lbl_sl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sl_kullaniciAdi.Location = new System.Drawing.Point(129, 144);
            this.lbl_sl_kullaniciAdi.Name = "lbl_sl_kullaniciAdi";
            this.lbl_sl_kullaniciAdi.Size = new System.Drawing.Size(98, 16);
            this.lbl_sl_kullaniciAdi.TabIndex = 21;
            this.lbl_sl_kullaniciAdi.Text = "User Name : ";
            // 
            // lbl_sl_parola
            // 
            this.lbl_sl_parola.AutoSize = true;
            this.lbl_sl_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sl_parola.Location = new System.Drawing.Point(147, 184);
            this.lbl_sl_parola.Name = "lbl_sl_parola";
            this.lbl_sl_parola.Size = new System.Drawing.Size(80, 16);
            this.lbl_sl_parola.TabIndex = 19;
            this.lbl_sl_parola.Text = "Pasword : ";
            // 
            // txtb_sl_password
            // 
            this.txtb_sl_password.Location = new System.Drawing.Point(248, 181);
            this.txtb_sl_password.Name = "txtb_sl_password";
            this.txtb_sl_password.Size = new System.Drawing.Size(112, 20);
            this.txtb_sl_password.TabIndex = 17;
            this.txtb_sl_password.UseSystemPasswordChar = true;
            // 
            // txtb_sl_username
            // 
            this.txtb_sl_username.Location = new System.Drawing.Point(248, 144);
            this.txtb_sl_username.Name = "txtb_sl_username";
            this.txtb_sl_username.Size = new System.Drawing.Size(112, 20);
            this.txtb_sl_username.TabIndex = 18;
            // 
            // btn_sl_login
            // 
            this.btn_sl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sl_login.Location = new System.Drawing.Point(144, 233);
            this.btn_sl_login.Name = "btn_sl_login";
            this.btn_sl_login.Size = new System.Drawing.Size(216, 52);
            this.btn_sl_login.TabIndex = 6;
            this.btn_sl_login.Text = "Login";
            this.btn_sl_login.UseVisualStyleBackColor = true;
            this.btn_sl_login.Click += new System.EventHandler(this.btn_sl_login_Click);
            // 
            // SellerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_sellerLogin);
            this.Name = "SellerLogin";
            this.Size = new System.Drawing.Size(492, 460);
            this.panel_sellerLogin.ResumeLayout(false);
            this.panel_sellerLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sellerLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_sl_kullaniciAdi;
        private System.Windows.Forms.Label lbl_sl_parola;
        private System.Windows.Forms.TextBox txtb_sl_password;
        private System.Windows.Forms.TextBox txtb_sl_username;
        private System.Windows.Forms.Button btn_sl_login;
        private System.Windows.Forms.Label lbl_showPasswordText;
    }
}
