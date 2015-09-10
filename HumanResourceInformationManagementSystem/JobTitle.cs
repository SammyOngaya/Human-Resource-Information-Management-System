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
    public partial class JobTitle : Form
    {
        public JobTitle()
        {
            InitializeComponent();
            jobCategoryCombo();
            showJobTitle();
            searchJobTitle();
        }


        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        // Populate job category combo
        public void jobCategoryCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_category", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("name");
                    JobCategoryComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End job category combo populating

        private void JobCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_category WHERE name='" + this.JobCategoryComboBox.Text + "'",sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String jobCategory = dataReader.GetInt32("job_category_id").ToString();
                    jobCategoryForeignKeyTextBox.Text = jobCategory;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addJobTitle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO job_title VALUES(NULL,'"+this.jobCategoryForeignKeyTextBox.Text+"','"+this.jobTitleNameTextBox.Text+"','"+this.descriptionTextBox.Text+"')",sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                MessageBox.Show("Data inserted successfully......!");
                clearJobTitleData();
                showJobTitle();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while inserting into job title, : "+exception.Message);
            }
        } // End inserting job title to database.

        public void showJobTitle() {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT `job_title`.`job_category_id` AS 'ID',`job_title`.`title` AS 'TITLE',`job_title`.`description` AS 'DESCRIPTION',`job_category`.`name` AS 'CATEGORY' FROM `job_category` JOIN `job_title` ON `job_category`.`job_category_id`=`job_title`.`job_category_id`", sqlConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                dataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                jobTitleDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while retrieving job titles, : "+exception.Message);
            }
        } // End show data.

        // Search department
        public void searchJobTitle()
        {
            searchJobTitleName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchJobTitleName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_title", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String title = reader.GetString("title");
                    collection.Add(title);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching title, : " + exception.Message);
            }
            
            searchJobTitleName.AutoCompleteCustomSource = collection;

        }// End search job title.

        // Show job title data
        public void jobTitleData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT `job_title`.`title`,`job_title`.`job_category_id`,`job_title`.`description`,`job_category`.`name` AS 'name' FROM `job_category` JOIN `job_title` ON `job_category`.`job_category_id`=`job_title`.`job_category_id` WHERE `job_title`.`title`='" + this.searchJobTitleName.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String title = reader.GetString("title");
                    String category = reader.GetString("job_category_id");
                    String category_name = reader.GetString("name");
                    String description = reader.GetString("description");

                    jobTitleNameTextBox.Text = title;
                    jobCategoryForeignKeyTextBox.Text = category;
                    JobCategoryComboBox.Text = category_name;
                    descriptionTextBox.Text = description;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching education, : " + exception.Message);
            }


        }

        private void searchJobTitleName_TextChanged(object sender, EventArgs e)
        {
            jobTitleData();
        }

        private void updateJobTitle_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE job_title SET job_category_id='" + this.jobCategoryForeignKeyTextBox.Text + "',title='" + this.jobTitleNameTextBox.Text + "',description='" + this.descriptionTextBox.Text + "' WHERE title='" + this.searchJobTitleName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Job Title updated successfully!");
                clearJobTitleData();
                showJobTitle();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating job title, : " + exception.Message);
            }
        }

        // Clear job title data.
        private void clearJobTitleData()
        {
            jobCategoryForeignKeyTextBox.Text = string.Empty;
            jobTitleNameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
        }

        private void JobTitle_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
