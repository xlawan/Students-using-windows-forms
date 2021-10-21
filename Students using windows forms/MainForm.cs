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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // start of labels and texboxes
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // declaring remarks for public use
        public string remark;

        // submit button
        private void button1_Click(object sender, EventArgs e)
        {

            // computation starts here
            // int grade = int.Parse(textBox4.Text);
            double score = double.Parse(ScoreTxtBox.Text);
            double grade = score / double.Parse(OverallScoreTxtBox.Text) * 100;
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

            MessageBox.Show("ID No: " + IdNoTxtBox.Text
                          + "\nName: " + FirstNameTxtBox.Text + " " + LastNameTxtBox.Text
                          + "\nScore: " + ScoreTxtBox.Text + " / " + OverallScoreTxtBox.Text +
                          "\nRemarks: " + remark, "Results");

            // used the public remark to show remark string in messagebox
        }

        // this method will clear all inputted characted in the textboxes.
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)

                        (control as TextBox).Clear();

                    else
                        func(control.Controls);
                }
            }; func(Controls);


        }

        // Clear button
        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            //clears all textbox
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        // error prompt for ID No. textbox when using letters
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");
            }
        }
        // error prompt for First Name textbox when using numbers
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter LETTERS only.", "Error");
            }
        }
        // error prompt for Last Name textbox when using numbers
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter LETTERS only.", "Error");
            }
        }

        // error prompt for Score textbox when using letters
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");

            }

        }

        // error prompt for Overall Score textbox when using letters
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                DialogResult dia = MessageBox.Show("Please enter NUMBERS only.", "Error");

            }

        }
        //start of menu button
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Computations menu details
        private void computationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Computation details:" +
                "\nAn excellent grade means you got a 95% - 100% score." +
                "\nA good grade means you got an 85% - 94% score." +
                "\nA fair grade means you got a 75% - 84% score." +
                "\nA poor grade means you got less than a 75% score." +
                "\n\nTip: Always study smart and be a hardworking student.", "Computation Details");
        }
        //About menu details
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Group: WannaBeTechies" +
                "\nNames:  Laput, Alaine " +
                "\nLawan, Alixander " +
                "\nLibato, Kevin " +
                "\nLlanto, Cathyrine " +
                "\nMahinay, Angelu " +
                "\nMatin - ao, Meinhardt Allain " +
                "\nMembers: 6 " +
                "\nPoint person: Lawan, Alixander", "About Us");
        }
        //To open DBForm for database management
        private void databaseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBForm dbForm = new DBForm();
            dbForm.Show();
        }
    }
}