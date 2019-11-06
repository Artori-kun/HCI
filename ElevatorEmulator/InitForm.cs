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
        public InitForm()
        {
            InitializeComponent();
            config = new ConfigForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DAT files ( *.dat )|*.dat|All files ( *.* )|*.*";
            openFileDialog.Title = "Chọn file";

            openFileDialog.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
