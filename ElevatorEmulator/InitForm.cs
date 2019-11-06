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
            //config.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            config.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            config.Close();
        }
    }
}
