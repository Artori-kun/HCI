using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ElevatorEmulator
{
    public partial class Form1 : Form
    {
        private OpenForm elevatorGraphics;
        SettingForm settingForm;

        public Form1()
        {
            settingForm = new SettingForm();
            //elevatorGraphics = new ElevatorGraphics();
            InitializeComponent();
        }

        internal OpenForm ElevatorGraphics { get => elevatorGraphics; set => elevatorGraphics = value; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //using (Graphics g = e.Graphics)
            //{
            //    g.Clear(Color.White);
            //    using ( Pen pen = new Pen(Color.Red, 2) )
            //    {
            //        g.DrawRectangle(pen, elevatorGraphics.ElevatorContainer);
            //        g.FillRectangle(new SolidBrush( Color.Green), elevatorGraphics.Elevator);
            //    }
            //}
        }

        private void upButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //FloorLockForm floorLockForm = new FloorLockForm();
            //floorLockForm.Show();
        }

        private void downButton6_Click(object sender, EventArgs e)
        {
            //downButton6.BackColor = Color.Red;
        }

        private void settingMenuItem_Click(object sender, EventArgs e)
        {
            settingForm.Show();
        }

        private void upButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void floorButton1_Click(object sender, EventArgs e)
        {
            if( floorButton1.BackColor == Color.Red)
            {
                floorButton1.BackColor = SystemColors.ControlLightLight;
                floorButton1.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton1.BackColor = Color.Red;
                floorButton1.ForeColor = Color.White;
            }
        }

        private void floorButton2_Click(object sender, EventArgs e)
        {
            if (floorButton2.BackColor == Color.Red)
            {
                floorButton2.BackColor = SystemColors.ControlLightLight;
                floorButton2.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton2.BackColor = Color.Red;
                floorButton2.ForeColor = Color.White;
            }
        }

        private void floorButton3_Click(object sender, EventArgs e)
        {
            if (floorButton3.BackColor == Color.Red)
            {
                floorButton3.BackColor = SystemColors.ControlLightLight;
                floorButton3.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton3.BackColor = Color.Red;
                floorButton3.ForeColor = Color.White;
            }
        }

        private void floorButton4_Click(object sender, EventArgs e)
        {
            if (floorButton4.BackColor == Color.Red)
            {
                floorButton4.BackColor = SystemColors.ControlLightLight;
                floorButton4.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton4.BackColor = Color.Red;
                floorButton4.ForeColor = Color.White;
            }
        }

        private void floorButton5_Click(object sender, EventArgs e)
        {
            if (floorButton5.BackColor == Color.Red)
            {
                floorButton5.BackColor = SystemColors.ControlLightLight;
                floorButton5.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton5.BackColor = Color.Red;
                floorButton5.ForeColor = Color.White;
            }
        }

        private void floorButton6_Click(object sender, EventArgs e)
        {
            if (floorButton6.BackColor == Color.Red)
            {
                floorButton6.BackColor = SystemColors.ControlLightLight;
                floorButton6.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton6.BackColor = Color.Red;
                floorButton6.ForeColor = Color.White;
            }
        }

        private void floorButton7_Click(object sender, EventArgs e)
        {
            if (floorButton7.BackColor == Color.Red)
            {
                floorButton7.BackColor = SystemColors.ControlLightLight;
                floorButton7.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton7.BackColor = Color.Red;
                floorButton7.ForeColor = Color.White;
            }
        }

        private void floorButton8_Click(object sender, EventArgs e)
        {
            if (floorButton8.BackColor == Color.Red)
            {
                floorButton8.BackColor = SystemColors.ControlLightLight;
                floorButton8.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton8.BackColor = Color.Red;
                floorButton8.ForeColor = Color.White;
            }
        }

        private void floorButton9_Click(object sender, EventArgs e)
        {
            if (floorButton9.BackColor == Color.Red)
            {
                floorButton9.BackColor = SystemColors.ControlLightLight;
                floorButton9.ForeColor = SystemColors.ControlText;
            }
            else
            {
                floorButton9.BackColor = Color.Red;
                floorButton9.ForeColor = Color.White;
            }
        }

        private void holdDoorButton_Click(object sender, EventArgs e)
        {
            if (holdDoorButton.BackColor == Color.Red)
            {
                holdDoorButton.BackColor = SystemColors.ControlLightLight;
                holdDoorButton.ForeColor = SystemColors.ControlText;
            }
            else
            {
                holdDoorButton.BackColor = Color.Red;
                holdDoorButton.ForeColor = Color.White;
            }
        }

        private void closeDoorButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeDoorButton.BackColor = Color.Red;
            closeDoorButton.ForeColor = Color.White;
        }

        private void closeDoorButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeDoorButton.BackColor = SystemColors.ControlLightLight;
            closeDoorButton.ForeColor = SystemColors.ControlText;
        }

        private void openDoorButton_Click(object sender, EventArgs e)
        {
        }

        private void openDoorButton_MouseDown(object sender, MouseEventArgs e)
        {
            openDoorButton.BackColor = Color.Red;
            openDoorButton.ForeColor = Color.White;
        }

        private void openDoorButton_MouseUp(object sender, MouseEventArgs e)
        {
            openDoorButton.BackColor = SystemColors.ControlLightLight;
            openDoorButton.ForeColor = SystemColors.ControlText;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void bellButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Thang máy 1")
            {
                label17.ForeColor = Color.White;
                label17.BackColor = Color.Red;
            }
            else if(comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Thang máy 2")
            {
                label25.ForeColor = Color.White;
                label25.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Red;
            label17.BackColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label25.ForeColor = Color.Red;
            label25.BackColor = Color.White;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
