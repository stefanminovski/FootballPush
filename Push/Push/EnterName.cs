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
    public partial class EnterName : Form
    {
        public Player player { get; set; }

        public EnterName()
        {
            InitializeComponent();
            player = new Player();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Enter your name!");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.name = textBox1.Text;
            player.moves = GlobalClass.GlobalVar;
            Score score = new Score();
            score.Show();
            this.Close();
        }

        private void EnterName_Load(object sender, EventArgs e)
        {
            label3.Text = GlobalClass.GlobalVar.ToString();
        }


    }
}
