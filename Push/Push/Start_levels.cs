using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Push
{
    public partial class Start_levels : Form
    {
        public Start_levels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pocetna prva = new pocetna();
            prva.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 level1 = new Form1();
            level1.Show();
            this.Hide();
        }

        private void Start_levels_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 level2 = new Form2();
            level2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 level3 = new Form3();
            level3.Show();
            this.Hide();
        }

        private void Start_levels_Load_1(object sender, EventArgs e)
        {

        }
    }
}
