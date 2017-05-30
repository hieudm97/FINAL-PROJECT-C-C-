namespace PROJECT.GUI.QUANLI.FORM_THÊM
{
    partial class THEMVIDEO
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
            this.cbo_album = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_danhgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenphim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maphim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_đuongdan = new System.Windows.Forms.TextBox();
            this.cbo_nghesi = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_album
            // 
            this.cbo_album.FormattingEnabled = true;
            this.cbo_album.Location = new System.Drawing.Point(324, 113);
            this.cbo_album.Name = "cbo_album";
            this.cbo_album.Size = new System.Drawing.Size(142, 24);
            this.cbo_album.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "MỞ FILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "ĐƯỜNG DẪN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "ALBUM";
            // 
            // txt_danhgia
            // 
            this.txt_danhgia.Location = new System.Drawing.Point(324, 42);
            this.txt_danhgia.Name = "txt_danhgia";
            this.txt_danhgia.Size = new System.Drawing.Size(142, 22);
            this.txt_danhgia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ĐÁNH GIÁ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "THÊM PHIM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "NGHỆ SĨ";
            // 
            // txt_tenphim
            // 
            this.txt_tenphim.Location = new System.Drawing.Point(76, 113);
            this.txt_tenphim.Name = "txt_tenphim";
            this.txt_tenphim.Size = new System.Drawing.Size(142, 22);
            this.txt_tenphim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "MÃ PHIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHIM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 67);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbo_nghesi);
            this.panel2.Controls.Add(this.txt_đuongdan);
            this.panel2.Controls.Add(this.cbo_album);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_danhgia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_tenphim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_maphim);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 254);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÊN PHIM";
            // 
            // txt_maphim
            // 
            this.txt_maphim.Location = new System.Drawing.Point(76, 39);
            this.txt_maphim.Name = "txt_maphim";
            this.txt_maphim.ReadOnly = true;
            this.txt_maphim.Size = new System.Drawing.Size(142, 22);
            this.txt_maphim.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 52);
            this.panel1.TabIndex = 2;
            // 
            // txt_đuongdan
            // 
            this.txt_đuongdan.Location = new System.Drawing.Point(267, 226);
            this.txt_đuongdan.Name = "txt_đuongdan";
            this.txt_đuongdan.Size = new System.Drawing.Size(195, 22);
            this.txt_đuongdan.TabIndex = 13;
            // 
            // cbo_nghesi
            // 
            this.cbo_nghesi.FormattingEnabled = true;
            this.cbo_nghesi.Location = new System.Drawing.Point(76, 191);
            this.cbo_nghesi.Name = "cbo_nghesi";
            this.cbo_nghesi.Size = new System.Drawing.Size(142, 24);
            this.cbo_nghesi.TabIndex = 14;
            // 
            // THEMVIDEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 373);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "THEMVIDEO";
            this.Text = "THEMVIDEO";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_album;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_danhgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenphim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maphim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_đuongdan;
        private System.Windows.Forms.ComboBox cbo_nghesi;
    }
}