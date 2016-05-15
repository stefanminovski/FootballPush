using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Push
{
    public partial class Form3 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        SoundPlayer sp;
        int moves = 0;
        int golovi = 0;
        int timeLeft = 30;
        bool znamence = false;
        bool znamence1 = false;
        bool znamence2 = false;
        private int _x;
        private int _y;

        private int _a;
        private int _b;

        private int _z;
        private int _t;

        private int _c;
        private int _d;

        private int b1;
        private int b2;

        private int b3;
        private int b4;

        private int b5;
        private int b6;

        private int b7;
        private int b8;

        private int b9;
        private int b10;


        private Position _objPosition;
        FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();

        public Form3()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
           
            _x = 130;
            _y = 220;

            _z = 130;
            _t = 160;

            _a = 160;
            _b = 220;

            _c = 250;
            _d = 220;

            b1 = 160;
            b2 = 100;

            b3 = 100;
            b4 = 100;

            b5 = 130;
            b6 = 130;

            b7 = 40;
            b8 = 40;

            b9 = 40;
            b10 = 40;
            _objPosition = Position.Down;

        }

        

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Bitmap man = new Bitmap(Push.Properties.Resources.man);
            System.Drawing.Bitmap ball = new Bitmap(Push.Properties.Resources.ball2);
            System.Drawing.Bitmap ball2 = new Bitmap(Push.Properties.Resources.ball2);
            System.Drawing.Bitmap ball3 = new Bitmap(Push.Properties.Resources.ball2);
            e.Graphics.DrawImage(man, _x, _y, 30, 30);
            e.Graphics.DrawImage(ball, _a, _b, 30, 30);
            e.Graphics.DrawImage(ball2, _z, _t, 30, 30);
            e.Graphics.DrawImage(ball3, _c, _d, 30, 30);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                
                _objPosition = Position.Left;

                if ((_x == 160 && _y == 70) || (_x == 250 && _y == 70) || (_x == 250 && _y == 130) ||
                    (_x == 250 && _y == 160) || (_x == 190 && _y == 190) || (_x == 130 && _y == 160) ||
                    (_x == 190 && _y == 250) || (_x == b1 && _y == b2) || (_x == b7 && _y == b8))
                {}

                else if (_y >= 70 && _x > 70)
                {
                    _x -= 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)     
                {
                    if ((_x == 160 && _y == 70) || (_x == 250 && _y == 70) || (_x == 250 && _y == 130) ||
                    (_x == 250 && _y == 160) || (_x == 190 && _y == 190) || (_x == 130 && _y == 160) ||
                    (_x == 190 && _y == 250) || (_x == b1 && _y == b2) || (_x == b7 && _y == b8))
                    {
                        _x += 30;    
                    }
                    else if ((_t >= 70 && _z > 70))
                    {

                        _z -= 30;      //ako e vo red , se pridzvizuva topkata

                    }
                    else _x += 30;

                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 160 && _y == 70) || (_x == 250 && _y == 70) || (_x == 250 && _y == 130) ||
                    (_x == 250 && _y == 160) || (_x == 190 && _y == 190) || (_x == 130 && _y == 160) ||
                    (_x == 190 && _y == 250) || (_x == b1 && _y == b2) || (_x == b7 && _y == b8))
                    {
                        _x += 30;
                    }
                    else if ((_b >= 70 && _a > 70))
                    {

                        _a -= 30;

                    }
                    else _x += 30;
                }

                if (_x == _c && _y == _d)
                {
                    if ((_x == 160 && _y == 70) || (_x == 250 && _y == 70) || (_x == 250 && _y == 130) ||
                    (_x == 250 && _y == 160) || (_x == 190 && _y == 190) || (_x == 130 && _y == 160) ||
                    (_x == 190 && _y == 250) || (_x == b1 && _y == b2) || (_x == b7 && _y == b8))
                    {
                        _x += 30;
                    }
                    else if ((_d >= 70 && _c > 70))
                    {

                        _c -= 30;

                    }
                    else _x += 30;
                }

               
                    if (_a == _z && _b == _t)
                    {
                        _z += 30;           //ako topkite se edna do druga 
                        _x += 30;
                    }

                    if (_c == _z && _d == _t)
                    {
                        _z += 30;           //ako topkite se edna do druga 
                        _x += 30;
                    }
                    if (_a == _c && _b == _d)
                    {
                        _c += 30;           //ako topkite se edna do druga 
                        _x += 30;
                    }

                if ((_x != 160 || _y != 220) && (_a != 160 || _b != 220))
                {
                    b1 = 40; b2 = 40; b3 = 40; b4 = 40; b5 = 40; b6 = 40;
                    b7 = 190; b8 = 220; b9 = 130; b10 = 220;
                    pictureBox43.Location = new Point(160, 220);
                }
            }

            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;

                if ((_x == 100 && _y == 70) || (_x == 190 && _y == 70) || (_x == 190 && _y == 130) ||
                    (_x == 130 && _y == 160) || (_x == 130 && _y == 190) || (_x == 130 && _y == 250) ||
                    (_x == b3 && _y == b4) || (_x == b9 && _y == b10))
                { }

                else if (_y >= 70 && _x < 280)
                {
                    _x += 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 100 && _y == 70) || (_x == 190 && _y == 70) || (_x == 190 && _y == 130) ||
                    (_x == 130 && _y == 160) || (_x == 130 && _y == 190) || (_x == 130 && _y == 250) ||
                    (_x == b3 && _y == b4) || (_x == b9 && _y == b10))
                    {
                        _x -= 30;
                    }

                    else if (_t >= 70 && _z < 280)
                    {
                        _z += 30;
                    }
                    else
                        _x -= 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 100 && _y == 70) || (_x == 190 && _y == 70) || (_x == 190 && _y == 130) ||
                    (_x == 130 && _y == 160) || (_x == 130 && _y == 190) || (_x == 130 && _y == 250) ||
                    (_x == b3 && _y == b4) || (_x == b9 && _y == b10))
                    {
                        _x -= 30;
                    }

                    else if (_b >= 70 && _a < 280)
                    {
                        _a += 30;
                    }
                    else
                        _x -= 30;
                }

                if (_x == _c && _y == _d)
                {
                    if ((_x == 100 && _y == 70) || (_x == 190 && _y == 70) || (_x == 190 && _y == 130) ||
                    (_x == 130 && _y == 160) || (_x == 130 && _y == 190) || (_x == 130 && _y == 250) ||
                    (_x == b3 && _y == b4) || (_x == b9 && _y == b10))
                    {
                        _x -= 30;
                    }

                    else if (_d >= 70 && _c < 280)
                    {
                        _c += 30;
                    }
                    else
                        _x -= 30;
                }


                if (_a == _z && _b == _t)
                {
                    _z -= 30;
                    _x -= 30;
                }

                if (_c == _z && _d == _t)
                {
                    _z -= 30;           //ako topkite se edna do druga 
                    _x -= 30;
                }
                if (_a == _c && _b == _d)
                {
                    _c -= 30;           //ako topkite se edna do druga 
                    _x -= 30;
                }

                if ((_x != 160 || _y != 220) && (_a != 160 || _b != 220))
                {
                    b1 = 40; b2 = 40; b3 = 40; b4 = 40; b5 = 40; b6 = 40;
                    b7 = 190; b8 = 220; b9 = 130; b10 = 220;
                    pictureBox43.Location = new Point(160, 220);
                }
            }

            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;

                if ((_x == 220 && _y == 100) || (_x == 70 && _y == 190) || (_x == 100 && _y == 190) ||
                    (_x == 160 && _y == 220) || (_x == 190 && _y == 190) || (_x == 220 && _y == 190) ||
                    (_x == 130 && _y == 100) || (_x == b5 && _y == b6))
                { }

                else if (_y > 70)
                {
                    _y -= 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 220 && _y == 100) || (_x == 70 && _y == 190) || (_x == 100 && _y == 190) ||
                    (_x == 160 && _y == 220) || (_x == 190 && _y == 190) || (_x == 220 && _y == 190) ||
                    (_x == 130 && _y == 100) || (_x == b5 && _y == b6))
                        _y += 30;
                    else if (_t > 70)
                    {
                        _t -= 30;
                    }

                    else _y += 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 220 && _y == 100) || (_x == 70 && _y == 190) || (_x == 100 && _y == 190) ||
                    (_x == 160 && _y == 220) || (_x == 190 && _y == 190) || (_x == 220 && _y == 190) ||
                    (_x == 130 && _y == 100) || (_x == b5 && _y == b6))
                        _y += 30;
                    else if (_b > 70)
                    {
                        _b -= 30;
                    }

                    else _y += 30;
                }

                if (_x == _c && _y == _d)
                {
                    if ((_x == 220 && _y == 100) || (_x == 70 && _y == 190) || (_x == 100 && _y == 190) ||
                    (_x == 160 && _y == 220) || (_x == 190 && _y == 190) || (_x == 220 && _y == 190) ||
                    (_x == 130 && _y == 100) || (_x == b5 && _y == b6))
                        _y += 30;
                    else if (_d > 70)
                    {
                        _d -= 30;
                    }

                    else _y += 30;
                }

                if (_a == _z && _b == _t)
                {
                    _t += 30;
                    _y += 30;
                }

                if (_c == _z && _d == _t)
                {
                    _t += 30;           //ako topkite se edna do druga 
                    _y += 30;
                }
                if (_a == _c && _b == _d)
                {
                    _d += 30;           //ako topkite se edna do druga 
                    _y += 30;
                }

                if ((_x != 160 || _y != 220) && (_a != 160 || _b != 220))
                {
                    b1 = 40; b2 = 40; b3 = 40; b4 = 40; b5 = 40; b6 = 40;
                    b7 = 190; b8 = 220; b9 = 130; b10 = 220;
                    pictureBox43.Location = new Point(160, 220);
                }


            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;

                if ((_x == 70 && _y == 130) || (_x == 100 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 220 && _y == 100) || (_x == 160 && _y == 220))
                { }

                else if ((_y < 250) || (_z == 250 && _y == 250))
                {
                    _y += 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 70 && _y == 130) || (_x == 100 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 220 && _y == 100) || (_x == 160 && _y == 220))
                    {
                        _y -= 30;
                    }

                    else if ((_y <= 250) || (_z == 250 && _y == 250))
                    {
                        _t += 30;
                    }

                    else _y -= 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 70 && _y == 130) || (_x == 100 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 220 && _y == 100) || (_x == 160 && _y == 220))
                    {
                        _y -= 30;
                    }

                    else if ((_y <= 250) || (_z == 250 && _y == 250))
                    {
                        _b += 30;
                    }

                    else _y -= 30;
                }

                if (_x == _c && _y == _d)
                {
                    if ((_x == 70 && _y == 130) || (_x == 100 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 220 && _y == 100) || (_x == 160 && _y == 220))
                    {
                        _y -= 30;
                    }

                    else if ((_y <= 250) || (_c == 250 && _y == 250))
                    {
                        _d += 30;
                    }

                    else _y -= 30;
                }

                if (_a == _z && _b == _t)
                {
                    _t -= 30;
                    _y -= 30;
                }

                if (_c == _z && _d == _t)
                {
                    _t -= 30;           //ako topkite se edna do druga 
                    _y -= 30;
                }
                if (_a == _c && _b == _d)
                {
                    _d -= 30;           //ako topkite se edna do druga 
                    _y -= 30;
                }

                if ((_x != 160 || _y != 220) && (_a != 160 || _b != 220))
                {
                    b1 = 40; b2 = 40; b3 = 40; b4 = 40; b5 = 40; b6 = 40;
                    b7 = 190; b8 = 220; b9 = 130; b10 = 220;
                    pictureBox43.Location = new Point(160, 220);
                }
            }


            if (((_z == 100 && _t == 280)||(_z == 130 && _t == 280)) && znamence == false)
            {
                golovi++;
                znamence = true;
                if (golovi == 3)
                {
                    label.Visible = true;
                    timerRefresh.Stop();
                    GlobalClass.GlobalVar += moves;
                    EnterName enter = new EnterName();
                    enter.Show();
                    
                }
                _z = 160;
                _t = 280;
                String pom = "Moves: " + moves;
                score.Text = pom;
            }

            if (((_a == 100 && _b == 280) || (_a == 130 && _b == 280)) && znamence1 == false)
            {
                golovi++;
                znamence1 = true;
                if (golovi == 3)
                {
                    label.Visible = true;
                    timerRefresh.Stop();
                    GlobalClass.GlobalVar += moves;
                    EnterName enter = new EnterName();
                    enter.Show();
                    
                }
                _a = 190;
                _b = 280;
                String pom = "Moves: " + moves;
                score.Text = pom;
            }

            if (((_c == 100 && _d == 280) || (_c == 130 && _d == 280)) && znamence2 == false)
            {
                golovi++;
                znamence2 = true;
                if (golovi == 3)
                {
                    label.Visible = true;
                    timerRefresh.Stop();
                    GlobalClass.GlobalVar += moves;
                    EnterName enter = new EnterName();
                    enter.Show();
                    
                }
                _c = 220;
                _d = 280;
                String pom = "Moves: " + moves;
                score.Text = pom;
            }

            Invalidate();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            pbTime.ForeColor = Color.Green;
            if (timeLeft > 0)
            {
                timeLeftLabel.Text = timeLeft + " seconds";
                timeLeft = timeLeft - 1;
                pbTime.Value = 30-timeLeft;
                if (timeLeft < 5)
                {
                    pbTime.ForeColor = Color.Red;
                }
            }
            else
            {
                this.timerRefresh.Stop();
                label1.Text = "Time's up!";
                timeLeftLabel.Visible = false;
                DialogResult dialogResult = MessageBox.Show("Time's up. Restart game?", "Sorry!", 
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Form3 forma = new Form3();
                    forma.Show();
                    this.Hide();
                    timeLeft = 30;                   
                    timerRefresh.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
                this.Enabled = false;
                
            }
            
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            timerRefresh.Stop();
            timerRefresh.Dispose();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit!",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Restart Game!",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timerRefresh.Stop();
                Form3 forma = new Form3();
                forma.Show();
                this.Close();
                
                
                timeLeft = 30;
                
            }
            
            
        }

        

       
        private void pictureBox67_Click_1(object sender, EventArgs e)
        {
            Start_levels sl = new Start_levels();
            sl.Show();
            timerRefresh.Stop();
            this.Hide();
        }


        
    }
}
