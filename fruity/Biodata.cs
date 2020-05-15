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
    public partial class Biodata : Form
    {
        
        public enum Mode { Insert }
        Mode mode;
        public Table table;

        public Biodata()
        {
            InitializeComponent();
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("Pria");
            collection.Add("Wanita");
            this.domainUpDown1.Text = "Pria";
            mode = Mode.Insert;
        }

        private void TambahData()
        {
            if (textBox1.Text != "" && domainUpDown1.Text != "" && numericUpDown1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                using (var db = new BiodataLink())
                {
                    table = new Table
                    {

                        Nama = textBox1.Text,
                        Umur = Convert.ToInt32(numericUpDown1.Text),
                        Gender = domainUpDown1.Text,
                        Email = textBox4.Text,
                        Nomer = textBox5.Text,
                        
                    };
                    db.Tables.Add(table);
                    db.SaveChanges();


                    MessageBox.Show("Data diri telah ditambahkan ke profil ");
                    Close();

                    Home main = new Home();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Semua harus diisi");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Greeting_Close_Click(object sender, EventArgs e)
        {
            Greeting main = new Greeting();
            main.Show();
            this.Hide();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Biodata_Next_Click(object sender, EventArgs e)
        {

            if (mode == Mode.Insert) {
                TambahData();
            }
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Biodata_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
