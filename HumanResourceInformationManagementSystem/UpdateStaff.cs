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
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
            showcontactData();
            searchStaffId();
            searchInstitutionName();
            searchSkillName();
            searchEployeeExperienceJobTitleName();
            searchEployeeRefereesPhoneName();
            searchEployeeNextOfKinPhoneName();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        // Search staff id
        public void searchStaffId()
        {
            searchStaffIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchStaffIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM employee", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("pfno");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching staff, : " + exception.Message);
            }

            searchStaffIdTextBox.AutoCompleteCustomSource = collection;

        }// End search staff id

        // Show staff data
        public void departmentData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM employee WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                   
                    String nationalId = reader.GetString("national_id");
                    String firstName = reader.GetString("fname");
                    String middleName = reader.GetString("mname");
                    String surname = reader.GetString("lname");
                    String dateOfBirth = reader.GetString("dob");
                    String gender = reader.GetString("gender");
                    String maritalStatus = reader.GetString("marital_status");
                    String dateEmployed = reader.GetString("doe");
                    String jobTitle = reader.GetString("designation");
                    String employeeType = reader.GetString("employee_type");
                    String salary = reader.GetString("salary");
                    String departmentName = reader.GetString("department_name");
                    String payGrade = reader.GetString("pay_grade");
                    String status = reader.GetString("status");
                    String leaveDays = reader.GetString("leave_days");


                    nationalIdTextBox.Text = nationalId;
                    firstNameTextBox.Text = firstName;
                    middleNameTextBox.Text = middleName;
                    surnameTextBox.Text = surname;
                    dateOfBirthDateTimePicker.Text=dateOfBirth;
                    genderComboBox.Text = gender;
                    maritalStatusCcomboBox.Text = maritalStatus;
                    dateEmployedDateTimePicker.Text = dateEmployed;
                    jobTitleComboBox.Text = jobTitle;
                    employeeTypeComboBox.Text = employeeType;
                    salaryTextBox.Text = salary;
                    departmentNameComboBox.Text = departmentName;
                    payGradeComboBox.Text = payGrade;
                    statusComboBox.Text = status;
                    leaveDaysComboBox.Text = leaveDays;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching staff, : " + exception.Message);
            }


        } // End show staff data

        // Show contacts data
        public void contactData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_contacts WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String phone = reader.GetString("phone");
                    String email = reader.GetString("email");
                    String address = reader.GetString("postal");
                    String city = reader.GetString("city");
                    String country = reader.GetString("nationality_id");
                   


                    contactPhoneTextBox.Text = phone;
                    contactEmailTextBox.Text = email;
                    contactAddressTextBox.Text = address;
                    contactCityTextBox.Text = city;
                    countryComboBox.Text = country;
                   
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching contact data, : " + exception.Message);
            }


        } // End show staff data

        private void UpdateStaff_Load(object sender, EventArgs e)
        {

        }

        private void searchStaffIdTextBox_TextChanged(object sender, EventArgs e)
        {
            contactData(); 
            departmentData();
            showEmployeeContactsData();
            
            
        }
        // Show contacts in gridview
        public void showcontactData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_contacts ", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                contactDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show Contacs method.

        // Show contacts in gridview
        public void showEmployeeContactsData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_contacts WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                contactDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show contact method.

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

        }// End populate education combo box method.


        // Search institution name
        public void searchInstitutionName()
        {
            searchInstitueTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchInstitueTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_education", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("institute");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching institute name, : " + exception.Message);
            }

            searchInstitueTextBox.AutoCompleteCustomSource = collection;

        }// End search institute name

        // Show education data
        public void instituteData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_education WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND institute='" + this.searchInstitueTextBox.Text+ "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String educationId = reader.GetString("education_id");
                    String major = reader.GetString("major");
                    String year = reader.GetString("year");
                    String score = reader.GetString("score");
                    String startDate = reader.GetString("start_date");
                    String endDate = reader.GetString("end_date");
                    

                    educationLevelComboBox.Text = educationId;
                    educationCourseTextBox.Text = major;
                    educationYearCompletedTextBox.Text = year;
                    educationScoreTextBox.Text = score;
                    educationStartDateDateTimePicker.Text = startDate;
                    educationEndDateDateTimePicker.Text = endDate;
                   

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching education data, : " + exception.Message);
            }


        }// End show education data

        private void searchInstitueTextBox_TextChanged(object sender, EventArgs e)
        {
            instituteData();
            showEeducationData();
        }

        // Show education in gridview
        public void showEeducationData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_education WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
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


        // Search skill name
        public void searchSkillName()
        {
            skillTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            skillTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_skill", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("emp_skill_id");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching skill name, : " + exception.Message);
            }

            skillTextBox.AutoCompleteCustomSource = collection;

        }// End search skill name

        // Show employee skills data
        public void skillData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_skill WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND emp_skill_id='" + this.skillTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String yearsOfExperience = reader.GetString("years_of_experience");
                    String comments = reader.GetString("comments");
                   

                    skillYearOfExperienceComboBox.Text = yearsOfExperience;
                    skillCommentTextBox.Text = comments;
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching skill data, : " + exception.Message);
            }


        }// End show employee skills data


        // Show employee skills in gridview
        public void showEmployeeSkill()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_skill WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                skillDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show skill method.

        private void skillTextBox_TextChanged(object sender, EventArgs e)
        {
            skillData();
            showEmployeeSkill();
        }


        // Search experience job title.
        public void searchEployeeExperienceJobTitleName()
        {
            searchJobTitleTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchJobTitleTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM work_experience", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("job_title");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee's years of experience, : " + exception.Message);
            }

            searchJobTitleTextBox.AutoCompleteCustomSource = collection;

        }// End search employee experience job title.

        // Show employee experience data
        public void experienceData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM work_experience WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND job_title='" + this.searchJobTitleTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String numberOfYears = reader.GetString("no_of_years");

                    experienceNumberOfYearsComboBox.Text = numberOfYears;
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee experience data, : " + exception.Message);
            }


        }// End show employee experience data


        // Show employee experience in gridview
        public void showEmployeeExperience()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM work_experience WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
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

        private void searchJobTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            experienceData();
            showEmployeeExperience();
        }

      
        // Show employee children data
        public void childrenData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_children WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND emp_children_id='" + this.childrenIdTextBox.Text+ "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String name = reader.GetString("name");
                    String dateOfBirth = reader.GetString("dob");

                    childrenNamesTextBox.Text = name;
                    childrenDateOfBirthDateTimePicker.Text = dateOfBirth;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee children data, : " + exception.Message);
            }


        }// End show employee children data


        // Show employee children in gridview
        public void showEmployeeChildren()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_children WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                childrenDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show employee children method.

        // Search referees phone.
        public void searchEployeeRefereesPhoneName()
        {
            serachRefereesPhoneTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            serachRefereesPhoneTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM referees", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("phone");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee's referees phone, : " + exception.Message);
            }

            serachRefereesPhoneTextBox.AutoCompleteCustomSource = collection;

        }// End search employee referees.

        // Show employee referees data
        public void refereeData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM referees WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND phone='" + this.serachRefereesPhoneTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String name = reader.GetString("name");
                    String address = reader.GetString("address");
                    String country = reader.GetString("country");
                    String city = reader.GetString("city");
                    String occupation = reader.GetString("occupation");

                    refereesNamesTextBox.Text = name;
                    refereesAddressTextBox.Text = address;
                    refereesComboBox.Text = country;
                    refereesCityTextBox.Text = city;
                    refereesOccupationTextBox.Text = occupation;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee referees data, : " + exception.Message);
            }


        }// End show employee referees data


        // Show employee referees in gridview
        public void showEmployeeReferee()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM referees WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
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

        private void serachRefereesPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
           refereeData();
           showEmployeeReferee();
        }

        // Search referees phone.
        public void searchEployeeNextOfKinPhoneName()
        {
            nextOfKinPhoneTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nextOfKinPhoneTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM next_of_kin", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("phone");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee's next of kin phone, : " + exception.Message);
            }

            nextOfKinPhoneTextBox.AutoCompleteCustomSource = collection;

        }// End search employee next of kin.

        // Show employee referees data
        public void nextOfKinData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM next_of_kin WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND phone='" + this.nextOfKinPhoneTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    String name = reader.GetString("name");
                    String address = reader.GetString("address");
                    String country = reader.GetString("country");
                    String city = reader.GetString("city");
                    String occupation = reader.GetString("occupation");

                    nextOfKinNamesTextBox.Text = name;
                    nextOfKinAddressTextBox.Text = address;
                    nextOfKinComboBox.Text = country;
                    nextOfKinCityTextBox.Text = city;
                    nextOfKinOccupationTextBox.Text = occupation;


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching employee next of kin data, : " + exception.Message);
            }


        }// End show employee next of kin data


        // Show employee next of kin in gridview
        public void showEmployeeNextOfKin()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM next_of_kin WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
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

        }// End show employee next of kin method.

        private void nextOfKinPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            nextOfKinData();
            showEmployeeNextOfKin();
        }


        private void updatePersonalData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE employee SET national_id='" + this.nationalIdTextBox.Text + "',fname='" + this.firstNameTextBox.Text + "', mname='" + this.middleNameTextBox.Text + "',lname='" + this.surnameTextBox.Text + "', dob='" + this.dateOfBirthDateTimePicker.Text + "', gender='" + this.genderComboBox.Text + "',marital_status='" + this.maritalStatusCcomboBox.Text + "',salary='" + this.salaryTextBox.Text + "',doe='" + this.dateEmployedDateTimePicker.Text + "',designation='" + this.jobTitleComboBox.Text + "',employee_type='" + this.employeeTypeComboBox.Text + "',department_name='" + this.departmentNameComboBox.Text + "',pay_grade='" + this.payGradeComboBox.Text + "',status='" + this.statusComboBox.Text + "',leave_days='" + this.leaveDaysComboBox.Text + "' WHERE pfno='" + this.searchStaffIdTextBox.Text+ "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateContactData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE emp_contacts SET phone='" + this.contactPhoneTextBox.Text + "',email='" + this.contactEmailTextBox.Text + "', postal='" + this.contactAddressTextBox.Text + "',city='" + this.contactCityTextBox.Text + "', nationality_id='" + this.countryComboBox.Text + "' WHERE pfno='" + this.searchStaffIdTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeContactsData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateChildrenData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE emp_children SET name='" + this.childrenNamesTextBox.Text + "',dob='" + this.childrenDateOfBirthDateTimePicker.Text + "' WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND emp_children_id='" + this.childrenIdTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeChildren();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateEducationData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE emp_education SET education_id='" + this.educationLevelComboBox.Text + "',major='" + this.educationCourseTextBox.Text + "',year='" + this.educationYearCompletedTextBox.Text + "',score='" + this.educationScoreTextBox.Text + "',start_date='" + this.educationStartDateDateTimePicker.Text + "' ,end_date='" + this.educationEndDateDateTimePicker.Text + "' WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND institute='" + this.searchInstitueTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEeducationData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateSkillData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE emp_skill SET years_of_experience='" + this.skillYearOfExperienceComboBox.Text + "',comments='" + this.skillCommentTextBox.Text + "' WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND emp_skill_id='" + this.skillTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeSkill();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateEmployeeExperienceData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE work_experience SET no_of_years='" + this.experienceNumberOfYearsComboBox.Text + "'  WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND job_title='" + this.searchJobTitleTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeExperience();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateRefereesDdata_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE referees SET name='" + this.refereesNamesTextBox.Text + "' ,address='" + this.refereesAddressTextBox.Text + "',country='" + this.refereesComboBox.Text + "',city='" + this.refereesCityTextBox.Text + "',occupation='" + this.refereesOccupationTextBox.Text + "'  WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND phone='" + this.serachRefereesPhoneTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeReferee();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void updateNextOfKinData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE next_of_kin SET name='" + this.nextOfKinNamesTextBox.Text + "' ,address='" + this.nextOfKinAddressTextBox.Text + "',country='" + this.nextOfKinComboBox.Text + "',city='" + this.nextOfKinCityTextBox.Text + "',occupation='" + this.nextOfKinOccupationTextBox.Text + "'  WHERE pfno='" + this.searchStaffIdTextBox.Text + "' AND phone='" + this.nextOfKinPhoneTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Employee data updated sucessfully.......!");
                showEmployeeNextOfKin();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating employee data in database.......!" + exception.Message);
            }
        }

        private void childrenIdTextBox_TextChanged(object sender, EventArgs e)
        {
            childrenData();
            showEmployeeChildren();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            AddMoreEmployeeChildren addMoreEmployeeChild = new AddMoreEmployeeChildren(searchStaffIdTextBox.Text);
            addMoreEmployeeChild.ShowDialog();
        }

        private void addNextOfKinButton_Click(object sender, EventArgs e)
        {
            AddNextOfKin addNextOfKin = new AddNextOfKin(searchStaffIdTextBox.Text);
            addNextOfKin.ShowDialog();
        }

        private void addRefereesButton_Click(object sender, EventArgs e)
        {
            AddReferees addReferees = new AddReferees(searchStaffIdTextBox.Text);
            addReferees.ShowDialog();
        }

        private void addExperienceButton_Click(object sender, EventArgs e)
        {
            AddExperience addExperience = new AddExperience(searchStaffIdTextBox.Text);
            addExperience.ShowDialog();
        }

        private void addSkillButton_Click(object sender, EventArgs e)
        {
            AddSkill addSkill = new AddSkill(searchStaffIdTextBox.Text);
            addSkill.ShowDialog();
        }

        private void addEducationButton_Click(object sender, EventArgs e)
        {
            AddEducation addEducation = new AddEducation(searchStaffIdTextBox.Text);
            addEducation.ShowDialog();
        }
      
    }
}
