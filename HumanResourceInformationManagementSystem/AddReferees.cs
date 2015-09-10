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
    public partial class AddReferees : Form
    {
        public AddReferees(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            refereesCountryCombo();
            showEmployeeReferee();
        }


        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void saveRefereesDdata_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO referees VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.refereesNamesTextBox.Text + "','" + this.refereesPhoneTextBox.Text + "','" + this.refereesAddressTextBox.Text + "','" + this.refereesComboBox.Text + "','" + this.refereesCityTextBox.Text + "','" + this.refereesOccupationTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee referees data registered sucessfully.......!");
                showEmployeeReferee();
                clearRefereesData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee referees data in database.......!" + exception.Message);
            }
        }// End inserting next of  data to database.

        // Clear employee referees data.
        private void clearRefereesData()
        {
            refereesNamesTextBox.Text = string.Empty;
            refereesPhoneTextBox.Text = string.Empty;
            refereesAddressTextBox.Text = string.Empty;
            refereesComboBox.Text = string.Empty;
            refereesCityTextBox.Text = string.Empty;
            refereesOccupationTextBox.Text = string.Empty;
        }

        // Show employee referees in gridview
        public void showEmployeeReferee()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM referees WHERE pfno='" + this.pfnoTextBox.Text + "'", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                refereesDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show employee referees method.

        private void AddReferees_Load(object sender, EventArgs e)
        {

        }

        // Populate referees Country combo
        public void refereesCountryCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("nationality");
                    refereesComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        }// End Referees Country combo populating

        private void refereesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
    }
}
