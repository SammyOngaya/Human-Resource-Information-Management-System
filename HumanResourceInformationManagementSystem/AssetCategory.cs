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
    public partial class AssetCategory : Form
    {
        public AssetCategory()
        {
            InitializeComponent();
            showAssetCategory();
            searchAssetCategory();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

        private void AssetCategory_Load(object sender, EventArgs e)
        {

        }

        private void addAssetCategory_Click(object sender, EventArgs e)
        {
            // Insert asset category into the database.
            sqlConnection = new MySqlConnection(databaseConnection);
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO `asset_category` VALUES(NULL,'" + this.assetCategoryTextBox.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Asset category added successfully!");
                showAssetCategory();
                clearAssetCategoryData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while adding asset category to the database, : " + exception.Message);
            }
        } // End addAssetCategory method

        // Clear asset category data.
        private void clearAssetCategoryData()
        {
            assetCategoryTextBox.Text = string.Empty;
        }

        // Show asset category in gridview
        public void showAssetCategory()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset_category", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                assetCategoryDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End asset category method.

        private void updateAssetCategory_Click(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE asset_category SET category='" + this.assetCategoryTextBox.Text + "' WHERE category_id='" + this.searchAssetCategoryIdTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("asset category updated successfully!");
                showAssetCategory();
                  }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating asset category, : " + exception.Message);
            }

            showAssetCategory();
        } // End update asset category


        // Search asset category.
        public void searchAssetCategory()
        {
            searchAssetCategoryIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchAssetCategoryIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset_category", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("category_id");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching asset category id, : " + exception.Message);
            }

            searchAssetCategoryIdTextBox.AutoCompleteCustomSource = collection;

        }// End search asset category id name

        // Show asset category data
        public void assetCategoryData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset_category WHERE category_id='" + this.searchAssetCategoryIdTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("category");
                    assetCategoryTextBox.Text = name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching asset category id, : " + exception.Message);
            }


        }// End show asset category data

        private void searchAssetCategoryIdTextBox_TextChanged(object sender, EventArgs e)
        {
            assetCategoryData();
        } 
    }
}
