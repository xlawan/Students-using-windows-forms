using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_using_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
// declaring remarks for public use
        public string remark;

        private void button1_Click(object sender, EventArgs e)
        {

            // computation starts here
            int grade = int.Parse(textBox4.Text);

            if (grade >= 95)
            {
                remark = "EXCELLENT!!!";

            }
            else if (grade >= 85 && grade < 95)
            {
                remark = "GOOD!!!";

            }
            else if (grade >= 75 && grade < 85)
            {
                remark = "FAIR!!!";

            }
            else if (grade < 75)
            {
                remark = "POOR!!!";

            }
            // computation ends here

            MessageBox.Show("ID No: " + textBox1.Text
                          + "\nName: " + textBox2.Text + " " + textBox3.Text
                          + "\nScore: " + textBox4.Text + " / " + textBox5.Text +
                          "\nRemarks: " + remark);

                // used the public remark to show remark string in messagebox
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
