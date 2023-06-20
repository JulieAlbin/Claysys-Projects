﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CRUDRegform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-OQUGI44U\SQLEXPRESS;Initial Catalog=Nature;Integrated Security=True");
        public int EmpID;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistrationRecord();
            
        }

        private void RegistrationRecord()
        {
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registration9", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            Regview.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
                {
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration9 VALUES (@FirstName,@LastName,@age,@Email,@Address,@City,@State,@Username,@Password)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName",textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName",textBox2.Text);
                cmd.Parameters.AddWithValue("@age",textBox3.Text);
                cmd.Parameters.AddWithValue("@Email",textBox4.Text);
                cmd.Parameters.AddWithValue("@Address",textBox5.Text);
                cmd.Parameters.AddWithValue("@City",textBox6.Text);
                cmd.Parameters.AddWithValue("@State",textBox7.Text);
                cmd.Parameters.AddWithValue("@Username",textBox8.Text);
                cmd.Parameters.AddWithValue("@Password",textBox9.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New student is successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistrationRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Name is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void ResetFormControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Focus();
            textBox1.Focus();
        }

        private void Regview_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            EmpID = Convert.ToInt32(Regview.SelectedRows[0].Cells[0].Value);
            textBox1.Text =Regview.SelectedRows[0].Cells[1].Value.ToString();
           textBox2.Text = Regview.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text =Regview.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = Regview.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = Regview.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = Regview.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = Regview.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text =Regview.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = Regview.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Registration9 SET FirstName=@FirstName,LastName=@LastName,age=@age,Email=@Email,Address=@Address,City=@City,State=@State,Username=@Username,Password=@Password WHERE EmpID=@id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
                cmd.Parameters.AddWithValue("@age", textBox3.Text);
                cmd.Parameters.AddWithValue("@Email", textBox4.Text);
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@City", textBox6.Text);
                cmd.Parameters.AddWithValue("@State", textBox7.Text);
                cmd.Parameters.AddWithValue("@Username", textBox8.Text);
                cmd.Parameters.AddWithValue("@Password", textBox9.Text);
                cmd.Parameters.AddWithValue("@id", this.EmpID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistrationRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please selete the id tobe updated", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    }

