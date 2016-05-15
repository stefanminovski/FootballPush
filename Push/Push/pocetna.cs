using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Push
{
    public partial class pocetna : Form


    {
        public pocetna()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start_levels sl = new Start_levels();
            sl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            btnInstructions.Visible = false;
            btnStart.Visible = false;
            button4.Visible = false;
            button7.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MinimumSize = new Size(1240, 780);
            this.MaximumSize = new Size(1240, 780);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            btnInstructions.Visible = true;
            btnStart.Visible = true;
            button4.Visible = true;
            button7.Visible = false;
        }


        private void pocetna_Load_1(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1240, 780);
            this.MaximumSize = new Size(1240, 780);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Score s = new Score();
            s.Show();
            this.Hide();
        }
    }
}
