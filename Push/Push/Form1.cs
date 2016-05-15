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
    public partial class Form1 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

         int moves = 0;
        private int _x;
        private int _y;

        private int _z;
        private int _t;

        private Position _objPosition;

        public Form1()
        {
            InitializeComponent();
            _x = 70;
            _y = 70;

            _z = 160;
            _t = 130;
            _objPosition = Position.Down;
            
           
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Bitmap man = new Bitmap(Push.Properties.Resources.man);
            System.Drawing.Bitmap ball = new Bitmap(Push.Properties.Resources.ball2);
            e.Graphics.DrawImage(man, _x, _y, 30, 30);
            e.Graphics.DrawImage(ball, _z, _t, 30, 30);
            
        }
       

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)     //ako odi levo
            {
                _objPosition = Position.Left;

                if ((_x == 190 && _y == 70) || (_x == 160 && _y == 100) || (_x == 250 && _y == 100) ||     //ako naide na prechka
                    (_x == 310 && _y == 100) || (_x == 250 && _y == 130) || (_x == 160 && _y == 160) ||    //ne se dvizi
                    (_x == 280 && _y == 160) || (_x == 280 && _y == 220) || (_x == 160 && _y == 190))
                { 
                }

                else if (_y >= 70 && _x > 70)
                {
                    _x -= 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }//ako e vo granicite, se dvizi
                    


              
                if (_x == _z && _y == _t)     //koga kje shutne
                {
                    if ((_z == 190 && _t == 70) || (_z == 160 && _t == 100) || (_z == 250 && _t == 100) ||
                   (_z == 310 && _t == 100) || (_z == 250 && _t == 130) || (_z == 160 && _t == 160) ||
                   (_z == 280 && _t == 160) || (_z== 280 && _t == 220) || (_z == 160 && _t == 190))
                    {
                        _x += 30;    //ako ne moze topkata da se dvizi, choveceto se vrakja
                    }
                    else if ((_t >= 70 && _z > 70) )
                    {
                        
                        _z -= 30;      //ako e vo red , se pridzvizuva topkata
                        
                    }
                    else _x += 30; 
                
                }



            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;

                if ((_x == 130 && _y == 70) || (_x == 70 && _y == 100) || (_x == 190 && _y == 100)
                    || (_x == 250 && _y == 100) || (_x == 190 && _y == 130) || (_x == 100 && _y == 160)
                    || (_x == 190 && _y == 160) || (_x == 220 && _y == 220))
                { 
                
                }

                else if (_y >= 70 && _x < 310)
                { 
                    _x += 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_z == 130 && _t == 70) || (_z == 70 && _t == 100) || (_z == 190 && _t == 100)
                   || (_z == 250 && _t == 100) || (_z == 190 && _t == 130) || (_z == 100 && _t == 160)
                   || (_z == 190 && _t == 160) || (_z == 220 && _t == 220)) 
                    {
                        _x -= 30;
                    }
                    
                    else if (_t >= 70 && _z < 310){
                        _z += 30;
                    }
                        

                    else _x -= 30;
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;

                if ((_x == 160 && _y == 100) || (_x == 100 && _y == 130) || (_x == 130 && _y == 130) ||
                   (_x == 220 && _y == 190) || (_x == 250 && _y == 190) || (_x == 70 && _y == 220)
                    || (_x == 100 && _y == 220) || (_x == 130 && _y == 220) || (_x == 280 && _y == 130))
                { }
                else if (_y > 70){
                    _y -= 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }
                

                if (_x == _z && _y == _t)
                {

                    if ((_z == 160 && _t == 100) || (_z == 100 && _t == 130) || (_z == 130 && _t == 130) ||
                       (_z == 220 && _t == 190) || (_z == 250 && _t == 190) || (_z == 70 && _t == 220)
                        || (_z == 100 && _t == 220) || (_z == 130 && _t == 220) || (_z == 280 && _t == 130))
                        _y += 30;

                    else if (_t > 70)
                    {
                        _t -= 30;
                    }
                        

                    else _y += 30;
                }
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
             if ((_x ==100  && _y ==70 ) || (_x ==130  && _y ==70 ) || (_x == 220 && _y == 70)
                 || (_x == 280  && _y == 70 ) || (_x ==130  && _y == 130) || (_x ==250  && _y ==130 )
                 || (_x ==70  && _y ==160 ) || (_x ==100  && _y ==160 ) || (_x ==250  && _y ==190 ) ||
                 (_x==310 && _y == 220))
                { 
                }
             else if ((_y < 220) || (_z == 280 && _y == 220)) {
                 _y += 30;
                 moves++;
                 String pom = "Moves: " + moves;
                 score.Text = pom;
             }
                

             if (_x == _z && _y == _t)
             {
                 if ((_z == 100 && _t == 70) || (_z == 130 && _t == 70) || (_z == 220 && _t == 70)
                 || (_z == 280 && _t == 70) || (_z == 130 && _t == 130) || (_z == 250 && _t == 130)
                 || (_z == 70 && _t == 160) || (_z == 100 && _t == 160) || (_z == 250 && _t == 190))
                 {
                     _y -= 30;
                 }

                 else if ((_t < 220 ) || (_z>=280 && _t>=220) )
                 {
                     _t += 30;
                 }
                     

                 else _y -= 30;
             }

             if (_z == 310 && _t == 250)
             {
                 pictureBox66.Visible = false;
                 label.Visible = true;
                 String pom = "Moves: "+moves;
                 score.Text = pom;
                 GlobalClass.GlobalVar += moves;
                 btnNext.Enabled = true;
                 
             }
            }
            Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 level2 = new Form2();
            level2.Show();
            this.Hide();
            
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Restart Game!",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 forma = new Form1();
                forma.Show();
                this.Hide();
            }
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit!",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            Start_levels sl = new Start_levels();
            sl.Show();
            this.Hide();
        }

    }
}
