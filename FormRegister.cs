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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string tele = textBoxTele.Text;


                if (textBoxNic.Text == "" && textBoxName.Text == "" && textBoxTele.Text == "" && textBoxCreatePassword.Text == "")
                {
                    MessageBox.Show("filed cannot be empty", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((textBoxNic.Text.Length) != 10 && (textBoxNic.Text.Length) != 12)
                {
                    MessageBox.Show("Enter valid Nic number", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if ((textBoxTele.Text.Length) != 10)
                {
                    MessageBox.Show("Enter correct telephone number", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (textBoxCreatePassword.Text == "")
                {
                    MessageBox.Show("Create password field Can't be empty", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxCreatePassword.Text.Length < 8)
                {
                    MessageBox.Show("Password should be minimum 8 Characters", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else if (textBoxCreatePassword.Text == textBoxConfirmPassword.Text)
                {



                    // connection String
                    string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                    // creating sql connection class to connect with the database
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    // sql insert statement
                    string sql = "insert into users(NIC,Uname,Utel,Upassword) values('" + textBoxNic.Text + "', '" + textBoxName.Text + "','" + textBoxTele.Text + "', '" + textBoxCreatePassword.Text + "') ";


                    // create sql command object
                    SqlCommand command = new SqlCommand(sql, cnn);
                    //execute the command
                    command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("successfully registered");
                    FormLogin formLogin = new FormLogin();
                   
                    this.Hide();
                    formLogin.Show();




                }
                else
                {
                    MessageBox.Show("password doesn't match", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCreatePassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    textBoxCreatePassword.Focus();
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("error occured", ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxCreatePassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {

                textBoxCreatePassword.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxNic.Text = "";
            textBoxTele.Text = "";
            textBoxCreatePassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxName.Focus();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
