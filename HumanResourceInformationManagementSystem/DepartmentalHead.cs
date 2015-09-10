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
    public partial class DepartmentalHead : Form
    {
        public DepartmentalHead()
        {
            InitializeComponent();
            showDepartmentalHeads();
            searchDepartmentalHeads();
            searchDepartmentName();
            searchStaffId();
        }


        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void DepartmentalHead_Load(object sender, EventArgs e)
        {

        }

        private void addDepartmentalHead_Click(object sender, EventArgs e)
        {
            // Insert departmental head into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `departmental_heads` VALUES('" + this.departmentalHeadDepartmentNameTextBox.Text + "','" + this.departmentaHeadStaffIdTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Departmental head added successfully!");
                showDepartmentalHeads();
                clearDepartmentalHeadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding departmental head to the database, : " + exception.Message);
            }
        } // End addDepartmental head method

        // Clear departmental head data
        private void clearDepartmentalHeadData() {
            departmentalHeadDepartmentNameTextBox.Text = string.Empty;
            departmentaHeadStaffIdTextBox.Text = string.Empty;
        }

        // Show departmental heads in gridview
        public void showDepartmentalHeads()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM departmental_heads", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                departmentalHeadDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        } // End showDepartmental heads method.

        // Search departmental heads
        public void searchDepartmentalHeads()
        {
            searchDepartmentalHeadStaffIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchDepartmentalHeadStaffIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM departmental_heads", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetInt64("pfno").ToString();
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching departmental head, : " + exception.Message);
            }

            searchDepartmentalHeadStaffIdTextBox.AutoCompleteCustomSource = collection;

        }// End search departmental head name

        // Show departmental head data
        public void departmentalHeadsData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM departmental_heads WHERE pfno='" + this.searchDepartmentalHeadStaffIdTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String department = reader.GetString("department_name");
                    String pfno = reader.GetString("pfno");

                    departmentalHeadDepartmentNameTextBox.Text = department;
                    departmentaHeadStaffIdTextBox.Text = pfno;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching department, : " + exception.Message);
            }


        }// End show departmental head data.

        private void searchDepartmentalHeadStaffIdTextBox_TextChanged(object sender, EventArgs e)
        {
            departmentalHeadsData();
        }

        // Search departmentId
        public void searchDepartmentName()
        {
            departmentalHeadDepartmentNameTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            departmentalHeadDepartmentNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                MessageBox.Show("Error has occured while seraching department name, : " + exception.Message);
            }

            departmentalHeadDepartmentNameTextBox.AutoCompleteCustomSource = collection;

        }// End search department name

        // Search staff id
        public void searchStaffId()
        {
            departmentaHeadStaffIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            departmentaHeadStaffIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                MessageBox.Show("Error has occured while seraching staff id, : " + exception.Message);
            }

            departmentaHeadStaffIdTextBox.AutoCompleteCustomSource = collection;

        }// End search staff id.

        // Delete departmental head.
        private void deleteDepartmentalHead_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM departmental_heads WHERE pfno='"+this.searchDepartmentalHeadStaffIdTextBox.Text+"'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Departmental head deleted successfully.....!");
                showDepartmentalHeads();
                clearDepartmentalHeadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching staff id, : " + exception.Message);
            }
        }
    }
}
