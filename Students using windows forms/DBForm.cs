using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Students_using_windows_forms
{
    public partial class DBForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DBForm()
        {
            InitializeComponent();
            viewData();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {

        }
        //Button to View Data in the Database
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Select * from Students");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Students");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        //Button to insert data in the Database
        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Insert Into Students values (@IdNo,@LastName,@FirstName,@Course,@Score,@OverallScore)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@IdNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lastname", textBox2.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Course", textBox4.Text);
            cmd.Parameters.AddWithValue("@Score", textBox5.Text);
            cmd.Parameters.AddWithValue("@OverallScore", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            viewData();

        }
        //method to display automatically the recent changes in the Database
        void viewData()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            cmd = new SqlCommand("Select * from Students");
            cmd.Connection = con;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Students");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        //textbox for searching data from the database
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //conditional statement to select IdNo to be searched
            if (comboBox1.Text == "ID No")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where IdNo like '%' + '" + textBox7.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select Lastname to be searched
            else if (comboBox1.Text == "Last Name")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where LastName like '%' + '" + textBox7.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select FirstName to be searched
            else if (comboBox1.Text == "First Name")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where FirstName like '%' + '" + textBox7.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            //conditional statement to select Course to be searched
            else if (comboBox1.Text == "Course")
            {
                con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                cmd = new SqlCommand("Select * from Students where Course like '%' + '" + textBox7.Text + "' + '%' ");
                cmd.Connection = con;
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Students");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }

            else
            {
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
