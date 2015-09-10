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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            showDepartment();
            searchDepartment();
        }

       
       String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void addDepartment_Click(object sender, EventArgs e)
        {
              // Insert department into the database.
        sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `department` VALUES('"+this.departmentNameTextBox.Text+"')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Department added successfully!");
                clearDepartmentData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding departments to the database, : " + exception.Message);
            }
        } // End addDepartment method


        // Show departments in gridview
        public void showDepartment() {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT department_name AS 'DEPARTMENT NAME' FROM department ORDER BY department_name ASC", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                departmentDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception) {
                MessageBox.Show("Error has occured while retrieving data, : "+exception.Message);
            }
        
        } // End showDepartment method.

        
      
        // Search department
        public void searchDepartment()
        {
            searchDepartmentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchDepartmentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM department", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("department_name");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching department, : " + exception.Message);
            }

            searchDepartmentName.AutoCompleteCustomSource = collection;

        }// End search department name

        // Show department data
        public void departmentData() {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM department WHERE department_name='" + this.searchDepartmentName.Text+ "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("department_name");
                     departmentNameTextBox.Text = name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching department, : " + exception.Message);
            }

        
        } // End show department data

        private void searchDepartmentName_TextChanged(object sender, EventArgs e)
        {
            departmentData();
           // filterDepartment();
           
             
        }

        // Update department
        private void updateDepartment_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE department SET department_name='" + this.departmentNameTextBox.Text + "' WHERE department_name='" + this.searchDepartmentName.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Department updated successfully!");
                clearDepartmentData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating department, : " + exception.Message);
            }

            showDepartment();
        } // End update department

        // Clear country data.
        private void clearDepartmentData()
        {
            departmentNameTextBox.Text = string.Empty;
        }
        // Filter department
        public void filterDepartment()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("'DEPARTMENT NAME' LIKE '%{0}%'", searchDepartmentName.Text);
            departmentDataGridView.DataSource = dv;
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        } // End filter 

       
    }
}
