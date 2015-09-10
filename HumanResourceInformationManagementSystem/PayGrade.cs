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
    public partial class PayGrade : Form
    {
        public PayGrade()
        {
            InitializeComponent();
            showPayGrade();
            searchPayGrade();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void PayGrade_Load(object sender, EventArgs e)
        {

        }

        private void addPayGrade_Click(object sender, EventArgs e)
        {
            // Insert pay grade into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `pay_grade` VALUES(NULL,'" + this.payGradeNameTextBox.Text + "','" + this.minimumSalaryTextBox.Text + "','" + this.maximumSalaryTextBox.Text+"')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Pay Grade added successfully!");
                clearPayGradeData();
                showPayGrade();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding pay grade to the database, : " + exception.Message);
            }
        } // End addPayGrade method

        private void showPayGrade() { 
         sqlConnection = new MySqlConnection(databaseConnection);
         try
         {
             sqlConnection.Open();
             MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM pay_grade",sqlConnection);
             MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
             mysqlDataAdapter.SelectCommand = sqlCommand;
             DataTable dataTable = new DataTable();
             mysqlDataAdapter.Fill(dataTable);
             BindingSource bindingSource = new BindingSource();
             bindingSource.DataSource = dataTable;
             payGradeDataGridView.DataSource = bindingSource;

             sqlConnection.Close();

         }
         catch (Exception exception) {
             MessageBox.Show("Error has occured while displaying pay grade....! "+exception.Message);
         }
        }

        // Search PAY GRADE
        public void searchPayGrade()
        {
            searchPayGradeName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchPayGradeName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM pay_grade", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    collection.Add(name);
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching pay grade, : " + exception.Message);
            }

            searchPayGradeName.AutoCompleteCustomSource = collection;

        }// End search pay grade name

        // Show pay grade data
        public void payGradeData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM pay_grade WHERE name='" + this.searchPayGradeName.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    String minimumSalary = reader.GetString("min_salary");
                    String maximumSalary = reader.GetString("max_salary");

                    payGradeNameTextBox.Text = name;
                    minimumSalaryTextBox.Text = minimumSalary;
                    maximumSalaryTextBox.Text = maximumSalary;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching pay grade, : " + exception.Message);
            }


        }

        private void searchPayGradeName_TextChanged(object sender, EventArgs e)
        {
            payGradeData();
        }

        private void updatePayGrade_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE pay_grade SET name='" + this.payGradeNameTextBox.Text + "', min_salary='" + this.minimumSalaryTextBox.Text + "',max_salary='" + this.maximumSalaryTextBox.Text+ "' WHERE name='" + this.searchPayGradeName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                showPayGrade();
                MessageBox.Show("Pay grade updated successfully!");
                clearPayGradeData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating pay grade, : " + exception.Message);
            }

        } // End update pay grade

        // Clear job pay grade data.
        private void clearPayGradeData()
        {
            payGradeNameTextBox.Text = string.Empty;
            minimumSalaryTextBox.Text = string.Empty;
            maximumSalaryTextBox.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
