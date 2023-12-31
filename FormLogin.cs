using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSeason
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNic.Text == "" && textBoxPassword.Text == "")
                {
                    MessageBox.Show("Enter Nic and password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNic.Text == "")
                {
                    MessageBox.Show("Enter Nic", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Enter password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {



                    // connection String
                    string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                    // creating sql connection class to connect with the database
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    // sql select statement
                    string sql = "select * from users where NIC = '" + textBoxNic.Text + "' and Upassword ='" + textBoxPassword.Text + "' ";
                    // create sql command object
                    SqlCommand command = new SqlCommand(sql, cnn);

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);




                    if (dt.Rows.Count > 0)
                    {

                        string Nic = textBoxNic.Text;
                        string password = textBoxPassword.Text;
                        FormDashboard formDashboard = new FormDashboard();
                        //FormProfile profile = new FormProfile();
                        formDashboard.NicValue = textBoxNic.Text;


                        formDashboard.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Enter correct user name and password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNic.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxNic.Focus();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
    
}
