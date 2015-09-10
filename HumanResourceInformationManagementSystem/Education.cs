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
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
            searchEducation();
            showEducation();
        }


        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void Education_Load(object sender, EventArgs e)
        {

        }

        private void addEducation_Click(object sender, EventArgs e)
        {
            // Insert education data into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `education` VALUES(NULL,'" + this.educationNameTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Education added successfully!");
                clearEducationData();
                showEducation();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding education to the database, : " + exception.Message);
            }
        } // End addEducation method

        // Show education in gridview
        public void showEducation()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * from education", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                educationDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        } // End showDepartment method.

        // Search department
        public void searchEducation()
        {
            searchEducationName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchEducationName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM education", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching education, : " + exception.Message);
            }

            searchEducationName.AutoCompleteCustomSource = collection;

        }// End search department name

        // Show department data
        public void educationData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM education WHERE name='" + this.searchEducationName.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    educationNameTextBox.Text = name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching education, : " + exception.Message);
            }


        }

        private void searchEducationName_TextChanged(object sender, EventArgs e)
        {
            educationData();
        }

        private void updateEducation_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE education SET name='" + this.educationNameTextBox.Text + "' WHERE name='" + this.searchEducationName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Education updated successfully!");
                clearEducationData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating education, : " + exception.Message);
            }

            showEducation();
        } // End update department

        // Clear country data.
        private void clearEducationData()
        {
            educationNameTextBox.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
