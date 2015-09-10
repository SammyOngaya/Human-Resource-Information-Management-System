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
    public partial class JobCategory : Form
    {
        public JobCategory()
        {
            InitializeComponent();
            showJobCategory();
            searchJobCategory();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JobCategory_Load(object sender, EventArgs e)
        {

        }

        // Add job category
        private void addJobCategory_Click(object sender, EventArgs e)
        {
            // Insert Job Category into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `job_category` VALUES(NULL,'" + this.jobCategoryNameTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Job Category added successfully!");
                clearJobCategoryData();
                showJobCategory();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding job category to the database, : " + exception.Message);
            }
        } // End add Job Category method

        // Show job category in gridview
        public void showJobCategory()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_category ", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                jobCategoryDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        } // End showDepartment method.

        // Search department
        public void searchJobCategory()
        {
            searchJobCategoryName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchJobCategoryName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_category", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching department, : " + exception.Message);
            }

            searchJobCategoryName.AutoCompleteCustomSource = collection;

        }// End search department name

        // Show department data
        public void jobCategoryData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_category WHERE name='" + this.searchJobCategoryName.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    jobCategoryNameTextBox.Text = name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching job category, : " + exception.Message);
            }


        }

        private void searchJobCategoryName_TextChanged(object sender, EventArgs e)
        {
            jobCategoryData();
        }


        //
        private void updateJobCategory_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE job_category SET name='" + this.jobCategoryNameTextBox.Text + "' WHERE name='" + this.searchJobCategoryName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Job Category updated successfully!");
                clearJobCategoryData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating job category, : " + exception.Message);
            }

            showJobCategory();
        } // End update job category

        // Clear job category data.
        private void clearJobCategoryData()
        {
            jobCategoryNameTextBox.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
