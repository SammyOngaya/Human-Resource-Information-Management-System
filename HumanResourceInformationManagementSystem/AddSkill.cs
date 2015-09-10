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
    public partial class AddSkill : Form
    {
        public AddSkill(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            skillCombo();
            showEmployeeSkill();
        }

         String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void AddSkill_Load(object sender, EventArgs e)
        {

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
                showEmployeeSkill();
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
            skillYearOfExperienceComboBox.Text = string.Empty;
            skillCommentTextBox.Text = string.Empty;
           
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


        // Show employee skills in gridview
        public void showEmployeeSkill()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_skill WHERE pfno='" + this.pfnoTextBox.Text + "'", sqlConnection);
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
    }
}
