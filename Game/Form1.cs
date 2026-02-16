using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        bool start_game = false;
        int hp_number = 5;
        int stars_counter = 0;
        string movement = "stop";
        public Form1()
        {
            InitializeComponent();
        }

        private void left_arrow_btn_Click(object sender, EventArgs e)
        {
            if (start_game == true)
            {
                movement = "left";
            }
        }

        private void right_arrow_btn_Click(object sender, EventArgs e)
        {
            if (start_game == true)
            {
                movement = "right";
            }
        }

        private void top_arrow_btn_Click(object sender, EventArgs e)
        {
            if (start_game == true)
            {
                movement = "top";
            }
        }

        private void buttom_arrow_btn_Click(object sender, EventArgs e)
        {
            if (start_game == true)
            {
                movement = "buttom";
                
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (start_game == false)
            {
                start_game = true;
                timer1.Enabled = true;
                player_img.Left = 128;
                player_img.Top = 326;
                star_1.Visible = false;
                star_2.Visible = false;
                star_3.Visible = false;
                star_4.Visible = false;
                star_5.Visible = false;
                pictureBox100.Visible = true;
                pictureBox99.Visible = true;
                pictureBox98.Visible = true;
                pictureBox97.Visible = true;
                pictureBox96.Visible = true;
                hp_number = 5;
                stars_counter = 0;
                bug_1.Visible = true; bug_1.Left = 38;
                bug_2.Visible = true; bug_2.Left = 128;
                bug_3.Visible = true; bug_3.Left = 218;
                bug_4.Visible = true; bug_4.Left = 398;
                bug_5.Visible = true; bug_5.Left = 398;
                pictureBox90.Visible = true; pictureBox90.Left = 398;
                pictureBox91.Visible = true; pictureBox91.Left = 458;
                pictureBox93.Visible = true; pictureBox93.Left = 38;
                pictureBox94.Visible = true; pictureBox94.Left = 458;
                pictureBox95.Visible = true; pictureBox95.Left = 128;
                MessageBox.Show("[+] Game is started.");
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            if (start_game == true)
            {
                start_game = false;
                timer1.Enabled = false;
                player_img.Left = 128;
                player_img.Top = 326;
                MessageBox.Show("[+] Game is Stopped.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hp_number == 0)
            {
                pictureBox100.Visible = true;
                pictureBox99.Visible = true;
                pictureBox98.Visible = true;
                pictureBox97.Visible = true;
                pictureBox96.Visible = true;
            }

            if (movement == "left")
            {
                player_img.Left += player_img.Width;
                if (player_img.Location.X > 458)
                {
                    player_img.Left -= player_img.Width;
                }
                else if (player_img.Location == pictureBox60.Location || player_img.Location == pictureBox63.Location || player_img.Location == pictureBox59.Location || player_img.Location == pictureBox58.Location || player_img.Location == pictureBox57.Location || player_img.Location == pictureBox56.Location || player_img.Location == pictureBox55.Location || player_img.Location == pictureBox54.Location || player_img.Location == pictureBox76.Location || player_img.Location == pictureBox75.Location || player_img.Location == pictureBox73.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox66.Location || player_img.Location == pictureBox64.Location || player_img.Location == pictureBox80.Location || player_img.Location == pictureBox61.Location || player_img.Location == pictureBox65.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox85.Location || player_img.Location == pictureBox79.Location || player_img.Location == pictureBox78.Location || player_img.Location == pictureBox77.Location)
                {
                    player_img.Left -= player_img.Width;
                }
                else if (player_img.Location == pictureBox86.Location || player_img.Location == pictureBox87.Location || player_img.Location == pictureBox88.Location || player_img.Location == pictureBox89.Location)
                {
                    hp_number -= 1;
                    if (hp_number == 4)
                    {
                        pictureBox100.Visible = false;
                    }
                    else if (hp_number == 3)
                    {
                        pictureBox99.Visible = false;
                    }
                    else if (hp_number == 2)
                    {
                        pictureBox98.Visible = false;
                    }
                    else if (hp_number == 1)
                    {
                        pictureBox97.Visible = false;
                    }
                    else if (hp_number == 0)
                    {
                        pictureBox96.Visible = false;
                    }

                    if (hp_number <= 0)
                    {
                        MessageBox.Show("شما باختید", "باخت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        start_game = false;
                        timer1.Enabled = false;
                    }
                    player_img.Left = 128;
                    player_img.Top = 326;
                }
                else if (player_img.Location == pictureBox90.Location || player_img.Location == pictureBox91.Location || player_img.Location == pictureBox93.Location || player_img.Location == pictureBox94.Location || player_img.Location == pictureBox95.Location)
                {
                    if (hp_number != 5)
                    {
                        if (hp_number == 4)
                        {
                            pictureBox100.Visible = true;
                        }
                        else if (hp_number == 3)
                        {
                            pictureBox99.Visible = true;
                        }
                        else if (hp_number == 2)
                        {
                            pictureBox98.Visible = true;
                        }
                        else if (hp_number == 1)
                        {
                            pictureBox97.Visible = true;
                        }
                        else if (hp_number == 0)
                        {
                            pictureBox96.Visible = true;
                        }
                        if (player_img.Location == pictureBox90.Location)
                        {
                            pictureBox90.Visible = false;
                            pictureBox90.Left += 1;
                        }
                        else if (player_img.Location == pictureBox91.Location)
                        {
                            pictureBox91.Visible = false;
                            pictureBox91.Left += 1;
                        }
                        else if (player_img.Location == pictureBox93.Location)
                        {
                            pictureBox93.Visible = false;
                            pictureBox93.Left += 1;
                        }
                        else if (player_img.Location == pictureBox94.Location)
                        {
                            pictureBox94.Visible = false;
                            pictureBox94.Left += 1;
                        }
                        else if (player_img.Location == pictureBox95.Location)
                        {
                            pictureBox95.Visible = false;
                            pictureBox95.Left += 1;
                        }
                        hp_number += 1;
                    }
                }
                else if (player_img.Location == bug_1.Location || player_img.Location == bug_2.Location || player_img.Location == bug_3.Location || player_img.Location == bug_4.Location || player_img.Location == bug_5.Location)
                {
                    stars_counter += 1;
                    switch (stars_counter)
                    {
                        case 1:
                            star_1.Visible = true;

                            break;
                        case 2:
                            star_2.Visible = true;
                            break;
                        case 3:
                            star_3.Visible = true;
                            break;
                        case 4:
                            star_4.Visible = true;
                            break;
                        case 5:
                            star_5.Visible = true;
                            movement = "stop";
                            MessageBox.Show("آفرین شما برنده شدید و 5 باگ فیکس کردید :)");
                            start_game = false;
                            timer1.Enabled = false;
                            break;
                        default:
                            break;
                    }
                    if (player_img.Location == bug_1.Location)
                    {
                        bug_1.Visible = false;
                        bug_1.Left += 1;
                    }
                    else if (player_img.Location == bug_2.Location)
                    {
                        bug_2.Visible = false;
                        bug_2.Left += 1;
                    }
                    else if (player_img.Location == bug_3.Location)
                    {
                        bug_3.Visible = false;
                        bug_3.Left += 1;
                    }
                    else if (player_img.Location == bug_4.Location)
                    {
                        bug_4.Visible = false;
                        bug_4.Left += 1;
                    }
                    else if (player_img.Location == bug_5.Location)
                    {
                        bug_5.Visible = false;
                        bug_5.Left += 1;
                    }
                }
            }
            else if (movement == "right")
            {
                player_img.Left -= player_img.Width;
                if (player_img.Location.X < 38)
                {
                    player_img.Left += player_img.Width;
                }
                else if (player_img.Location == pictureBox60.Location || player_img.Location == pictureBox63.Location || player_img.Location == pictureBox59.Location || player_img.Location == pictureBox58.Location || player_img.Location == pictureBox57.Location || player_img.Location == pictureBox56.Location || player_img.Location == pictureBox55.Location || player_img.Location == pictureBox54.Location || player_img.Location == pictureBox76.Location || player_img.Location == pictureBox75.Location || player_img.Location == pictureBox73.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox66.Location || player_img.Location == pictureBox64.Location || player_img.Location == pictureBox80.Location || player_img.Location == pictureBox61.Location || player_img.Location == pictureBox65.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox85.Location || player_img.Location == pictureBox79.Location || player_img.Location == pictureBox78.Location || player_img.Location == pictureBox77.Location)
                {
                    player_img.Left += player_img.Width;
                }
                else if (player_img.Location == pictureBox86.Location || player_img.Location == pictureBox87.Location || player_img.Location == pictureBox88.Location || player_img.Location == pictureBox89.Location)
                {
                    hp_number -= 1;
                    if (hp_number == 4)
                    {
                        pictureBox100.Visible = false;
                    }
                    else if (hp_number == 3)
                    {
                        pictureBox99.Visible = false;
                    }
                    else if (hp_number == 2)
                    {
                        pictureBox98.Visible = false;
                    }
                    else if (hp_number == 1)
                    {
                        pictureBox97.Visible = false;
                    }
                    else if (hp_number == 0)
                    {
                        pictureBox96.Visible = false;
                    }

                    if (hp_number <= 0)
                    {
                        MessageBox.Show("شما باختید", "باخت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        start_game = false;
                        timer1.Enabled = false;
                    }
                    player_img.Left = 128;
                    player_img.Top = 326;
                }
                else if (player_img.Location == pictureBox90.Location || player_img.Location == pictureBox91.Location || player_img.Location == pictureBox93.Location || player_img.Location == pictureBox94.Location || player_img.Location == pictureBox95.Location)
                {
                    if (hp_number != 5)
                    {
                        if (hp_number == 4)
                        {
                            pictureBox100.Visible = true;
                        }
                        else if (hp_number == 3)
                        {
                            pictureBox99.Visible = true;
                        }
                        else if (hp_number == 2)
                        {
                            pictureBox98.Visible = true;
                        }
                        else if (hp_number == 1)
                        {
                            pictureBox97.Visible = true;
                        }
                        else if (hp_number == 0)
                        {
                            pictureBox96.Visible = true;
                        }
                        if (player_img.Location == pictureBox90.Location)
                        {
                            pictureBox90.Visible = false;
                            pictureBox90.Left += 1;
                        }
                        else if (player_img.Location == pictureBox91.Location)
                        {
                            pictureBox91.Visible = false;
                            pictureBox91.Left += 1;
                        }
                        else if (player_img.Location == pictureBox93.Location)
                        {
                            pictureBox93.Visible = false;
                            pictureBox93.Left += 1;
                        }
                        else if (player_img.Location == pictureBox94.Location)
                        {
                            pictureBox94.Visible = false;
                            pictureBox94.Left += 1;
                        }
                        else if (player_img.Location == pictureBox95.Location)
                        {
                            pictureBox95.Visible = false;
                            pictureBox95.Left += 1;
                        }
                        hp_number += 1;
                    }
                }
                else if (player_img.Location == bug_1.Location || player_img.Location == bug_2.Location || player_img.Location == bug_3.Location || player_img.Location == bug_4.Location || player_img.Location == bug_5.Location)
                {
                    stars_counter += 1;
                    switch (stars_counter)
                    {
                        case 1:
                            star_1.Visible = true;

                            break;
                        case 2:
                            star_2.Visible = true;
                            break;
                        case 3:
                            star_3.Visible = true;
                            break;
                        case 4:
                            star_4.Visible = true;
                            break;
                        case 5:
                            star_5.Visible = true;
                            movement = "stop";
                            MessageBox.Show("آفرین شما برنده شدید و 5 باگ فیکس کردید :)");
                            start_game = false;
                            timer1.Enabled = false;
                            break;
                        default:
                            break;
                    }
                    if (player_img.Location == bug_1.Location)
                    {
                        bug_1.Visible = false;
                        bug_1.Left += 1;
                    }
                    else if (player_img.Location == bug_2.Location)
                    {
                        bug_2.Visible = false;
                        bug_2.Left += 1;
                    }
                    else if (player_img.Location == bug_3.Location)
                    {
                        bug_3.Visible = false;
                        bug_3.Left += 1;
                    }
                    else if (player_img.Location == bug_4.Location)
                    {
                        bug_4.Visible = false;
                        bug_4.Left += 1;
                    }
                    else if (player_img.Location == bug_5.Location)
                    {
                        bug_5.Visible = false;
                        bug_5.Left += 1;
                    }
                }
            }
            else if (movement == "top")
            {
                player_img.Top -= player_img.Height;
                if (player_img.Location.Y < 38)
                {
                    player_img.Top += player_img.Height;
                }
                else if (player_img.Location == pictureBox60.Location || player_img.Location == pictureBox62.Location || player_img.Location == pictureBox63.Location || player_img.Location == pictureBox59.Location || player_img.Location == pictureBox58.Location || player_img.Location == pictureBox57.Location || player_img.Location == pictureBox56.Location || player_img.Location == pictureBox55.Location || player_img.Location == pictureBox54.Location || player_img.Location == pictureBox76.Location || player_img.Location == pictureBox75.Location || player_img.Location == pictureBox74.Location || player_img.Location == pictureBox73.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox66.Location || player_img.Location == pictureBox64.Location || player_img.Location == pictureBox80.Location || player_img.Location == pictureBox61.Location || player_img.Location == pictureBox65.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox72.Location)
                {
                    player_img.Top += player_img.Height;
                }
                else if (player_img.Location == pictureBox86.Location || player_img.Location == pictureBox87.Location || player_img.Location == pictureBox88.Location || player_img.Location == pictureBox89.Location)
                {
                    hp_number -= 1;
                    if (hp_number == 4)
                    {
                        pictureBox100.Visible = false;
                    }
                    else if (hp_number == 3)
                    {
                        pictureBox99.Visible = false;
                    }
                    else if (hp_number == 2)
                    {
                        pictureBox98.Visible = false;
                    }
                    else if (hp_number == 1)
                    {
                        pictureBox97.Visible = false;
                    }
                    else if (hp_number == 0)
                    {
                        pictureBox96.Visible = false;
                    }

                    if (hp_number <= 0)
                    {
                        MessageBox.Show("شما باختید", "باخت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        start_game = false;
                        timer1.Enabled = false;
                    }
                    player_img.Left = 128;
                    player_img.Top = 326;
                }
                else if (player_img.Location == pictureBox90.Location || player_img.Location == pictureBox91.Location || player_img.Location == pictureBox93.Location || player_img.Location == pictureBox94.Location || player_img.Location == pictureBox95.Location)
                {
                    if (hp_number != 5)
                    {
                        if (hp_number == 4)
                        {
                            pictureBox100.Visible = true;
                        }
                        else if (hp_number == 3)
                        {
                            pictureBox99.Visible = true;
                        }
                        else if (hp_number == 2)
                        {
                            pictureBox98.Visible = true;
                        }
                        else if (hp_number == 1)
                        {
                            pictureBox97.Visible = true;
                        }
                        else if (hp_number == 0)
                        {
                            pictureBox96.Visible = true;
                        }
                        if (player_img.Location == pictureBox90.Location)
                        {
                            pictureBox90.Visible = false;
                            pictureBox90.Left += 1;
                        }
                        else if (player_img.Location == pictureBox91.Location)
                        {
                            pictureBox91.Visible = false;
                            pictureBox91.Left += 1;
                        }
                        else if (player_img.Location == pictureBox93.Location)
                        {
                            pictureBox93.Visible = false;
                            pictureBox93.Left += 1;
                        }
                        else if (player_img.Location == pictureBox94.Location)
                        {
                            pictureBox94.Visible = false;
                            pictureBox94.Left += 1;
                        }
                        else if (player_img.Location == pictureBox95.Location)
                        {
                            pictureBox95.Visible = false;
                            pictureBox95.Left += 1;
                        }
                        hp_number += 1;
                    }
                }
                else if (player_img.Location == bug_1.Location || player_img.Location == bug_2.Location || player_img.Location == bug_3.Location || player_img.Location == bug_4.Location || player_img.Location == bug_5.Location)
                {
                    stars_counter += 1;
                    switch (stars_counter)
                    {
                        case 1:
                            star_1.Visible = true;

                            break;
                        case 2:
                            star_2.Visible = true;
                            break;
                        case 3:
                            star_3.Visible = true;
                            break;
                        case 4:
                            star_4.Visible = true;
                            break;
                        case 5:
                            star_5.Visible = true;
                            movement = "stop";
                            MessageBox.Show("آفرین شما برنده شدید و 5 باگ فیکس کردید :)");
                            start_game = false;
                            timer1.Enabled = false;
                            break;
                        default:
                            break;
                    }
                    if (player_img.Location == bug_1.Location)
                    {
                        bug_1.Visible = false;
                        bug_1.Left += 1;
                    }
                    else if (player_img.Location == bug_2.Location)
                    {
                        bug_2.Visible = false;
                        bug_2.Left += 1;
                    }
                    else if (player_img.Location == bug_3.Location)
                    {
                        bug_3.Visible = false;
                        bug_3.Left += 1;
                    }
                    else if (player_img.Location == bug_4.Location)
                    {
                        bug_4.Visible = false;
                        bug_4.Left += 1;
                    }
                    else if (player_img.Location == bug_5.Location)
                    {
                        bug_5.Visible = false;
                        bug_5.Left += 1;
                    }
                }
            }
            else if (movement == "buttom")
            {
                player_img.Top += player_img.Height;
                if (player_img.Location.Y >= 327)
                {
                    player_img.Top -= player_img.Height;
                    movement = "stop";
                }
                else if (player_img.Location == pictureBox60.Location || player_img.Location == pictureBox62.Location || player_img.Location == pictureBox63.Location || player_img.Location == pictureBox59.Location || player_img.Location == pictureBox58.Location || player_img.Location == pictureBox57.Location || player_img.Location == pictureBox56.Location || player_img.Location == pictureBox55.Location || player_img.Location == pictureBox54.Location || player_img.Location == pictureBox76.Location || player_img.Location == pictureBox75.Location || player_img.Location == pictureBox74.Location || player_img.Location == pictureBox73.Location || player_img.Location == pictureBox72.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox66.Location || player_img.Location == pictureBox64.Location || player_img.Location == pictureBox65.Location || player_img.Location == pictureBox67.Location || player_img.Location == pictureBox68.Location || player_img.Location == pictureBox69.Location || player_img.Location == pictureBox70.Location || player_img.Location == pictureBox71.Location || player_img.Location == pictureBox72.Location)
                {
                    player_img.Top -= player_img.Height;
                    movement = "stop";
                }
                else if (player_img.Location == pictureBox86.Location || player_img.Location == pictureBox87.Location || player_img.Location == pictureBox88.Location || player_img.Location == pictureBox89.Location)
                {
                    hp_number -= 1;
                    if (hp_number == 4)
                    {
                        pictureBox100.Visible = false;
                    }
                    else if (hp_number == 3)
                    {
                        pictureBox99.Visible = false;
                    }
                    else if (hp_number == 2)
                    {
                        pictureBox98.Visible = false;
                    }
                    else if (hp_number == 1)
                    {
                        pictureBox97.Visible = false;
                    }
                    else if (hp_number == 0)
                    {
                        pictureBox96.Visible = false;
                    }

                    if (hp_number <= 0)
                    {
                        MessageBox.Show("شما باختید", "باخت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        start_game = false;
                        timer1.Enabled = false;
                    }
                    player_img.Left = 128;
                    player_img.Top = 326;
                }
                else if (player_img.Location == pictureBox90.Location || player_img.Location == pictureBox91.Location || player_img.Location == pictureBox93.Location || player_img.Location == pictureBox94.Location || player_img.Location == pictureBox95.Location)
                {
                    if (hp_number != 5)
                    {
                        if (hp_number == 4)
                        {
                            pictureBox100.Visible = true;
                        }
                        else if (hp_number == 3)
                        {
                            pictureBox99.Visible = true;
                        }
                        else if (hp_number == 2)
                        {
                            pictureBox98.Visible = true;
                        }
                        else if (hp_number == 1)
                        {
                            pictureBox97.Visible = true;
                        }
                        if (player_img.Location == pictureBox90.Location)
                        {
                            pictureBox90.Visible = false;
                            pictureBox90.Left += 1;
                        }
                        else if (player_img.Location == pictureBox91.Location)
                        {
                            pictureBox91.Visible = false;
                            pictureBox91.Left += 1;
                        }
                        else if (player_img.Location == pictureBox93.Location)
                        {
                            pictureBox93.Visible = false;
                            pictureBox93.Left += 1;
                        }
                        else if (player_img.Location == pictureBox94.Location)
                        {
                            pictureBox94.Visible = false;
                            pictureBox94.Left += 1;
                        }
                        else if (player_img.Location == pictureBox95.Location)
                        {
                            pictureBox95.Visible = false;
                            pictureBox95.Left += 1;
                        }
                        hp_number += 1;
                    }
                }
                else if (player_img.Location == bug_1.Location || player_img.Location == bug_2.Location || player_img.Location == bug_3.Location || player_img.Location == bug_4.Location || player_img.Location == bug_5.Location)
                {
                    stars_counter += 1;
                    switch (stars_counter)
                    {
                        case 1:
                            star_1.Visible = true;

                            break;
                        case 2:
                            star_2.Visible = true;
                            break;
                        case 3:
                            star_3.Visible = true;
                            break;
                        case 4:
                            star_4.Visible = true;
                            break;
                        case 5:
                            star_5.Visible = true;
                            movement = "stop";
                            MessageBox.Show("آفرین شما برنده شدید و 5 باگ فیکس کردید :)");
                            start_game = false;
                            timer1.Enabled = false;
                            break;
                        default:
                            break;
                    }
                    if (player_img.Location == bug_1.Location)
                    {
                        bug_1.Visible = false;
                        bug_1.Left += 1;
                    }
                    else if (player_img.Location == bug_2.Location)
                    {
                        bug_2.Visible = false;
                        bug_2.Left += 1;
                    }
                    else if (player_img.Location == bug_3.Location)
                    {
                        bug_3.Visible = false;
                        bug_3.Left += 1;
                    }
                    else if (player_img.Location == bug_4.Location)
                    {
                        bug_4.Visible = false;
                        bug_4.Left += 1;
                    }
                    else if (player_img.Location == bug_5.Location)
                    {
                        bug_5.Visible = false;
                        bug_5.Left += 1;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    right_arrow_btn_Click(sender, e);
                    break;
                case Keys.Up:
                    top_arrow_btn_Click(sender, e);
                    break;
                case Keys.Right:
                    left_arrow_btn_Click(sender, e);
                    break;
                case Keys.Down:
                    buttom_arrow_btn_Click(sender, e);
                    break;
                case Keys.A:
                    right_arrow_btn_Click(sender, e);
                    break;
                case Keys.W:
                    top_arrow_btn_Click(sender, e);
                    break;
                case Keys.D:
                    left_arrow_btn_Click(sender, e);
                    break;
                case Keys.S:
                    buttom_arrow_btn_Click(sender, e);
                    break;
                case Keys.P:
                    if (movement == "stop")
                    {
                        start_game = true;
                        timer1.Enabled = true;
                        MessageBox.Show("بازی شروع شد");
                    }
                    else
                    {
                        movement = "stop";
                        start_game = false;
                        timer1.Enabled = false;
                        MessageBox.Show("بازی متوقف شد، برای ادامه کلید P را فشار دهید");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
