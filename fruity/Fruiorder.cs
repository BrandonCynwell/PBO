using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruity
{
    public partial class Fruiorder : Form
    {
        public Fruiorder()
        {
            InitializeComponent();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fruitips_Back_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Fruitips_Cari_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && numericUpDown1.Text != "")
            {
                using (var db = new OrderLink())
                {
                    var data = from Pesan in db.Pesans where Pesan.Buah == textBox1.Text select Pesan;
                    foreach (var item in data)
                    {
                        label1.Text = ("Total : " + numericUpDown1.Value * item.Harga);
                    }

                }
            }

            else {
                MessageBox.Show("Isi terlebih dahulu pesanan anda ! ");
              
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OrderLink())
            {
                var data = from Pesan in db.Pesans where Pesan.Buah == textBox1.Text select Pesan;
                foreach (var item in data)
                {
                    MessageBox.Show("----------Pesanan Anda----------\nBuah " + textBox1.Text + "\nJumlah : " + numericUpDown1.Text + "\n" + label1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
        }
    }
}
