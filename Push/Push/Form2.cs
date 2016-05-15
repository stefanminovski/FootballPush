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
    public partial class Form2 : Form
    {
        enum Position
        {
            Left, Right, Up, Down
        }

        int moves = 0;
        int golovi = 0;
        bool znamence = false;
        bool znamence1 = false; 
        private int _x;
        private int _y;

        private int _a;
        private int _b;

        private int _z;
        private int _t;

        private Position _objPosition;

        public Form2()
        {
            InitializeComponent();
            _x = 130;
            _y = 70;

            _a = 190;
            _b = 190;

            _z = 160;
            _t = 130;
            _objPosition = Position.Down;

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Bitmap man = new Bitmap(Push.Properties.Resources.man);
            System.Drawing.Bitmap ball = new Bitmap(Push.Properties.Resources.ball2);
            System.Drawing.Bitmap ball2 = new Bitmap(Push.Properties.Resources.ball2);
            e.Graphics.DrawImage(man, _x, _y, 30, 30);
            e.Graphics.DrawImage(ball, _a, _b, 30, 30);
            e.Graphics.DrawImage(ball2, _z, _t, 30, 30);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)     //ako odi levo
            {
                _objPosition = Position.Left;

                if ((_x == 130 && _y == 70) || (_x == 310 && _y == 100) || (_x == 100 && _y == 160)
                    || (_x == 220 && _y == 160) || (_x == 310 && _y == 160) || (_x == 190 && _y == 220)
                    || (_x == 190 && _y == 250) || (_x == 190 && _y == 280) || (_x == 310 && _y == 250))
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
                    if ((_x == 130 && _y == 70) || (_x == 310 && _y == 100) || (_x == 100 && _y == 160)
                    || (_x == 220 && _y == 160) || (_x == 310 && _y == 160) || (_x == 190 && _y == 220)
                    || (_x == 190 && _y == 250) || (_x == 190 && _y == 280) || (_x == 310 && _y == 250))
                    {
                        _x += 30;    //ako ne moze topkata da se dvizi, choveceto se vrakja
                    }
                    else if ((_t >= 70 && _z > 70))
                    {

                        _z -= 30;      //ako e vo red , se pridzvizuva topkata

                    }
                    else _x += 30;

                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 130 && _y == 70) || (_x == 310 && _y == 100) || (_x == 100 && _y == 160)
                    || (_x == 220 && _y == 160) || (_x == 310 && _y == 160) || (_x == 190 && _y == 220)
                    || (_x == 190 && _y == 250) || (_x == 190 && _y == 280) || (_x == 310 && _y == 250))
                    {
                        _x += 30;
                    }
                    else if ((_b >= 70 && _a > 70))
                    {

                        _a -= 30;

                    }
                    else _x += 30;
                }

                if (_a == _z && _b == _t)
                {
                    _z += 30;           //ako topkite se edna do druga 
                    _x += 30;
                }



            }

            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;

                if ((_x == 130 && _y == 100) || (_x == 310 && _y == 130) || (_x == 310 && _y == 160) ||
                    (_x == 220 && _y == 160) || (_x == 130 && _y == 160) || (_x == 70 && _y == 220) ||
                    (_x == 130 && _y == 250) || (_x == 130 && _y == 280) || (_x == 220 && _y == 280) ||
                    (_x == 250 && _y == 250))
                {

                }
                else if (_y >= 70 && _x < 340)
                {
                    _x += 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 130 && _y == 100) || (_x == 310 && _y == 130) || (_x == 310 && _y == 160) ||
                    (_x == 220 && _y == 160) || (_x == 130 && _y == 160) || (_x == 70 && _y == 220) ||
                    (_x == 130 && _y == 250) || (_x == 130 && _y == 280) || (_x == 220 && _y == 280) ||
                    (_x == 250 && _y == 250))
                    {
                        _x -= 30;
                    }

                    else if (_t >= 70 && _z < 340)
                    {
                        _z += 30;
                    }
                    else
                        _x -= 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 130 && _y == 100) || (_x == 310 && _y == 130) || (_x == 310 && _y == 160) ||
                    (_x == 220 && _y == 160) || (_x == 130 && _y == 160) || (_x == 70 && _y == 220) ||
                    (_x == 130 && _y == 250) || (_x == 130 && _y == 280) || (_x == 220 && _y == 280) ||
                    (_x == 250 && _y == 250))
                    {
                        _x -= 30;
                    }

                    else if (_b >= 70 && _a < 340)
                    {
                        _a += 30;
                    }
                    else
                        _x -= 30;
                }


                if (_a == _z && _b == _t)
                {
                    _z -= 30;
                    _x -= 30;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;

                if ((_x == 70 && _y == 100) || (_x == 100 && _y == 100) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 280 && _y == 130) || (_x == 70 && _y == 190) ||
                    (_x == 160 && _y == 190) || (_x == 190 && _y == 190) || (_x == 250 && _y == 190) ||
                    (_x == 280 && _y == 190) || (_x == 340 && _y == 190) || (_x == 100 && _y == 250) ||
                    (_x == 130 && _y == 250) || (_x == 220 && _y == 130) || (_x == 250 && _y == 130))
                {

                }
                else if (_y > 70)
                {
                    _y -= 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 70 && _y == 100) || (_x == 100 && _y == 100) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 280 && _y == 130) || (_x == 70 && _y == 190) ||
                    (_x == 160 && _y == 190) || (_x == 190 && _y == 190) || (_x == 250 && _y == 190) ||
                    (_x == 280 && _y == 190) || (_x == 340 && _y == 190) || (_x == 100 && _y == 250) ||
                    (_x == 130 && _y == 250))
                        _y += 30;
                    else if (_t > 70)
                    {
                        _t -= 30;
                    }

                    else _y += 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 70 && _y == 100) || (_x == 100 && _y == 100) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 280 && _y == 130) || (_x == 70 && _y == 190) ||
                    (_x == 160 && _y == 190) || (_x == 190 && _y == 190) || (_x == 250 && _y == 190) ||
                    (_x == 280 && _y == 190) || (_x == 340 && _y == 190) || (_x == 100 && _y == 250) ||
                    (_x == 130 && _y == 250))
                        _y += 30;
                    else if (_b > 70)
                    {
                        _b -= 30;
                    }

                    else _y += 30;
                }

                if (_a == _z && _b == _t)
                {
                    _t += 30;
                    _y += 30;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
                if ((_x == 160 && _y == 70) || (_x == 190 && _y == 70) || (_x == 280 && _y == 70) ||
                    (_x == 340 && _y == 100) || (_x == 70 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 250 && _y == 130) || (_x == 280 && _y == 130) ||
                    (_x == 100 && _y == 190) || (_x == 130 && _y == 190) || (_x == 160 && _y == 190) ||
                    (_x == 280 && _y == 220) || (_x == 250 && _y == 250) || (_x == 310 && _y == 250) ||
                    (_x == 340 && _y == 250) || (_x == 220 && _y == 70) || (_x == 250 && _y == 70))
                { }
                else if ((_y < 280) || (_z == 310 && _y == 280))
                {
                    _y += 30;
                    moves++;
                    String pom = "Moves: " + moves;
                    score.Text = pom;
                }

                if (_x == _z && _y == _t)
                {
                    if ((_x == 160 && _y == 70) || (_x == 190 && _y == 70) || (_x == 280 && _y == 70) ||
                    (_x == 340 && _y == 100) || (_x == 70 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 250 && _y == 130) || (_x == 280 && _y == 130) ||
                    (_x == 100 && _y == 190) || (_x == 130 && _y == 190) || (_x == 160 && _y == 190) ||
                    (_x == 280 && _y == 220) || (_x == 250 && _y == 250) || (_x == 310 && _y == 250) ||
                    (_x == 340 && _y == 250))
                    {
                        _y -= 30;
                    }

                    else if ((_t < 280) || (_z >= 310 && _t >= 280))
                    {
                        _t += 30;
                    }

                    else _y -= 30;
                }

                if (_x == _a && _y == _b)
                {
                    if ((_x == 160 && _y == 70) || (_x == 190 && _y == 70) || (_x == 280 && _y == 70) ||
                    (_x == 340 && _y == 100) || (_x == 70 && _y == 130) || (_x == 160 && _y == 130) ||
                    (_x == 190 && _y == 130) || (_x == 250 && _y == 130) || (_x == 280 && _y == 130) ||
                    (_x == 100 && _y == 190) || (_x == 130 && _y == 190) || (_x == 160 && _y == 190) ||
                    (_x == 280 && _y == 220) || (_x == 250 && _y == 250) || (_x == 310 && _y == 250) ||
                    (_x == 340 && _y == 250))
                    {
                        _y -= 30;
                    }

                    else if ((_b < 280) || (_a >= 310 && _b >= 280))
                    {
                        _b += 30;
                    }

                    else _y -= 30;
                }

                if (_a == _z && _b == _t)
                {
                    _t -= 30;
                    _y -= 30;
                }
            }

            if ((_z == 220 && _t == 100) && znamence == false)
            {
                golovi++;
                _z = 250;
                _t = 100;
                znamence = true;
                if (golovi == 2)
                {
                    pictureBox66.Visible = false;
                    label.Visible = true;
                    GlobalClass.GlobalVar += moves;
                    btnNext.Enabled = true;
                }
                String pom = "Moves: " + moves;
                score.Text = pom;
            }

            if ((_a == 220 && _b == 100) && znamence1 == false)
            {
                golovi++;
                _a = 250;
                _b = 100;
                znamence1 = true;
                if (golovi == 2)
                {
                    pictureBox66.Visible = false;
                    label.Visible = true;
                    GlobalClass.GlobalVar += moves;
                    btnNext.Enabled = true;
                }
                String pom = "Moves: " + moves;
                score.Text = pom;
            }
            Invalidate();
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Restart Game!",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form2 forma = new Form2();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form3 level3 = new Form3();
            level3.Show();
            this.Hide();
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            Start_levels sl = new Start_levels();
            sl.Show();
            this.Hide();
        }






    }
}
