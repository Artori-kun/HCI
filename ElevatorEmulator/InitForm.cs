using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ElevatorEmulator
{
    public partial class InitForm : Form
    {
        ConfigForm config;
        Form1 frm;
        public InitForm()
        {
            InitializeComponent();
            config = new ConfigForm();
            frm = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.Show();
        }
        int x = 250, y = 91, a = 1;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            config.Show();
        }


        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            InitForm.ActiveForm.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
           try
            {
                x += a;
                label1.Location = new Point(x, y);
                if(x>375)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(0, 192, 0);
                }
                if(x< 250)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(0, random.Next(100,150),0);
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
