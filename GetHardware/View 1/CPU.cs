using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetHardware
{
    public partial class CPU : Form
    {
        Main1 main;
        public CPU(Main1 Main)
        {
            main = Main;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }
    }
}
