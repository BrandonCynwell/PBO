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
    public partial class Fruipedia : Form
    {
        public Fruipedia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Greeting_Next_Click(object sender, EventArgs e)
        {
            using (var db = new FruipediaLink())
            {
                var data = from fruit in db.fruits where fruit.Nama == textBox2.Text select fruit;
                foreach (var item in data)
                {
                    textBox1.Text = item.Artikel;
                }
            }
        }

        private void Greeting_Close_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
        }
    }
}
