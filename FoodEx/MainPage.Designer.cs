namespace FoodEx
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_MainPage = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selmanBurakKaragolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karagölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_MainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_AppDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_active_usermoney = new System.Windows.Forms.Label();
            this.lbl_active_username = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sellerSelfProfilePage1 = new FoodEx.SellerSelfProfilePage();
            this.foods1 = new FoodEx.Foods();
            this.customerSelfProfilePage1 = new FoodEx.CustomerSelfProfilePage();
            this.appDescriptionPage1 = new FoodEx.AppDescriptionPage();
            this.menuStrip_MainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_MainPage
            // 
            this.menuStrip_MainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip_MainPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip_MainPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_MainPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.selmanBurakKaragolToolStripMenuItem,
            this.karagölToolStripMenuItem,
            this.menuItem_MainPage,
            this.menuItem_Profile,
            this.menuItem_AppDescription,
            this.menuItem_Logout});
            this.menuStrip_MainPage.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainPage.Name = "menuStrip_MainPage";
            this.menuStrip_MainPage.Size = new System.Drawing.Size(202, 762);
            this.menuStrip_MainPage.TabIndex = 1;
            this.menuStrip_MainPage.Text = "NavBar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 19);
            this.toolStripMenuItem1.Text = " ";
            // 
            // selmanBurakKaragolToolStripMenuItem
            // 
            this.selmanBurakKaragolToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selmanBurakKaragolToolStripMenuItem.Name = "selmanBurakKaragolToolStripMenuItem";
            this.selmanBurakKaragolToolStripMenuItem.Size = new System.Drawing.Size(189, 33);
            this.selmanBurakKaragolToolStripMenuItem.Text = "Selman Burak";
            // 
            // karagölToolStripMenuItem
            // 
            this.karagölToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karagölToolStripMenuItem.Name = "karagölToolStripMenuItem";
            this.karagölToolStripMenuItem.Size = new System.Drawing.Size(189, 33);
            this.karagölToolStripMenuItem.Text = "Karagöl";
            // 
            // menuItem_MainPage
            // 
            this.menuItem_MainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_MainPage.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.menuItem_MainPage.Name = "menuItem_MainPage";
            this.menuItem_MainPage.Size = new System.Drawing.Size(189, 35);
            this.menuItem_MainPage.Text = "Main Page";
            this.menuItem_MainPage.Click += new System.EventHandler(this.menuItem_MainPage_Click);
            // 
            // menuItem_Profile
            // 
            this.menuItem_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Profile.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.menuItem_Profile.Name = "menuItem_Profile";
            this.menuItem_Profile.Size = new System.Drawing.Size(189, 35);
            this.menuItem_Profile.Text = "Profile";
            this.menuItem_Profile.Click += new System.EventHandler(this.menuItem_Profile_Click);
            // 
            // menuItem_AppDescription
            // 
            this.menuItem_AppDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_AppDescription.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.menuItem_AppDescription.Name = "menuItem_AppDescription";
            this.menuItem_AppDescription.Size = new System.Drawing.Size(189, 33);
            this.menuItem_AppDescription.Text = "App Description";
            this.menuItem_AppDescription.Click += new System.EventHandler(this.menuItem_AppDescription_Click);
            // 
            // menuItem_Logout
            // 
            this.menuItem_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItem_Logout.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.menuItem_Logout.Name = "menuItem_Logout";
            this.menuItem_Logout.Size = new System.Drawing.Size(189, 35);
            this.menuItem_Logout.Text = "Logout";
            this.menuItem_Logout.Click += new System.EventHandler(this.menuItem_Logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // lbl_active_usermoney
            // 
            this.lbl_active_usermoney.AutoSize = true;
            this.lbl_active_usermoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_active_usermoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_active_usermoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_active_usermoney.Location = new System.Drawing.Point(51, 487);
            this.lbl_active_usermoney.Name = "lbl_active_usermoney";
            this.lbl_active_usermoney.Size = new System.Drawing.Size(27, 29);
            this.lbl_active_usermoney.TabIndex = 12;
            this.lbl_active_usermoney.Text = "0";
            // 
            // lbl_active_username
            // 
            this.lbl_active_username.AutoSize = true;
            this.lbl_active_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_active_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_active_username.ForeColor = System.Drawing.Color.White;
            this.lbl_active_username.Location = new System.Drawing.Point(93, 529);
            this.lbl_active_username.Name = "lbl_active_username";
            this.lbl_active_username.Size = new System.Drawing.Size(55, 20);
            this.lbl_active_username.TabIndex = 13;
            this.lbl_active_username.Text = "Name ";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dolar.ForeColor = System.Drawing.Color.Green;
            this.lbl_dolar.Location = new System.Drawing.Point(22, 484);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(30, 31);
            this.lbl_dolar.TabIndex = 14;
            this.lbl_dolar.Text = "$";
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.ForeColor = System.Drawing.Color.White;
            this.lbl_clock.Location = new System.Drawing.Point(35, 561);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(78, 20);
            this.lbl_clock.TabIndex = 15;
            this.lbl_clock.Text = ": CLOCK :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sellerSelfProfilePage1
            // 
            this.sellerSelfProfilePage1.Location = new System.Drawing.Point(205, 12);
            this.sellerSelfProfilePage1.Margin = new System.Windows.Forms.Padding(4);
            this.sellerSelfProfilePage1.Name = "sellerSelfProfilePage1";
            this.sellerSelfProfilePage1.Size = new System.Drawing.Size(1142, 641);
            this.sellerSelfProfilePage1.TabIndex = 21;
            this.sellerSelfProfilePage1.Load += new System.EventHandler(this.sellerSelfProfilePage1_Load);
            // 
            // foods1
            // 
            this.foods1.Location = new System.Drawing.Point(205, 0);
            this.foods1.Margin = new System.Windows.Forms.Padding(4);
            this.foods1.Name = "foods1";
            this.foods1.Size = new System.Drawing.Size(1182, 718);
            this.foods1.TabIndex = 20;
            // 
            // customerSelfProfilePage1
            // 
            this.customerSelfProfilePage1.Location = new System.Drawing.Point(205, 0);
            this.customerSelfProfilePage1.Margin = new System.Windows.Forms.Padding(4);
            this.customerSelfProfilePage1.Name = "customerSelfProfilePage1";
            this.customerSelfProfilePage1.Size = new System.Drawing.Size(1126, 770);
            this.customerSelfProfilePage1.TabIndex = 18;
            // 
            // appDescriptionPage1
            // 
            this.appDescriptionPage1.Location = new System.Drawing.Point(205, -11);
            this.appDescriptionPage1.Margin = new System.Windows.Forms.Padding(4);
            this.appDescriptionPage1.Name = "appDescriptionPage1";
            this.appDescriptionPage1.Size = new System.Drawing.Size(1165, 653);
            this.appDescriptionPage1.TabIndex = 17;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 762);
            this.Controls.Add(this.sellerSelfProfilePage1);
            this.Controls.Add(this.foods1);
            this.Controls.Add(this.customerSelfProfilePage1);
            this.Controls.Add(this.appDescriptionPage1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_active_usermoney);
            this.Controls.Add(this.lbl_active_username);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip_MainPage);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.menuStrip_MainPage.ResumeLayout(false);
            this.menuStrip_MainPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_MainPage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selmanBurakKaragolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karagölToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_MainPage;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Profile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_AppDescription;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_active_usermoney;
        private System.Windows.Forms.Label lbl_active_username;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Label label9;
        private AppDescriptionPage appDescriptionPage1;
        private CustomerSelfProfilePage customerSelfProfilePage1;
        private Foods foods1;
        private SellerSelfProfilePage sellerSelfProfilePage1;
        private System.Windows.Forms.Timer timer1;
    }
}

