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
    public partial class Skill : Form
    {
        public Skill()
        {
            InitializeComponent();
            showSkill();
            searchSkill();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void Skill_Load(object sender, EventArgs e)
        {

        }

        private void addSkill_Click(object sender, EventArgs e)
        {
            // Insert skills into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `skill` VALUES(NULL,'" + this.skillNameTextBox.Text + "','" + this.descriptionTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                showSkill();
                MessageBox.Show("Skill added successfully!");
                clearSkillData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding skill to the database, : " + exception.Message);
            }
        } // End addSkill method


        // Show skills in gridview
        public void showSkill()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM skill", sqlConnection);
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

        } // End showSkill method.



        // Search department
        public void searchSkill()
        {
            searchSkillName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchSkillName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM skill", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching skill, : " + exception.Message);
            }

            searchSkillName.AutoCompleteCustomSource = collection;

        }// End search skill name

        // Show skill data
        public void skillData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM skill WHERE name='" + this.searchSkillName.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    String description = reader.GetString("description");

                    skillNameTextBox.Text = name;
                    descriptionTextBox.Text = description;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching skill, : " + exception.Message);
            }


        }

        private void searchSkillName_TextChanged(object sender, EventArgs e)
        {
            skillData();
        }

        private void updateSkill_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE skill SET name='" + this.skillNameTextBox.Text + "', description='" + this.descriptionTextBox.Text + "' WHERE name='" + this.searchSkillName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Skill updated successfully!");
                clearSkillData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating skill, : " + exception.Message);
            }

            showSkill();
        } // End update department

        // Clear job skill data.
        private void clearSkillData()
        {
            skillNameTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
