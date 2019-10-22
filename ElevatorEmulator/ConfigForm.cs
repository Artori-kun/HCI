using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorEmulator
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton1.Checked)
            {
                detailLabel.Text = "Mô phỏng hệ thống gồm 1 thang máy, thích hợp cho các hệ thống nhỏ như nhà riêng, thang chở hàng...";
            }
            else
            {
                //radioButton1.Checked = false;
                detailLabel.Text = null;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                detailLabel.Text = "Mô phỏng hệ thống nhiều hơn 1 thang máy với các nút gọi tầng hoạt động tách biệt, thích hợp cho các hệ thống nhỏ và vừa như " +
                    "chung cư nhỏ, siêu thị, văn phòng...";
            }
            else
            {
                //radioButton2.Checked = false;
                detailLabel.Text = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                detailLabel.Text = "Mô phỏng hệ thống nhiều hơn 1 thang máy sử dụng chung các nút gọi tầng, thích hợp cho các hệ thống lớn như " +
                    "chung cư lớn, khu mua sắm...";
            }
            else
            {
                //radioButton3.Checked = false;
                detailLabel.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 project = new Form1();
            project.Show();
            //Program.init.Close();
            //this.Close();
            Program.init.Visible = false;
            this.Visible = false;
        }
    }
}
