using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Push
{
    public partial class Score : Form
    {
        EnterName en;
        public Score()
        {
            InitializeComponent();
            en = new EnterName();
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            pocetna p = new pocetna();
            p.Show();
            this.Hide();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(en.player);    
        }
    }
}
