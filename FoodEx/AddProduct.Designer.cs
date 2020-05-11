namespace FoodEx
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.txtb_price = new System.Windows.Forms.TextBox();
            this.richtxtBox_description = new System.Windows.Forms.RichTextBox();
            this.cmbbox_type = new System.Windows.Forms.ComboBox();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.picturBox_productimage = new System.Windows.Forms.PictureBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picturBox_productimage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_price
            // 
            this.txtb_price.Location = new System.Drawing.Point(188, 183);
            this.txtb_price.Name = "txtb_price";
            this.txtb_price.Size = new System.Drawing.Size(120, 20);
            this.txtb_price.TabIndex = 16;
            // 
            // richtxtBox_description
            // 
            this.richtxtBox_description.Location = new System.Drawing.Point(187, 272);
            this.richtxtBox_description.Name = "richtxtBox_description";
            this.richtxtBox_description.Size = new System.Drawing.Size(121, 96);
            this.richtxtBox_description.TabIndex = 15;
            this.richtxtBox_description.Text = "";
            // 
            // cmbbox_type
            // 
            this.cmbbox_type.FormattingEnabled = true;
            this.cmbbox_type.Items.AddRange(new object[] {
            "Drinks",
            "Main Menu",
            "Desserts"});
            this.cmbbox_type.Location = new System.Drawing.Point(187, 213);
            this.cmbbox_type.Name = "cmbbox_type";
            this.cmbbox_type.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_type.TabIndex = 14;
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(187, 152);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(121, 20);
            this.txtb_name.TabIndex = 13;
            // 
            // picturBox_productimage
            // 
            this.picturBox_productimage.Image = ((System.Drawing.Image)(resources.GetObject("picturBox_productimage.Image")));
            this.picturBox_productimage.Location = new System.Drawing.Point(122, 12);
            this.picturBox_productimage.Name = "picturBox_productimage";
            this.picturBox_productimage.Size = new System.Drawing.Size(186, 121);
            this.picturBox_productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturBox_productimage.TabIndex = 12;
            this.picturBox_productimage.TabStop = false;
            this.picturBox_productimage.Click += new System.EventHandler(this.picturBox_productimage_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(80, 271);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(101, 20);
            this.lbl_description.TabIndex = 8;
            this.lbl_description.Text = "Description : ";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(126, 211);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(55, 20);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "Type : ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(125, 181);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(56, 20);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price : ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(118, 150);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 20);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Name : ";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(122, 387);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(186, 49);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add New Product";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.txtb_price);
            this.Controls.Add(this.richtxtBox_description);
            this.Controls.Add(this.cmbbox_type);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.picturBox_productimage);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_add);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.picturBox_productimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_price;
        private System.Windows.Forms.RichTextBox richtxtBox_description;
        private System.Windows.Forms.ComboBox cmbbox_type;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.PictureBox picturBox_productimage;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}