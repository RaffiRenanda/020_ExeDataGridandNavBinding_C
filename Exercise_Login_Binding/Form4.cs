using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Login_Binding
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pemudaPancasilaDataSet.Anggota' table. You can move, or remove it, as needed.
            this.anggotaTableAdapter.Fill(this.pemudaPancasilaDataSet.Anggota);

        }

        private void dataGridViewPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            int baris = int.Parse(e.RowIndex.ToString());
            
            string kiriman, kiriman1, kiriman2, kiriman3, kiriman4;
            kiriman = dataGridViewPP[0, baris].Value.ToString();
            kiriman1 = dataGridViewPP[1, baris].Value.ToString();
            kiriman2 = dataGridViewPP[2, baris].Value.ToString();
            kiriman3 = dataGridViewPP[3, baris].Value.ToString();
            kiriman4 = dataGridViewPP[4, baris].Value.ToString();
            Form5 f5 = new Form5(kiriman, kiriman1, kiriman2, kiriman3, kiriman4);

            f5.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

            
        }
    }
}
