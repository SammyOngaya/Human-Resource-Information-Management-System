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
    public partial class AddMoreEmployeeChildren : Form
    {
        public AddMoreEmployeeChildren(string pfno)
        {
            InitializeComponent();
            pfnoTextBox.Text = pfno;

            showEmployeeChildren();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

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
                showEmployeeChildren();
                clearChildrenData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting employee children data in database.......!" + exception.Message);
            }
            
        }


        // Show employee children in gridview
        public void showEmployeeChildren()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM emp_children ", sqlConnection);
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

        // Clear employee children data.
        private void clearChildrenData()
        {
            childrenNamesTextBox.Text = string.Empty;
            childrenDateOfBirthDateTimePicker.Text = string.Empty;
        }

        private void AddMoreEmployeeChildren_Load(object sender, EventArgs e)
        {

        }
    }
}
