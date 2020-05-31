namespace FoodEx
{
    partial class OpenPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_openpage = new System.Windows.Forms.MenuStrip();
            this.menuItem_UserLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_UserSignin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CompanyLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_CompanySignin = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSignup1 = new FoodEx.CustomerSignup();
            this.customerLogin1 = new FoodEx.CustomerLogin();
            this.sellerLogin1 = new FoodEx.SellerLogin();
            this.sellerSignup1 = new FoodEx.SellerSignup();
            this.menuStrip_openpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_openpage
            // 
            this.menuStrip_openpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip_openpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip_openpage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip_openpage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_openpage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_UserLogin,
            this.MenuItem_UserSignin,
            this.MenuItem_CompanyLogin,
            this.MenuItem_CompanySignin});
            this.menuStrip_openpage.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_openpage.Name = "menuStrip_openpage";
            this.menuStrip_openpage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 2);
            this.menuStrip_openpage.Size = new System.Drawing.Size(156, 566);
            this.menuStrip_openpage.TabIndex = 15;
            this.menuStrip_openpage.Text = "menuStrip1";
            // 
            // menuItem_UserLogin
            // 
            this.menuItem_UserLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.menuItem_UserLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_UserLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItem_UserLogin.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.menuItem_UserLogin.Name = "menuItem_UserLogin";
            this.menuItem_UserLogin.Size = new System.Drawing.Size(139, 25);
            this.menuItem_UserLogin.Text = "User Login";
            this.menuItem_UserLogin.Click += new System.EventHandler(this.menuItem_UserLogin_Click);
            // 
            // MenuItem_UserSignin
            // 
            this.MenuItem_UserSignin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem_UserSignin.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.MenuItem_UserSignin.Name = "MenuItem_UserSignin";
            this.MenuItem_UserSignin.Size = new System.Drawing.Size(139, 25);
            this.MenuItem_UserSignin.Text = "User Sign Up";
            this.MenuItem_UserSignin.Click += new System.EventHandler(this.MenuItem_UserSignin_Click);
            // 
            // MenuItem_CompanyLogin
            // 
            this.MenuItem_CompanyLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuItem_CompanyLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem_CompanyLogin.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.MenuItem_CompanyLogin.Name = "MenuItem_CompanyLogin";
            this.MenuItem_CompanyLogin.Size = new System.Drawing.Size(139, 25);
            this.MenuItem_CompanyLogin.Text = "Company Login";
            this.MenuItem_CompanyLogin.Click += new System.EventHandler(this.MenuItem_CompanyLogin_Click);
            // 
            // MenuItem_CompanySignin
            // 
            this.MenuItem_CompanySignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuItem_CompanySignin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem_CompanySignin.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.MenuItem_CompanySignin.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.MenuItem_CompanySignin.Name = "MenuItem_CompanySignin";
            this.MenuItem_CompanySignin.Size = new System.Drawing.Size(139, 25);
            this.MenuItem_CompanySignin.Text = "Company Sign Up";
            this.MenuItem_CompanySignin.Click += new System.EventHandler(this.MenuItem_CompanySignin_Click);
            // 
            // customerSignup1
            // 
            this.customerSignup1.Location = new System.Drawing.Point(195, 0);
            this.customerSignup1.Margin = new System.Windows.Forms.Padding(5);
            this.customerSignup1.Name = "customerSignup1";
            this.customerSignup1.Size = new System.Drawing.Size(656, 566);
            this.customerSignup1.TabIndex = 19;
            this.customerSignup1.Load += new System.EventHandler(this.customerSignup1_Load);
            // 
            // customerLogin1
            // 
            this.customerLogin1.Location = new System.Drawing.Point(195, 0);
            this.customerLogin1.Margin = new System.Windows.Forms.Padding(5);
            this.customerLogin1.Name = "customerLogin1";
            this.customerLogin1.Size = new System.Drawing.Size(656, 566);
            this.customerLogin1.TabIndex = 18;
            // 
            // sellerLogin1
            // 
            this.sellerLogin1.Location = new System.Drawing.Point(195, 0);
            this.sellerLogin1.Margin = new System.Windows.Forms.Padding(5);
            this.sellerLogin1.Name = "sellerLogin1";
            this.sellerLogin1.Size = new System.Drawing.Size(656, 566);
            this.sellerLogin1.TabIndex = 17;
            // 
            // sellerSignup1
            // 
            this.sellerSignup1.Location = new System.Drawing.Point(195, 0);
            this.sellerSignup1.Margin = new System.Windows.Forms.Padding(5);
            this.sellerSignup1.Name = "sellerSignup1";
            this.sellerSignup1.Size = new System.Drawing.Size(656, 566);
            this.sellerSignup1.TabIndex = 16;
            // 
            // OpenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 566);
            this.Controls.Add(this.customerSignup1);
            this.Controls.Add(this.customerLogin1);
            this.Controls.Add(this.sellerLogin1);
            this.Controls.Add(this.sellerSignup1);
            this.Controls.Add(this.menuStrip_openpage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OpenPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenPage";
            this.menuStrip_openpage.ResumeLayout(false);
            this.menuStrip_openpage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_openpage;
        private System.Windows.Forms.ToolStripMenuItem menuItem_UserLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_UserSignin;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_CompanyLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_CompanySignin;
        private SellerSignup sellerSignup1;
        private SellerLogin sellerLogin1;
        private CustomerLogin customerLogin1;
        private CustomerSignup customerSignup1;
    }
}