
namespace Exercise_Login_Binding
{
    partial class Form5
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Telepon = new System.Windows.Forms.TextBox();
            this.Kelamin = new System.Windows.Forms.TextBox();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Nomor = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(120, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rincian";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(30, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nomor Telepon";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(30, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Jenis Kelamin";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Alamat Anggota";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Anggota";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nomor Anggota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Telepon
            // 
            this.Telepon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Telepon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Telepon.Location = new System.Drawing.Point(166, 297);
            this.Telepon.Name = "Telepon";
            this.Telepon.Size = new System.Drawing.Size(153, 22);
            this.Telepon.TabIndex = 17;
            this.Telepon.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Kelamin
            // 
            this.Kelamin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Kelamin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kelamin.Location = new System.Drawing.Point(166, 241);
            this.Kelamin.Name = "Kelamin";
            this.Kelamin.Size = new System.Drawing.Size(153, 22);
            this.Kelamin.TabIndex = 16;
            this.Kelamin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Alamat
            // 
            this.Alamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Alamat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Alamat.Location = new System.Drawing.Point(166, 186);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(153, 22);
            this.Alamat.TabIndex = 15;
            this.Alamat.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Nama
            // 
            this.Nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nama.Location = new System.Drawing.Point(166, 130);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(153, 22);
            this.Nama.TabIndex = 14;
            this.Nama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nomor
            // 
            this.Nomor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nomor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nomor.Location = new System.Drawing.Point(166, 72);
            this.Nomor.Name = "Nomor";
            this.Nomor.Size = new System.Drawing.Size(153, 22);
            this.Nomor.TabIndex = 13;
            this.Nomor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_Login_Binding.Properties.Resources.back_12955;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Telepon);
            this.panel1.Controls.Add(this.Kelamin);
            this.panel1.Controls.Add(this.Alamat);
            this.panel1.Controls.Add(this.Nama);
            this.panel1.Controls.Add(this.Nomor);
            this.panel1.Location = new System.Drawing.Point(22, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 396);
            this.panel1.TabIndex = 25;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(391, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Rincian";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Telepon;
        private System.Windows.Forms.TextBox Kelamin;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Nomor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}