using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double R = Convert.ToDouble(textBox2.Text);
                double volume = 4.0 / 3.0 * Math.PI * R * R * R;
                label2.Text = "Volume = " + volume;
                double area = 4.0 * Math.PI * R * R;
                label3.Text = "area = " + area;
            }
            catch
            {
                MessageBox.Show("type a number in the radius box");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox3.Text);
            double volume = L * L * L;
        
        }
    }
}
