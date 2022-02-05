using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReminderApp
{
    public partial class Form1 : Form
    {
        int second;
        int minute;
        int hour;

        int secondBackup;
        int minuteBakcup;
        int hourBackup;
        

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rb30min.Checked = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if(rb10Min.Checked)
            {
                hour = 0;
                second = 0;
                minute = 10;
                
            }
            else if(rb20min.Checked)
            {
                hour = 0;
                second = 0;
                minute = 20;
            }
            else if(rb30min.Checked)
            {
                hour = 0;
                second = 0;
                minute = 30;
            }
            else if(rb40min.Checked)
            {
                hour = 0;
                second = 0;
                minute = 40;
            }
            else if(rb1Hour.Checked)
            {
                hour = 1;
                second = 0;
                minute = 0;
            }
            else if(rbMannually.Checked)
            {
                if (numericUpSecond != null)
                {
                    second = Convert.ToInt32(numericUpSecond.Value);
                }
                else
                {
                    second = 0;
                }

                if (numericUpMinute != null)
                {
                    minute = Convert.ToInt32(numericUpMinute.Value);
                }
                else
                {
                    minute = 0;
                }

                if (numericUpHour != null)
                {
                    hour = Convert.ToInt32(numericUpHour.Value);
                }
                else
                {
                    hour = 0;
                }
            }

            minuteBakcup = minute;
            secondBackup = second;
            hourBackup = hour;

           
            
            

            lbTimeDisplay.Text = hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();

            groupBoxTimeSetting.Enabled = false;

            btnClearTime.Enabled = true;
            btnBegin.Enabled = true;
            
           
           

        }

        private void btnClearTime_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear time?", "Clear Time Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                timer1.Enabled = false;
                second = 0;
                minute = 0;
                hour = 0;
                lbTimeDisplay.Text = "-- : -- : --";
                groupBoxTimeSetting.Enabled = true;
                btnClearTime.Enabled = false;

                btnBegin.Text = "Begin";
                btnBegin.BackColor = SystemColors.ActiveBorder;
                btnBegin.Enabled = false;

                btnReset.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
                if (second == 0)
                {
                    second = 60;
                    minute--;
                }

                if (minute < 0)
                {
                    if(hour==0)
                    {
                    timer1.Enabled = false;
                    //btnClearTime.PerformClick();
                    timer1.Enabled = false;
                    second = 1;
                    minute = 0;
                    hour = 0;
                    //lbTimeDisplay.Text = "-- : -- : --";
                    groupBoxTimeSetting.Enabled = true;
                    btnClearTime.Enabled = false;

                    btnBegin.Text = "Begin";
                    btnBegin.BackColor = SystemColors.ActiveBorder;
                    btnBegin.Enabled = false;

                    btnReset.Enabled = false;
                    //btnBegin.Text = "Begin";
                    //btnBegin.BackColor = SystemColors.ActiveBorder;
                    // MessageBox.Show("You should take a break now!!!");

                    Form f = new Form();
                    f.TopMost = true;
                    f.WindowState = FormWindowState.Maximized;
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.Opacity = 0.5;
                    f.Load += new EventHandler(f_Load);
                    f.Show();
                }
                    else
                    {
                        hour--;
                        minute = 59;
                    }

                }
                second--;
                lbTimeDisplay.Text = hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();
            
           
        }

        void f_Load(object sender, EventArgs e)
        {
            MessageBox.Show("You should take a break now!!!");
            ((Form)sender).Close();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled==false)
            {
                timer1.Enabled = true;
                btnBegin.Text = "Pause";
                btnBegin.BackColor = Color.Red;
                btnReset.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                btnBegin.Text = "Begin";
                btnBegin.BackColor = SystemColors.ActiveBorder;
            }
           


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset?", "Reset Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                /*
                second = Convert.ToInt32(numericUpSecond.Value);
                minute = Convert.ToInt32(numericUpMinute.Value);
                hour = Convert.ToInt32(numericUpHour.Value);
                */
                second = secondBackup;
                minute = minuteBakcup;
                hour = hourBackup;

                lbTimeDisplay.Text = hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
