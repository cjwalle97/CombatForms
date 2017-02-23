using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CombatForms
{
    public partial class TargetWindow : Form
    {
        public TargetWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Enabled = true;
            form1.Show();

            Debug.WriteLine("Left Column Targeted");
            Debug.WriteLine("Active Unit Takes damage");

            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Enabled = true;
            form1.Show();

            Debug.WriteLine("Center Column Targeted.");
            Debug.WriteLine("Active Unit takes damage");

            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Enabled = true;
            form1.Show();

            Debug.WriteLine("Right Column Targeted.");
            Debug.WriteLine("Active Unit takes damage");

            this.Dispose();
        }
    }
}
