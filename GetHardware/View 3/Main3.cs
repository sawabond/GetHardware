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
    public partial class Main3 : Form
    {
        public static Form dialogForm;
        public Main3()
        {
            InitializeComponent();
            dialogForm = new ReferenceForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonCollect_Click(object sender, EventArgs e)
        {
            buttonCollect.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialogForm.Show();
        }

        private void Main3_FormClosing(object sender, FormClosingEventArgs e)
        {
            dialogForm.Dispose();
        }
    }
}
