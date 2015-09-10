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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
            showCountry();
            searchCountry();
        }

        // MySql database string connection.
        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        // Save country into database.
        private void addCountry_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO nationality VALUES(NULL,'" + this.countryNameTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Country saved successfully!");
                clearChildrenData();
                showCountry();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while saving country into database, : "+exception.Message);
            }
        } // End saving country.



          // Show countries in datagrid.
        public void showCountry() {

            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT nationality AS 'COUNTRY NAME' FROM nationality ORDER BY nationality ASC",sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                countryDataGridView.DataSource = bindingSource;
                
                sqlConnection.Close();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while displaying data in datagrid, : "+exception.Message);
            }

        } // End show countries method


        // Search Country.
        public void searchCountry() {
            sqlConnection = new MySqlConnection(databaseConnection);

            searchCountryName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchCountryName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String nationality = reader.GetString("nationality");
                    collection.Add(nationality);
                }
            }
            catch (Exception exception) {
                MessageBox.Show("No data to show, : "+exception.Message);
            }
            searchCountryName.AutoCompleteCustomSource = collection;
         } // End search method.

        // Show search data.
        public void showSearchData() {

            sqlConnection = new MySqlConnection(databaseConnection);
            try {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality WHERE nationality='"+this.searchCountryName.Text+"'",sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read()) {
                    String id = reader.GetInt64("nationality_id").ToString();
                    String name = reader.GetString("nationality");

                    nationalityIdTextBox.Text = id;
                    countryNameTextBox.Text = name;
                 }
                sqlConnection.Close();
            }catch(Exception exception){
                MessageBox.Show("No search data to show, : "+exception.Message);
            }
        
        } // End show serach data.

        private void Country_Load(object sender, EventArgs e)
        {

        }

        // Update country.
        private void updateCountry_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("UPDATE nationality SET nationality='" + this.countryNameTextBox.Text+ "' WHERE nationality_id='" + this.nationalityIdTextBox.Text+ "'",sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Country updated successfully!");
                clearChildrenData();
                showCountry();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while updating the country, : "+exception.Message);
            }

        } // End update method.

        // Clear country data.
        private void clearChildrenData()
        {
            countryNameTextBox.Text = string.Empty;
             }

        private void searchCountryName_TextChanged(object sender, EventArgs e)
        {
            showSearchData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
