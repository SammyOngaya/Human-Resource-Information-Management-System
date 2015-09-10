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
    public partial class AddEducation : Form
    {
        public AddEducation(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            educationCombo();
            showEducationData();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void AddEducation_Load(object sender, EventArgs e)
        {

        }

       
        // Insert education data to database.
        private void saveEducationData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO emp_education VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.educationlLevelTextBox.Text + "','" + this.educationInstitueTextBox.Text + "','" + this.educationCourseTextBox.Text + "','" + this.educationYearCompletedTextBox.Text + "','" + this.educationScoreTextBox.Text + "','" + this.educationStartDateDateTimePicker.Text + "','" + this.educationEndDateDateTimePicker.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee education data registered sucessfully.......!");
                showEducationData();
                clearEducationData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee education data in database.......!" + exception.Message);
            }
        } // End inserting education data to database.


        // Clear employee education data.
        private void clearEducationData()
        {
            educationlLevelTextBox.Text = string.Empty;
            educationInstitueTextBox.Text = string.Empty;
            educationCourseTextBox.Text = string.Empty;
            educationYearCompletedTextBox.Text = string.Empty;
            educationScoreTextBox.Text = string.Empty;
            educationStartDateDateTimePicker.Text = string.Empty;
            educationEndDateDateTimePicker.Text = string.Empty;
           
        }

        private void educationLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM education WHERE name='" + this.educationLevelComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String education = dataReader.GetInt32("education_id").ToString();
                    educationlLevelTextBox.Text = education;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Populate education combo
        public void educationCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM education", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("name");
                    educationLevelComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End education combo populating

        // Show education in gridview
        public void showEducationData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_education WHERE pfno='" + this.pfnoTextBox.Text + "'", sqlConnection);
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

        }// End show education method.
    }
}
