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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Fruitips_Click(object sender, EventArgs e)
        {
            Fruitips main = new Fruitips();
            main.Show();
            this.Hide();
        }

        private void Button_Fruipedia_Click(object sender, EventArgs e)
        {
            Menu1 main = new Menu1();
            main.Show();
            this.Hide();
        }

        private void Button_Fruiorder_Click(object sender, EventArgs e)
        {
            Fruiorder main = new Fruiorder();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            Fruipedia main = new Fruipedia();
            main.Show();
            this.Hide();
        }

        private void FRUITIPS_Click(object sender, EventArgs e)
        {
            Fruitips main = new Fruitips();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fruiorder main = new Fruiorder();
            main.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
            
        }
    }
}
