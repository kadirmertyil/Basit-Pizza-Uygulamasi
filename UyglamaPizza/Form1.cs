using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UyglamaPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanıcıadi = txtkullanıcıadı.Text;
            int sifre = Convert.ToInt32(txtsifre.Text);
            if (kullanıcıadi == "kadir" && sifre == 1234) 
            {
                Form2 yeni = new Form2();
                this.Hide();
                yeni.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı ve şifre yanlış");
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkullanıcıadı.Clear();
            txtsifre.Clear();
        }

        private void btnsifresiz_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            this.Hide();
            yeni.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
