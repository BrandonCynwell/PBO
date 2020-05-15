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
    public partial class Fruitips : Form
    {
        public Fruitips()
        {
            InitializeComponent();
        }

        private void Greeting_Close_Click(object sender, EventArgs e)
        {
            Home main = new Home();
            main.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu1 main = new Menu1();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu2 main = new Menu2();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu3 main = new Menu3();
            main.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu4 main = new Menu4();
            main.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu5 main = new Menu5();
            main.Show();
            this.Hide();
        }
    }
}
