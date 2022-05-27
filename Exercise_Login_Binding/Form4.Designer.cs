
namespace Exercise_Login_Binding
{
    partial class Form4
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
            this.anggotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemudaPancasilaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemudaPancasilaDataSet = new Exercise_Login_Binding.PemudaPancasilaDataSet();
            this.anggotaTableAdapter = new Exercise_Login_Binding.PemudaPancasilaDataSetTableAdapters.AnggotaTableAdapter();
            this.dataGridViewPP = new System.Windows.Forms.DataGridView();
            this.nomorTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorAnggotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.anggotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemudaPancasilaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemudaPancasilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anggotaBindingSource
            // 
            this.anggotaBindingSource.DataMember = "Anggota";
            this.anggotaBindingSource.DataSource = this.pemudaPancasilaDataSetBindingSource;
            // 
            // pemudaPancasilaDataSetBindingSource
            // 
            this.pemudaPancasilaDataSetBindingSource.DataSource = this.pemudaPancasilaDataSet;
            this.pemudaPancasilaDataSetBindingSource.Position = 0;
            // 
            // pemudaPancasilaDataSet
            // 
            this.pemudaPancasilaDataSet.DataSetName = "PemudaPancasilaDataSet";
            this.pemudaPancasilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anggotaTableAdapter
            // 
            this.anggotaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewPP
            // 
            this.dataGridViewPP.AutoGenerateColumns = false;
            this.dataGridViewPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorAnggotaDataGridViewTextBoxColumn,
            this.namaAnggotaDataGridViewTextBoxColumn,
            this.alamatAnggotaDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.nomorTeleponDataGridViewTextBoxColumn});
            this.dataGridViewPP.DataSource = this.anggotaBindingSource;
            this.dataGridViewPP.Location = new System.Drawing.Point(7, 129);
            this.dataGridViewPP.Name = "dataGridViewPP";
            this.dataGridViewPP.RowHeadersWidth = 51;
            this.dataGridViewPP.RowTemplate.Height = 24;
            this.dataGridViewPP.Size = new System.Drawing.Size(925, 201);
            this.dataGridViewPP.TabIndex = 0;
            this.dataGridViewPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPP_CellContentClick);
            // 
            // nomorTeleponDataGridViewTextBoxColumn
            // 
            this.nomorTeleponDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Telepon";
            this.nomorTeleponDataGridViewTextBoxColumn.HeaderText = "Nomor_Telepon";
            this.nomorTeleponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorTeleponDataGridViewTextBoxColumn.Name = "nomorTeleponDataGridViewTextBoxColumn";
            this.nomorTeleponDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatAnggotaDataGridViewTextBoxColumn
            // 
            this.alamatAnggotaDataGridViewTextBoxColumn.DataPropertyName = "Alamat_Anggota";
            this.alamatAnggotaDataGridViewTextBoxColumn.HeaderText = "Alamat_Anggota";
            this.alamatAnggotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatAnggotaDataGridViewTextBoxColumn.Name = "alamatAnggotaDataGridViewTextBoxColumn";
            this.alamatAnggotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaAnggotaDataGridViewTextBoxColumn
            // 
            this.namaAnggotaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Anggota";
            this.namaAnggotaDataGridViewTextBoxColumn.HeaderText = "Nama_Anggota";
            this.namaAnggotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaAnggotaDataGridViewTextBoxColumn.Name = "namaAnggotaDataGridViewTextBoxColumn";
            this.namaAnggotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorAnggotaDataGridViewTextBoxColumn
            // 
            this.nomorAnggotaDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Anggota";
            this.nomorAnggotaDataGridViewTextBoxColumn.HeaderText = "Nomor_Anggota";
            this.nomorAnggotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorAnggotaDataGridViewTextBoxColumn.Name = "nomorAnggotaDataGridViewTextBoxColumn";
            this.nomorAnggotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(289, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Anggota Baru";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_Login_Binding.Properties.Resources.Logo_Pemuda_Pancasila_PNG_Warna;
            this.pictureBox1.Location = new System.Drawing.Point(210, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(293, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pemuda Pancasila";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exercise_Login_Binding.Properties.Resources.back_12955;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewPP);
            this.panel1.Location = new System.Drawing.Point(5, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 367);
            this.panel1.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(953, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form4";
            this.Text = "Tabel Anggota";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anggotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemudaPancasilaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemudaPancasilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pemudaPancasilaDataSetBindingSource;
        private PemudaPancasilaDataSet pemudaPancasilaDataSet;
        private System.Windows.Forms.BindingSource anggotaBindingSource;
        private PemudaPancasilaDataSetTableAdapters.AnggotaTableAdapter anggotaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatAnggotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}