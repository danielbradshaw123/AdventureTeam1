using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure2
{
    public partial class Location6 : Form
    {
        public Location6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameController.ShowSubform(new Location2());
        }

        private void Location1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Location9 = new Location9();
            this.Close();
            Location9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Location7 = new Location7();
            this.Close();
            Location7.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Location8 = new Location8();
            this.Close();
            Location8.Show();
        }
    }
}
