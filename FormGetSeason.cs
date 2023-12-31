using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSeason
{
    public partial class FormGetSeason : Form
    {
        public FormGetSeason()
        {
            InitializeComponent();
        }

        public string NicValue
        { get; set; }

        private void labelprice_Click(object sender, EventArgs e)
        {
            calculation();
        }

        private string calculation()
        {

            // connection String
            string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

            // creating sql connection class to connect with the database
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            // sql select statement
            string sql = "select * from destinations where destination = '" + textBoxDestination.Text + "' ";
            // create sql command object
            SqlCommand command = new SqlCommand(sql, cnn);

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow firstRow = dt.Rows[0];
                string priceColumnStringValue = firstRow[3].ToString();
                labelViewPrice.Text = priceColumnStringValue;
                string didColumnStringValue = firstRow[0].ToString();
                return didColumnStringValue;
            }
            else
            {
                MessageBox.Show("Enter correct destination", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";

            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            validation();
        }

        private void validation()
        {
            try
            {
                int currentYear = DateTime.Now.Year;
                int currentMonth = DateTime.Now.Month;
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentMonth);

                if (textBoxYear.Text == "" || textBoxDestination.Text == "" || comboBoxMonth.Text == "")
                {
                    MessageBox.Show("cannot be empty", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBoxMonth.Text != monthName)
                {
                    MessageBox.Show("Enter Valid Month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(textBoxYear.Text) != currentYear)
                {
                    MessageBox.Show("Enter Valid Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string month = Convert.ToString(comboBoxMonth.Text);
                    int year = Convert.ToInt32(textBoxYear.Text);
                    string nic = NicValue;
                    checkAlredyHaveSeason(nic, month, year);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void checkAlredyHaveSeason(string nic, string month, int year)
        {
            try
            {
                // connection String
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                // creating sql connection class to connect with the database
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    // sql select statement
                    string sql = "select * from season where  NIC= @nic and S_month = @month and Syear = @year ";
                    // create sql command object
                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@nic", nic);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@year", year);

                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cnn.Close();

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("you already have a season");
                            //FormLogIn formLogIn = new FormLogIn();
                            // formLogIn.Show();
                            this.Hide();




                        }
                        else
                        {

                            string did = calculation();
                            string randomId = GenerateRandomId();


                            SaveIdToDatabase(randomId, month, did, nic, year);
                            FormPayment formPayment = new FormPayment();
                            FormDashboard formDashboard = new FormDashboard();
                            formPayment.GetValue = Convert.ToInt32(labelViewPrice.Text);
                            formPayment.GetSid = randomId;
                            this.Hide();
                            formDashboard.Hide();
                            formPayment.Show();


                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GenerateRandomId()
        {
            string letter = "S";
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
                string query = "SELECT COUNT(*) FROM season WHERE S_id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters[0].SqlDbType = SqlDbType.VarChar;
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void SaveIdToDatabase(string id, string month, string did, string nic, int year)
        {
            try
            {
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {

                    cnn.Open();

                    // sql select statement
                    string sql = "insert into season (S_id,S_month,S_numberof_qr_readtimes,Did,NIC,Syear) values (@id,@month,@number_of_qr_readtimes,@did,@nic,@year) ";

                    using (SqlCommand command = new SqlCommand(sql, cnn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@number_of_qr_readtimes", 120);
                        command.Parameters.AddWithValue("@did", did);
                        command.Parameters.AddWithValue("@nic", nic);
                        command.Parameters.AddWithValue("@year", year);
                        command.ExecuteNonQuery();
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
            comboBoxMonth.Text = string.Empty;
            textBoxYear.Text = string.Empty;
            textBoxDestination.Text = string.Empty;
            labelViewPrice.Text = "$$$$$$";
        }
    }
}
