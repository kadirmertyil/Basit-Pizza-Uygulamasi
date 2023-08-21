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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadres.Clear();
            txttelefon.Clear();
            lbltutar.Text = "";
            cmbiçecek.Text = "";
            cmbpizza.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstad.Items.Clear();
            lstadres.Items.Clear();
            lstiçecek.Items.Clear();
            lsttel.Items.Clear();
            lsttip.Items.Clear();
        }
        private void cmbiçecek_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
           string boy = cmbpizza.Text;
            int fiyat = 0;
            string içecek = cmbiçecek.Text;
            lstad.Items.Add(txtad.Text);
            lstadres.Items.Add(txtadres.Text);
            lstiçecek.Items.Add(cmbiçecek.Text);
            lsttel.Items.Add(txttelefon.Text);
            lsttip.Items.Add(cmbpizza.Text);
            switch (içecek)
            {
                case "Salgam":
                    fiyat += 4;
                    break;
                case "Ayran":
                    fiyat += 4;
                    break;
                case "Cola":
                    fiyat += 6;
                    break;
                default:
                    MessageBox.Show("S Seçim!!!");
                    break;
            }
            switch (boy)
            {
                case "Kucuk":
                    fiyat += 10;
                    break;
                case "Orta":
                    fiyat += 15;
                    break;
                case "Buyuk":
                    fiyat += 20;
                    break;
                default:
                    MessageBox.Show("S Seçim!!");
                    break;
            }
            if (cmbpizza.Text == "")
            {
                MessageBox.Show("Hatalı Seçim!!");
            }
            lbltutar.Text = fiyat.ToString();
            lsttutar.Items.Add(fiyat);

        }
        //Yapan Kadir Mert Yıldız
        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
