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
    public partial class AddExperience : Form
    {
        public AddExperience(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            showEmployeeExperience();
            experienceJobTitleCombo();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void saveEmployeeExperienceData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO work_experience VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.experienceJobTitleTextBox.Text + "','" + this.experienceNumberOfYearsComboBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee work experience data registered sucessfully.......!");
                showEmployeeExperience();
                clearExperienceData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee work experience data in database.......!" + exception.Message);
            }
        }// End inserting referees data to database.

        // Clear employee experience data.
        private void clearExperienceData()
        {
            experienceJobTitleTextBox.Text = string.Empty;
            experienceNumberOfYearsComboBox.Text = string.Empty;

        }


        // Show employee experience in gridview
        public void showEmployeeExperience()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM work_experience WHERE pfno='" + this.pfnoTextBox.Text + "'", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                experienceDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show employee experience method.

        private void jobTitleExperienceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_title WHERE title='" + this.jobTitleExperienceComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String jobTitle = dataReader.GetInt32("job_title_id").ToString();
                    experienceJobTitleTextBox.Text = jobTitle;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Populate experience job title combo
        public void experienceJobTitleCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM job_title", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("title");
                    jobTitleExperienceComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End experience job title combo populating
    }
}
