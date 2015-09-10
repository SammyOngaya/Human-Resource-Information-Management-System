using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HumanResourceInformationManagementSystem
{
    public partial class AddNextOfKin : Form
    {
        public AddNextOfKin(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            countryCombo();
            showEmployeeNextOfKin();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void AddNextOfKin_Load(object sender, EventArgs e)
        {

        }

        // Populate Country combo
        public void countryCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("nationality_id");
                    nextOfKinCountryComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End Country combo populating


        // Show employee next of kin in gridview
        public void showEmployeeNextOfKin()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM next_of_kin ", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                nextOfKinDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }
        }

        // End show employee next of kin method.

        private void saveNextOfKinData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO next_of_kin VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.nextOfKinNamesTextBox.Text + "','" + this.nextOfKinPhoneTextBox.Text + "','" + this.nextOfKinAddressTextBox.Text + "','" + this.nextOfKinCountryComboBox.Text + "','" + this.nextOfKinCityTextBox.Text + "','" + this.nextOfKinOccupationTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee next of kin data registered sucessfully.......!");
                showEmployeeNextOfKin();
                clearNextOfKinData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee next of kin data in database.......!" + exception.Message);
            }
        }

         // Clear employee next of kin data.
        private void clearNextOfKinData()
        {
            nextOfKinNamesTextBox.Text = string.Empty;
            nextOfKinPhoneTextBox.Text = string.Empty;
            nextOfKinAddressTextBox.Text = string.Empty;
            nextOfKinCountryTextBox.Text = string.Empty;
            nextOfKinCityTextBox.Text = string.Empty;
            nextOfKinOccupationTextBox.Text = string.Empty;
        }

    }
}
