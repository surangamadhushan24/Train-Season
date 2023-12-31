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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        public string NicValue
        { get; set; }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            displayProfileDetail();
        }

        private void displayProfileDetail()
        {
            labelViewNic.Text = NicValue;
            string nic = labelViewNic.Text;

            try
            {
                // connection String
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                // creating sql connection class to connect with the database
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                // sql select statement
                string sql = "select * from users where NIC ='" + labelViewNic.Text + "' ";
                // create sql command object
                SqlCommand command = new SqlCommand(sql, cnn);

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cnn.Close();

                if (dt.Rows.Count > 0)
                {

                    DataRow firstRow = dt.Rows[0];
                    string firstColumnStringValue = firstRow[1].ToString();
                    labelViewName.Text = firstColumnStringValue;



                    string telColumnStringValue = firstRow[2].ToString();
                    labelViewTele.Text = telColumnStringValue;
                    getSeason();
                }
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSeason()
        {
            try
            {
                string nic = NicValue;
                int currentYear = DateTime.Now.Year;
                int currentMonth = DateTime.Now.Month;
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentMonth);

                // connection String
                string connectionString = @"Data Source = LAPTOP-8EV19IBP\SQLEXPRESS;Initial Catalog=railwayseason;integrated security = true";

                // creating sql connection class to connect with the database
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                // sql select statement
                string sql = "select * from season where NIC = '" + nic + "' and S_month = '" + monthName + "' and Syear = " + currentYear + ";";

                // create sql command object
                SqlCommand command = new SqlCommand(sql, cnn);

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cnn.Close();

                if(dt.Rows.Count > 0)
                {
                    DataRow firstRow = dt.Rows[0];
                    string qrReadTimeColumnStringValue = firstRow[2].ToString();
                    int qrReadtimes = Convert.ToInt32(qrReadTimeColumnStringValue);
                    int number_of_turns_EachDay = 2;
                    int numberOfTurns = qrReadtimes / number_of_turns_EachDay;
                    labelViewTurns.Text = numberOfTurns.ToString();
                  

                    
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
