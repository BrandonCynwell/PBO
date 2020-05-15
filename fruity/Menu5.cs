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
    public partial class Menu5 : Form
    {
        public Menu5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profil main = new Profil();
            main.Show();
        }

        private void Greeting_Close_Click(object sender, EventArgs e)
        {
            Fruitips main = new Fruitips();
            main.Show();
            this.Hide();
        }
    }
}
