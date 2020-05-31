using System.Windows.Forms;

namespace FoodEx
{
    partial class Foods : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods));
            this.panel_desserts = new System.Windows.Forms.Panel();
            this.panel_mainfoods = new System.Windows.Forms.Panel();
            this.panel_drinks = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox_desserts = new System.Windows.Forms.PictureBox();
            this.pictureBox_mainfood = new System.Windows.Forms.PictureBox();
            this.pictureBox_drinks = new System.Windows.Forms.PictureBox();
            this.btn_slideRight = new System.Windows.Forms.Button();
            this.btn_slideLeft = new System.Windows.Forms.Button();
            this.panel0 = new System.Windows.Forms.Panel();
            this.lbl_product0_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_product0_sellername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_product0_score = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_product0_name = new System.Windows.Forms.Label();
            this.lbl_product0_price = new System.Windows.Forms.Label();
            this.picturbox_product0 = new System.Windows.Forms.PictureBox();
            this.btn_product0_detail = new System.Windows.Forms.Button();
            this.btn_product0_buy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_product2_id = new System.Windows.Forms.Label();
            this.lbl_product2_sellername = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_product2_score = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_product2_name = new System.Windows.Forms.Label();
            this.lbl_product2_price = new System.Windows.Forms.Label();
            this.picturbox_product2 = new System.Windows.Forms.PictureBox();
            this.btn_product2_detail = new System.Windows.Forms.Button();
            this.btn_product2_buy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_product1_id = new System.Windows.Forms.Label();
            this.lbl_product1_sellername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_product1_score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_product1_name = new System.Windows.Forms.Label();
            this.lbl_product1_price = new System.Windows.Forms.Label();
            this.picturbox_product1 = new System.Windows.Forms.PictureBox();
            this.btn_product1_detail = new System.Windows.Forms.Button();
            this.btn_product1_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_desserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mainfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drinks)).BeginInit();
            this.panel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product0)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_desserts
            // 
            this.panel_desserts.Location = new System.Drawing.Point(734, 204);
            this.panel_desserts.Name = "panel_desserts";
            this.panel_desserts.Size = new System.Drawing.Size(224, 10);
            this.panel_desserts.TabIndex = 55;
            // 
            // panel_mainfoods
            // 
            this.panel_mainfoods.Location = new System.Drawing.Point(435, 204);
            this.panel_mainfoods.Name = "panel_mainfoods";
            this.panel_mainfoods.Size = new System.Drawing.Size(232, 10);
            this.panel_mainfoods.TabIndex = 56;
            // 
            // panel_drinks
            // 
            this.panel_drinks.BackColor = System.Drawing.Color.White;
            this.panel_drinks.Location = new System.Drawing.Point(150, 204);
            this.panel_drinks.Name = "panel_drinks";
            this.panel_drinks.Size = new System.Drawing.Size(239, 10);
            this.panel_drinks.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Olive;
            this.label19.Location = new System.Drawing.Point(776, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 36);
            this.label19.TabIndex = 51;
            this.label19.Text = "Desserts";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Olive;
            this.label20.Location = new System.Drawing.Point(197, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 36);
            this.label20.TabIndex = 52;
            this.label20.Text = "Drinks";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Olive;
            this.label21.Location = new System.Drawing.Point(452, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(182, 36);
            this.label21.TabIndex = 53;
            this.label21.Text = "Main Menu";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Olive;
            this.label22.Location = new System.Drawing.Point(197, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 36);
            this.label22.TabIndex = 54;
            this.label22.Text = "Drinks";
            // 
            // pictureBox_desserts
            // 
            this.pictureBox_desserts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_desserts.Image")));
            this.pictureBox_desserts.Location = new System.Drawing.Point(734, 70);
            this.pictureBox_desserts.Name = "pictureBox_desserts";
            this.pictureBox_desserts.Size = new System.Drawing.Size(224, 128);
            this.pictureBox_desserts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_desserts.TabIndex = 48;
            this.pictureBox_desserts.TabStop = false;
            this.pictureBox_desserts.Click += new System.EventHandler(this.pictureBox_desserts_Click);
            // 
            // pictureBox_mainfood
            // 
            this.pictureBox_mainfood.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_mainfood.Image")));
            this.pictureBox_mainfood.Location = new System.Drawing.Point(435, 72);
            this.pictureBox_mainfood.Name = "pictureBox_mainfood";
            this.pictureBox_mainfood.Size = new System.Drawing.Size(232, 126);
            this.pictureBox_mainfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_mainfood.TabIndex = 49;
            this.pictureBox_mainfood.TabStop = false;
            this.pictureBox_mainfood.Click += new System.EventHandler(this.pictureBox_mainfood_Click);
            // 
            // pictureBox_drinks
            // 
            this.pictureBox_drinks.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_drinks.Image")));
            this.pictureBox_drinks.Location = new System.Drawing.Point(150, 72);
            this.pictureBox_drinks.Name = "pictureBox_drinks";
            this.pictureBox_drinks.Size = new System.Drawing.Size(239, 126);
            this.pictureBox_drinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_drinks.TabIndex = 50;
            this.pictureBox_drinks.TabStop = false;
            this.pictureBox_drinks.Click += new System.EventHandler(this.pictureBox_drinks_Click);
            // 
            // btn_slideRight
            // 
            this.btn_slideRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_slideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slideRight.Location = new System.Drawing.Point(1064, 318);
            this.btn_slideRight.Name = "btn_slideRight";
            this.btn_slideRight.Size = new System.Drawing.Size(41, 121);
            this.btn_slideRight.TabIndex = 46;
            this.btn_slideRight.Text = ">";
            this.btn_slideRight.UseVisualStyleBackColor = false;
            this.btn_slideRight.Click += new System.EventHandler(this.btn_slideRight_Click);
            // 
            // btn_slideLeft
            // 
            this.btn_slideLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_slideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_slideLeft.Location = new System.Drawing.Point(18, 318);
            this.btn_slideLeft.Name = "btn_slideLeft";
            this.btn_slideLeft.Size = new System.Drawing.Size(41, 121);
            this.btn_slideLeft.TabIndex = 47;
            this.btn_slideLeft.Text = "<";
            this.btn_slideLeft.UseVisualStyleBackColor = false;
            this.btn_slideLeft.Click += new System.EventHandler(this.btn_slideLeft_Click);
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.lbl_product0_id);
            this.panel0.Controls.Add(this.label1);
            this.panel0.Controls.Add(this.lbl_product0_sellername);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Controls.Add(this.lbl_product0_score);
            this.panel0.Controls.Add(this.label9);
            this.panel0.Controls.Add(this.pictureBox1);
            this.panel0.Controls.Add(this.lbl_product0_name);
            this.panel0.Controls.Add(this.lbl_product0_price);
            this.panel0.Controls.Add(this.picturbox_product0);
            this.panel0.Controls.Add(this.btn_product0_detail);
            this.panel0.Controls.Add(this.btn_product0_buy);
            this.panel0.Location = new System.Drawing.Point(65, 218);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(327, 407);
            this.panel0.TabIndex = 43;
            // 
            // lbl_product0_id
            // 
            this.lbl_product0_id.AutoSize = true;
            this.lbl_product0_id.Location = new System.Drawing.Point(284, 9);
            this.lbl_product0_id.Name = "lbl_product0_id";
            this.lbl_product0_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_product0_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "id : ";
            // 
            // lbl_product0_sellername
            // 
            this.lbl_product0_sellername.AutoSize = true;
            this.lbl_product0_sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product0_sellername.Location = new System.Drawing.Point(80, 277);
            this.lbl_product0_sellername.Name = "lbl_product0_sellername";
            this.lbl_product0_sellername.Size = new System.Drawing.Size(0, 20);
            this.lbl_product0_sellername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seller : ";
            // 
            // lbl_product0_score
            // 
            this.lbl_product0_score.AutoSize = true;
            this.lbl_product0_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product0_score.Location = new System.Drawing.Point(80, 307);
            this.lbl_product0_score.Name = "lbl_product0_score";
            this.lbl_product0_score.Size = new System.Drawing.Size(18, 20);
            this.lbl_product0_score.TabIndex = 6;
            this.lbl_product0_score.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Score : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_product0_name
            // 
            this.lbl_product0_name.AutoSize = true;
            this.lbl_product0_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product0_name.Location = new System.Drawing.Point(20, 9);
            this.lbl_product0_name.Name = "lbl_product0_name";
            this.lbl_product0_name.Size = new System.Drawing.Size(61, 22);
            this.lbl_product0_name.TabIndex = 0;
            this.lbl_product0_name.Text = "name";
            // 
            // lbl_product0_price
            // 
            this.lbl_product0_price.AutoSize = true;
            this.lbl_product0_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product0_price.Location = new System.Drawing.Point(80, 362);
            this.lbl_product0_price.Name = "lbl_product0_price";
            this.lbl_product0_price.Size = new System.Drawing.Size(21, 24);
            this.lbl_product0_price.TabIndex = 4;
            this.lbl_product0_price.Text = "0";
            // 
            // picturbox_product0
            // 
            this.picturbox_product0.Image = ((System.Drawing.Image)(resources.GetObject("picturbox_product0.Image")));
            this.picturbox_product0.Location = new System.Drawing.Point(15, 45);
            this.picturbox_product0.Name = "picturbox_product0";
            this.picturbox_product0.Size = new System.Drawing.Size(304, 208);
            this.picturbox_product0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturbox_product0.TabIndex = 1;
            this.picturbox_product0.TabStop = false;
            // 
            // btn_product0_detail
            // 
            this.btn_product0_detail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product0_detail.Location = new System.Drawing.Point(202, 290);
            this.btn_product0_detail.Name = "btn_product0_detail";
            this.btn_product0_detail.Size = new System.Drawing.Size(117, 53);
            this.btn_product0_detail.TabIndex = 3;
            this.btn_product0_detail.Text = "Detail";
            this.btn_product0_detail.UseVisualStyleBackColor = true;
            this.btn_product0_detail.Click += new System.EventHandler(this.btn_product0_detail_Click);
            // 
            // btn_product0_buy
            // 
            this.btn_product0_buy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product0_buy.Location = new System.Drawing.Point(202, 349);
            this.btn_product0_buy.Name = "btn_product0_buy";
            this.btn_product0_buy.Size = new System.Drawing.Size(117, 47);
            this.btn_product0_buy.TabIndex = 2;
            this.btn_product0_buy.Text = "Buy";
            this.btn_product0_buy.UseVisualStyleBackColor = true;
            this.btn_product0_buy.Click += new System.EventHandler(this.btn_product0_buy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_product2_id);
            this.panel2.Controls.Add(this.lbl_product2_sellername);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_product2_score);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.lbl_product2_name);
            this.panel2.Controls.Add(this.lbl_product2_price);
            this.panel2.Controls.Add(this.picturbox_product2);
            this.panel2.Controls.Add(this.btn_product2_detail);
            this.panel2.Controls.Add(this.btn_product2_buy);
            this.panel2.Location = new System.Drawing.Point(731, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 407);
            this.panel2.TabIndex = 44;
            // 
            // lbl_product2_id
            // 
            this.lbl_product2_id.AutoSize = true;
            this.lbl_product2_id.Location = new System.Drawing.Point(288, 9);
            this.lbl_product2_id.Name = "lbl_product2_id";
            this.lbl_product2_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_product2_id.TabIndex = 8;
            // 
            // lbl_product2_sellername
            // 
            this.lbl_product2_sellername.AutoSize = true;
            this.lbl_product2_sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product2_sellername.Location = new System.Drawing.Point(80, 277);
            this.lbl_product2_sellername.Name = "lbl_product2_sellername";
            this.lbl_product2_sellername.Size = new System.Drawing.Size(0, 20);
            this.lbl_product2_sellername.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Seller : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "id : ";
            // 
            // lbl_product2_score
            // 
            this.lbl_product2_score.AutoSize = true;
            this.lbl_product2_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product2_score.Location = new System.Drawing.Point(80, 307);
            this.lbl_product2_score.Name = "lbl_product2_score";
            this.lbl_product2_score.Size = new System.Drawing.Size(18, 20);
            this.lbl_product2_score.TabIndex = 6;
            this.lbl_product2_score.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "Score : ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(24, 351);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_product2_name
            // 
            this.lbl_product2_name.AutoSize = true;
            this.lbl_product2_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product2_name.Location = new System.Drawing.Point(20, 9);
            this.lbl_product2_name.Name = "lbl_product2_name";
            this.lbl_product2_name.Size = new System.Drawing.Size(0, 22);
            this.lbl_product2_name.TabIndex = 0;
            // 
            // lbl_product2_price
            // 
            this.lbl_product2_price.AutoSize = true;
            this.lbl_product2_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product2_price.Location = new System.Drawing.Point(80, 362);
            this.lbl_product2_price.Name = "lbl_product2_price";
            this.lbl_product2_price.Size = new System.Drawing.Size(21, 24);
            this.lbl_product2_price.TabIndex = 4;
            this.lbl_product2_price.Text = "0";
            // 
            // picturbox_product2
            // 
            this.picturbox_product2.Image = ((System.Drawing.Image)(resources.GetObject("picturbox_product2.Image")));
            this.picturbox_product2.Location = new System.Drawing.Point(15, 45);
            this.picturbox_product2.Name = "picturbox_product2";
            this.picturbox_product2.Size = new System.Drawing.Size(304, 208);
            this.picturbox_product2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturbox_product2.TabIndex = 1;
            this.picturbox_product2.TabStop = false;
            // 
            // btn_product2_detail
            // 
            this.btn_product2_detail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product2_detail.Location = new System.Drawing.Point(202, 290);
            this.btn_product2_detail.Name = "btn_product2_detail";
            this.btn_product2_detail.Size = new System.Drawing.Size(117, 53);
            this.btn_product2_detail.TabIndex = 3;
            this.btn_product2_detail.Text = "Detail";
            this.btn_product2_detail.UseVisualStyleBackColor = true;
            this.btn_product2_detail.Click += new System.EventHandler(this.btn_product2_detail_Click);
            // 
            // btn_product2_buy
            // 
            this.btn_product2_buy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product2_buy.Location = new System.Drawing.Point(202, 349);
            this.btn_product2_buy.Name = "btn_product2_buy";
            this.btn_product2_buy.Size = new System.Drawing.Size(117, 47);
            this.btn_product2_buy.TabIndex = 2;
            this.btn_product2_buy.Text = "Buy";
            this.btn_product2_buy.UseVisualStyleBackColor = true;
            this.btn_product2_buy.Click += new System.EventHandler(this.btn_product2_buy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_product1_id);
            this.panel1.Controls.Add(this.lbl_product1_sellername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_product1_score);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_product1_name);
            this.panel1.Controls.Add(this.lbl_product1_price);
            this.panel1.Controls.Add(this.picturbox_product1);
            this.panel1.Controls.Add(this.btn_product1_detail);
            this.panel1.Controls.Add(this.btn_product1_buy);
            this.panel1.Location = new System.Drawing.Point(398, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 407);
            this.panel1.TabIndex = 45;
            // 
            // lbl_product1_id
            // 
            this.lbl_product1_id.AutoSize = true;
            this.lbl_product1_id.Location = new System.Drawing.Point(290, 9);
            this.lbl_product1_id.Name = "lbl_product1_id";
            this.lbl_product1_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_product1_id.TabIndex = 8;
            // 
            // lbl_product1_sellername
            // 
            this.lbl_product1_sellername.AutoSize = true;
            this.lbl_product1_sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product1_sellername.Location = new System.Drawing.Point(80, 277);
            this.lbl_product1_sellername.Name = "lbl_product1_sellername";
            this.lbl_product1_sellername.Size = new System.Drawing.Size(0, 20);
            this.lbl_product1_sellername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "id : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seller : ";
            // 
            // lbl_product1_score
            // 
            this.lbl_product1_score.AutoSize = true;
            this.lbl_product1_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product1_score.Location = new System.Drawing.Point(80, 307);
            this.lbl_product1_score.Name = "lbl_product1_score";
            this.lbl_product1_score.Size = new System.Drawing.Size(18, 20);
            this.lbl_product1_score.TabIndex = 6;
            this.lbl_product1_score.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Score : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(24, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_product1_name
            // 
            this.lbl_product1_name.AutoSize = true;
            this.lbl_product1_name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product1_name.Location = new System.Drawing.Point(20, 9);
            this.lbl_product1_name.Name = "lbl_product1_name";
            this.lbl_product1_name.Size = new System.Drawing.Size(0, 22);
            this.lbl_product1_name.TabIndex = 0;
            // 
            // lbl_product1_price
            // 
            this.lbl_product1_price.AutoSize = true;
            this.lbl_product1_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product1_price.Location = new System.Drawing.Point(80, 362);
            this.lbl_product1_price.Name = "lbl_product1_price";
            this.lbl_product1_price.Size = new System.Drawing.Size(21, 24);
            this.lbl_product1_price.TabIndex = 4;
            this.lbl_product1_price.Text = "0";
            // 
            // picturbox_product1
            // 
            this.picturbox_product1.Image = ((System.Drawing.Image)(resources.GetObject("picturbox_product1.Image")));
            this.picturbox_product1.Location = new System.Drawing.Point(15, 45);
            this.picturbox_product1.Name = "picturbox_product1";
            this.picturbox_product1.Size = new System.Drawing.Size(304, 208);
            this.picturbox_product1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturbox_product1.TabIndex = 1;
            this.picturbox_product1.TabStop = false;
            // 
            // btn_product1_detail
            // 
            this.btn_product1_detail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product1_detail.Location = new System.Drawing.Point(202, 290);
            this.btn_product1_detail.Name = "btn_product1_detail";
            this.btn_product1_detail.Size = new System.Drawing.Size(117, 53);
            this.btn_product1_detail.TabIndex = 3;
            this.btn_product1_detail.Text = "Detail";
            this.btn_product1_detail.UseVisualStyleBackColor = true;
            this.btn_product1_detail.Click += new System.EventHandler(this.btn_product1_detail_Click);
            // 
            // btn_product1_buy
            // 
            this.btn_product1_buy.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product1_buy.Location = new System.Drawing.Point(202, 349);
            this.btn_product1_buy.Name = "btn_product1_buy";
            this.btn_product1_buy.Size = new System.Drawing.Size(117, 47);
            this.btn_product1_buy.TabIndex = 2;
            this.btn_product1_buy.Text = "Buy";
            this.btn_product1_buy.UseVisualStyleBackColor = true;
            this.btn_product1_buy.Click += new System.EventHandler(this.btn_product1_buy_Click);
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_desserts);
            this.Controls.Add(this.panel_mainfoods);
            this.Controls.Add(this.panel_drinks);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox_desserts);
            this.Controls.Add(this.pictureBox_mainfood);
            this.Controls.Add(this.pictureBox_drinks);
            this.Controls.Add(this.btn_slideRight);
            this.Controls.Add(this.btn_slideLeft);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Foods";
            this.Size = new System.Drawing.Size(1213, 708);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_desserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mainfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drinks)).EndInit();
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product0)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturbox_product1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_desserts;
        private System.Windows.Forms.Panel panel_mainfoods;
        private System.Windows.Forms.Panel panel_drinks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox_desserts;
        private System.Windows.Forms.PictureBox pictureBox_mainfood;
        private System.Windows.Forms.PictureBox pictureBox_drinks;
        private System.Windows.Forms.Button btn_slideRight;
        private System.Windows.Forms.Button btn_slideLeft;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Label lbl_product0_sellername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_product0_score;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_product0_name;
        private System.Windows.Forms.Label lbl_product0_price;
        private System.Windows.Forms.PictureBox picturbox_product0;
        private System.Windows.Forms.Button btn_product0_detail;
        private System.Windows.Forms.Button btn_product0_buy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_product2_sellername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_product2_score;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_product2_name;
        private System.Windows.Forms.Label lbl_product2_price;
        private System.Windows.Forms.PictureBox picturbox_product2;
        private System.Windows.Forms.Button btn_product2_detail;
        private System.Windows.Forms.Button btn_product2_buy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_product1_sellername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_product1_score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_product1_name;
        private System.Windows.Forms.Label lbl_product1_price;
        private System.Windows.Forms.PictureBox picturbox_product1;
        private System.Windows.Forms.Button btn_product1_detail;
        private System.Windows.Forms.Button btn_product1_buy;
        private Label lbl_product0_id;
        private Label label1;
        private Label lbl_product2_id;
        private Label label6;
        private Label lbl_product1_id;
        private Label label3;
    }
}
