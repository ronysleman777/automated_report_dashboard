namespace automated_report_dashboard.forms
{
    partial class log_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_type = new MaterialSkin.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.log_in_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(374, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "نوع المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user_type
            // 
            this.user_type.AutoResize = false;
            this.user_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.user_type.Depth = 0;
            this.user_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.user_type.DropDownHeight = 174;
            this.user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_type.DropDownWidth = 121;
            this.user_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.user_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.user_type.FormattingEnabled = true;
            this.user_type.IntegralHeight = false;
            this.user_type.ItemHeight = 43;
            this.user_type.Location = new System.Drawing.Point(118, 224);
            this.user_type.MaxDropDownItems = 4;
            this.user_type.MouseState = MaterialSkin.MouseState.OUT;
            this.user_type.Name = "user_type";
            this.user_type.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_type.Size = new System.Drawing.Size(250, 49);
            this.user_type.StartIndex = 0;
            this.user_type.TabIndex = 4;
            this.user_type.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::automated_report_dashboard.Properties.Resources.books_48px;
            this.pictureBox1.Location = new System.Drawing.Point(244, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(374, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "كلمة السر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // password
            // 
            this.password.AnimateReadOnly = false;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password.LeadingIcon = null;
            this.password.Location = new System.Drawing.Point(118, 353);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(250, 50);
            this.password.TabIndex = 7;
            this.password.Text = "";
            this.password.TrailingIcon = null;
            // 
            // log_in_button
            // 
            this.log_in_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log_in_button.Location = new System.Drawing.Point(181, 444);
            this.log_in_button.Name = "log_in_button";
            this.log_in_button.Size = new System.Drawing.Size(166, 46);
            this.log_in_button.TabIndex = 8;
            this.log_in_button.Text = "تسجيل الدخول";
            this.log_in_button.UseVisualStyleBackColor = true;
            this.log_in_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.log_in_button);
            this.panel1.Controls.Add(this.user_type);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(111, 67);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(625, 494);
            this.panel1.TabIndex = 9;
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(817, 645);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "log_in";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fff";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox user_type;
        private PictureBox pictureBox1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox password;
        private Button log_in_button;
        private Panel panel1;
    }
}