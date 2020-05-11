namespace FoodEx
{
    partial class CustomerLogin
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
            this.panel_customerLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_cl_Parola = new System.Windows.Forms.Label();
            this.txtb_cl_Pasword = new System.Windows.Forms.TextBox();
            this.txtb_cl_Username = new System.Windows.Forms.TextBox();
            this.btn_Customerlogin = new System.Windows.Forms.Button();
            this.lbl_showPasswordText = new System.Windows.Forms.Label();
            this.panel_customerLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_customerLogin
            // 
            this.panel_customerLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_customerLogin.Controls.Add(this.lbl_showPasswordText);
            this.panel_customerLogin.Controls.Add(this.label1);
            this.panel_customerLogin.Controls.Add(this.lbl_cl_KullaniciAdi);
            this.panel_customerLogin.Controls.Add(this.lbl_cl_Parola);
            this.panel_customerLogin.Controls.Add(this.txtb_cl_Pasword);
            this.panel_customerLogin.Controls.Add(this.txtb_cl_Username);
            this.panel_customerLogin.Controls.Add(this.btn_Customerlogin);
            this.panel_customerLogin.Location = new System.Drawing.Point(0, 0);
            this.panel_customerLogin.Name = "panel_customerLogin";
            this.panel_customerLogin.Size = new System.Drawing.Size(492, 460);
            this.panel_customerLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(116, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "YEMEK SEPETİ";
            // 
            // lbl_cl_KullaniciAdi
            // 
            this.lbl_cl_KullaniciAdi.AutoSize = true;
            this.lbl_cl_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cl_KullaniciAdi.Location = new System.Drawing.Point(98, 158);
            this.lbl_cl_KullaniciAdi.Name = "lbl_cl_KullaniciAdi";
            this.lbl_cl_KullaniciAdi.Size = new System.Drawing.Size(98, 16);
            this.lbl_cl_KullaniciAdi.TabIndex = 12;
            this.lbl_cl_KullaniciAdi.Text = "User Name : ";
            // 
            // lbl_cl_Parola
            // 
            this.lbl_cl_Parola.AutoSize = true;
            this.lbl_cl_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cl_Parola.Location = new System.Drawing.Point(116, 198);
            this.lbl_cl_Parola.Name = "lbl_cl_Parola";
            this.lbl_cl_Parola.Size = new System.Drawing.Size(80, 16);
            this.lbl_cl_Parola.TabIndex = 10;
            this.lbl_cl_Parola.Text = "Pasword : ";
            // 
            // txtb_cl_Pasword
            // 
            this.txtb_cl_Pasword.Location = new System.Drawing.Point(217, 195);
            this.txtb_cl_Pasword.Name = "txtb_cl_Pasword";
            this.txtb_cl_Pasword.Size = new System.Drawing.Size(111, 20);
            this.txtb_cl_Pasword.TabIndex = 8;
            this.txtb_cl_Pasword.UseSystemPasswordChar = true;
            // 
            // txtb_cl_Username
            // 
            this.txtb_cl_Username.Location = new System.Drawing.Point(217, 158);
            this.txtb_cl_Username.Name = "txtb_cl_Username";
            this.txtb_cl_Username.Size = new System.Drawing.Size(111, 20);
            this.txtb_cl_Username.TabIndex = 9;
            // 
            // btn_Customerlogin
            // 
            this.btn_Customerlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customerlogin.Location = new System.Drawing.Point(101, 243);
            this.btn_Customerlogin.Name = "btn_Customerlogin";
            this.btn_Customerlogin.Size = new System.Drawing.Size(227, 43);
            this.btn_Customerlogin.TabIndex = 6;
            this.btn_Customerlogin.Text = "Login";
            this.btn_Customerlogin.UseVisualStyleBackColor = true;
            this.btn_Customerlogin.Click += new System.EventHandler(this.btn_Customerlogin_Click);
            // 
            // lbl_showPasswordText
            // 
            this.lbl_showPasswordText.AutoSize = true;
            this.lbl_showPasswordText.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_showPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showPasswordText.Location = new System.Drawing.Point(308, 196);
            this.lbl_showPasswordText.Name = "lbl_showPasswordText";
            this.lbl_showPasswordText.Size = new System.Drawing.Size(20, 16);
            this.lbl_showPasswordText.TabIndex = 24;
            this.lbl_showPasswordText.Text = "👁️";
            this.lbl_showPasswordText.MouseLeave += new System.EventHandler(this.lbl_showPasswordText_MouseLeave);
            this.lbl_showPasswordText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_showPasswordText_MouseMove);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_customerLogin);
            this.Name = "CustomerLogin";
            this.Size = new System.Drawing.Size(492, 460);
            this.panel_customerLogin.ResumeLayout(false);
            this.panel_customerLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_customerLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_cl_Parola;
        private System.Windows.Forms.TextBox txtb_cl_Pasword;
        private System.Windows.Forms.TextBox txtb_cl_Username;
        private System.Windows.Forms.Button btn_Customerlogin;
        private System.Windows.Forms.Label lbl_showPasswordText;
    }
}
