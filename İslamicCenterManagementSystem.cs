using son.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace son
{
    public partial class İslamicCenterManagementSystem : Form
    {
        

        public İslamicCenterManagementSystem()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //lblmassege.Text = "";
                //lblmassege.ForeColor = Color.Black;

                string email = tbemail.Text.Trim();
                string password = tbpassword.Text.Trim();




                    if (string.IsNullOrWhiteSpace(email))
                    {
                        lblmassege.Text = "Please enter your email.";
                        lblmassege.ForeColor = Color.Red;
                        tbemail.Focus();
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        lblmassege.Text = "Enter your password.";
                        lblmassege.ForeColor = Color.Red;
                        lblmassege.Focus();
                        return;
                    }

                Employee emp = new Employee();
                var employee = emp.login(email, password);

                Teacher tch = new Teacher();
                var teacher = tch.login(email, password);

                Student std = new Student();
                var student = std.login(email, password);
                

                if (employee != null)
                {
                   
                    HomePage form = new HomePage(employee);
                    //form.Person = employee;
                    
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                if (teacher != null)
                {
                    HomePage form = new HomePage(teacher);
                    //form.Person = teacher;

                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                if (student != null)
                {
                    HomePage form = new HomePage(student);
                   // form.Person = student;

                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    lblmassege.Text = "Email or password is incorrect.";
                    lblmassege.ForeColor = Color.Red;
                }

            }
            catch (Exception)
            {

                lblmassege.Text = "An error occured in login.";
                lblmassege.ForeColor = Color.Red;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lblmassege.Text = "";
            //tbemail.Text = "";
            //tbpassword.Text = "";
            //cbremember.Checked = false;

            this.Close();
        }
    }
}
