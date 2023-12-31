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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        public string GetSid
        { get; set; }

        public int GetValue
        { get; set; }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            labelViewAmount.Text = GetValue.ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxCardNumber.Text == "" && textBoxCvn.Text == "" && textBoxExYear.Text == "" && comboBoxExMonth.Text == "")
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxCardNumber.Text == "")
            {
                MessageBox.Show("please Enter your Card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxCvn.Text == "")
            {
                MessageBox.Show("Please Enter your cvc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxExYear.Text == "")
            {
                MessageBox.Show("Please Enter Ex Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxExMonth.Text == "")
            {
                MessageBox.Show("Please Enter Ex month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // else if (cardNumber != Convert.ToInt32(txtCardNumbr.Text))
            // {
            //     MessageBox.Show("Card Number only have Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            else if (textBoxCardNumber.Text.Length != 16)
            {
                MessageBox.Show("Card number have only 16 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBoxCvn.Text, out _))
            {
                MessageBox.Show("Please enter a valid numeric CVN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (textBoxCvn.Text.Length != 3)
            {
                MessageBox.Show("cvn only have three Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(selectedMethod()))
            {
                MessageBox.Show("Select payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                string id = GenerateRandomId();
                int amount = Convert.ToInt32(labelViewAmount.Text);
                string method = selectedMethod();
                string sid = GetSid;

                SaveIdToDatabase(id, amount, method, sid);
                //btnSubmit.Enabled = false;
                FormSeason formseason = new FormSeason();
                formseason.GetSid = sid;
                formseason.Show();
                this.Close();
            }


        }
        private string selectedMethod()
        {
            if (radioButtonVisa.Checked)
            {
                return radioButtonVisa.Text;

            }
            else if (radioButtonMaster.Checked)
            {
                return radioButtonMaster.Text;

            }
            else if (radioButtonAmex.Checked)
            {
                return radioButtonAmex.Text;
            }
            else
            {
                return "";
            }

        }


        private string GenerateRandomId()
        {
            string letter = "P";
            string id;
            Random random = new Random();

            do
            {
                int number = random.Next(0, 1000);
                string formattedNumber = number.ToString("D3");
                id = $"{letter}{formattedNumber}";
            }
            while (IsIdExistsInDatabase(id));

            return id;
        }
        private bool IsIdExistsInDatabase(string id)
        {
            string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM payments WHERE Pid = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters[0].SqlDbType = SqlDbType.VarChar;
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        public void SaveIdToDatabase(string id, int amount, string method, string sid)
        {
            try
            {
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {

                    cnn.Open();

                    // sql insert statement
                    string sql = "insert into payments(Pid,Pamount,Pmethod,S_id) values (@id,@amount,@method,@sid) ";

                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@method", method);
                        command.Parameters.AddWithValue("@sid", sid);

                        command.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
