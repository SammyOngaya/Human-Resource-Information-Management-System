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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            jobTitleCombo();
            departmentCombo();
            payGradeCombo();
            countryCombo();
            educationCombo();
            skillCombo();
            experienceJobTitleCombo();
            refereesCountryCombo();
            nextOfKinCountryCombo();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

       
        // Populate job title combo
        public void jobTitleCombo()
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
                    jobTitleComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End job category combo populating

        // Populate job title combo
        public void departmentCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM department", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("department_name");
                    departmentNameComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End job category combo populating

        // Populate pay grade combo
        public void payGradeCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM pay_grade", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("name");
                    payGradeComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End pay grade combo populating

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
                    String l = dataReader.GetString("nationality");
                    refereesComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End Country combo populating

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
                    nextOfKinComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End Referees Country combo populating

        // Populate next of kin Country combo
        public void nextOfKinCountryCombo()
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
                    countryComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End next of kinCountry combo populating

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

        // Populate skill combo
        public void skillCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM skill", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String l = dataReader.GetString("name");
                    skillComboBox.Items.Add(l);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        } // End skill combo populating

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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void nextOfKinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality WHERE nationality='" + this.nextOfKinComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String jobCategory = dataReader.GetInt32("nationality_id").ToString();
                    nextOfKinCountryTextBox.Text = jobCategory;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void refereesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality WHERE nationality='" + this.refereesComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String jobCategory = dataReader.GetInt32("nationality_id").ToString();
                    refereesCountryTextBox.Text = jobCategory;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM nationality WHERE nationality='" + this.countryComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String jobCategory = dataReader.GetInt32("nationality_id").ToString();
                    contactCountryTextBox.Text = jobCategory;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void skillComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM skill WHERE name='" + this.skillComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String skillId = dataReader.GetInt32("skill_id").ToString();
                    skillTextBox.Text = skillId;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Insert employee's personal records to database.
        private void savePersonalData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO employee VALUES('" + this.pfnoTextBox.Text + "','" + this.nationalIdTextBox.Text + "','" + this.firstNameTextBox.Text + "','" + this.middleNameTextBox.Text + "','" + this.surnameTextBox.Text + "','" + this.dateOfBirthDateTimePicker.Text + "','" + this.genderComboBox.Text + "','" + this.maritalStatusCcomboBox.Text + "','" + this.salaryTextBox.Text + "','" + this.dateEmployedDateTimePicker.Text + "','" + this.jobTitleComboBox.Text + "','" + this.employeeTypeComboBox.Text + "','" + this.departmentNameComboBox.Text + "','" + this.payGradeComboBox.Text + "','" + this.statusComboBox.Text + "','" + this.leaveDaysComboBox.Text+"','NULL')",sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data registered sucessfully.......!");
                }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while inserting employee data in database.......!"+exception.Message);
            }
        } // End inserting employee data in database.

        // Clear employee personal data.
        private void clearPersonalData() {
            nationalIdTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            surnameTextBox.Text = string.Empty;
            genderComboBox.Text = string.Empty;
            maritalStatusCcomboBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            dateEmployedDateTimePicker.Text = string.Empty;
            jobTitleComboBox.Text = string.Empty;
            employeeTypeComboBox.Text = string.Empty;
            departmentNameComboBox.Text = string.Empty;
            payGradeComboBox.Text = string.Empty;
            statusComboBox.Text = string.Empty;
            leaveDaysComboBox.Text = string.Empty;
           }

        // Employee contact data.
        private void saveContactData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO emp_contactS VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.contactPhoneTextBox.Text + "','" + this.contactEmailTextBox.Text + "','" + this.contactAddressTextBox.Text + "','" + this.contactCountryTextBox.Text + "','" + this.contactCityTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee contact data registered sucessfully.......!");
                clearContactData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee contact data in database.......!" + exception.Message);
            }
        } // End employee contact data.

        // Clear employee contact data.
        private void clearContactData()
        {
            contactPhoneTextBox.Text = string.Empty;
            contactEmailTextBox.Text = string.Empty;
            contactAddressTextBox.Text = string.Empty;
            contactCountryTextBox.Text = string.Empty;
            contactCityTextBox.Text = string.Empty;
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
        // Insert skills data to database.
        private void saveSkillData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO emp_skill VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.skillTextBox.Text + "','" + this.skillYearOfExperienceComboBox.Text + "','" + this.skillCommentTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee skill data registered sucessfully.......!");
                clearSkillData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee skill data in database.......!" + exception.Message);
            }
        }// End inserting skill data to database.

        // Clear employee skill data.
        private void clearSkillData()
        {
            skillTextBox.Text = string.Empty;
            educationInstitueTextBox.Text = string.Empty;
            skillYearOfExperienceComboBox.Text = string.Empty;
            skillCommentTextBox.Text = string.Empty;
           
        }

        // Insert employee experience data to database
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

        // Inserting referees data to database.
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

        // Insert next of kin data to database.
        private void saveNextOfKinData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO next_of_kin VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.nextOfKinNamesTextBox.Text + "','" + this.nextOfKinPhoneTextBox.Text + "','" + this.nextOfKinAddressTextBox.Text + "','" + this.nextOfKinCountryTextBox.Text + "','" + this.nextOfKinCityTextBox.Text + "','" + this.nextOfKinOccupationTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee next of kin data registered sucessfully.......!");
                clearNextOfKinData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee next of kin data in database.......!" + exception.Message);
            }
        } // End inserting next of kin data to database.

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

        // Insert children in database.
        private void saveChildrenData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO emp_children VALUES(NULL,'" + this.pfnoTextBox.Text + "','" + this.childrenNamesTextBox.Text + "','" + this.childrenDateOfBirthDateTimePicker.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee children data registered sucessfully.......!");
                clearChildrenData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee children data in database.......!" + exception.Message);
            }
        } // End inserting next of kin data to database.

        // Clear employee children data.
        private void clearChildrenData()
        {
            childrenNamesTextBox.Text = string.Empty;
            childrenDateOfBirthDateTimePicker.Text = string.Empty;
        }
    }
}
