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
    public partial class Asset : Form
    {
        public Asset()
        {
            InitializeComponent();
            assetCategoryCombo();
            showAssetData();
            searchAssetId();
        }

        String databaseConnection = "datasource=127.0.0.1; username=root; password=root; database=hrm";
        MySqlConnection sqlConnection = null;

      

        // Populate asset category combo
        public void assetCategoryCombo()
        {

            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset_category", sqlConnection);

                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String category = dataReader.GetString("category");
                    assetCategoryComboBox.Items.Add(category);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while populating combo box, : " + exception.Message);
            }
        }// End asset category combo populating

        private void assetCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset_category WHERE category='" + this.assetCategoryComboBox.Text + "'", sqlConnection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    String categoryId = dataReader.GetInt32("category_id").ToString();
                    assetCategoryForeignKeyTextBox.Text = categoryId;

                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        // Clear asset data.
        private void clearAssetData()
        {
            assetNameTextBox.Text = string.Empty;
            assetModelTextBox.Text = string.Empty;
            assetQuantityTextBox.Text = string.Empty;
            assetDescriptionTextBox.Text = string.Empty;
            assetPriceTextBox.Text = string.Empty;
            dateAcquiredDateTimePicker.Text = string.Empty;
          }
        // Show asset data in gridview
        public void showAssetData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset ", sqlConnection);
                MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter();
                mysqlDataAdapter.SelectCommand = sqlCommand;
                DataTable dataTable = new DataTable();
                mysqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                assetDataGridView.DataSource = bindingSource;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while retrieving data, : " + exception.Message);
            }

        }// End show asset method.

        // Search asset
        public void searchAssetId()
        {
            searchAssetIdTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchAssetIdTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("asset_id");
                    collection.Add(name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching asset id, : " + exception.Message);
            }

            searchAssetIdTextBox.AutoCompleteCustomSource = collection;

        }// End search asset id

        // Show asset data
        public void assetData()
        {
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM asset WHERE asset_id='" + this.searchAssetIdTextBox.Text + "'", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("name");
                    String categoryId = reader.GetString("category_id");
                    //String category = reader.GetString("category");
                    String model = reader.GetString("model");
                    String quantity = reader.GetString("quantity");
                    String description = reader.GetString("description");
                    String price = reader.GetString("price_per_quantity");
                    String dateAcquired = reader.GetString("date_aquired");

                    assetNameTextBox.Text = name;
                    assetNameTextBox.Text = categoryId;
                    assetCategoryComboBox.Text = categoryId;
                    assetQuantityTextBox.Text = quantity;
                    assetModelTextBox.Text = model;
                    assetPriceTextBox.Text = price;
                    dateAcquiredDateTimePicker.Text = dateAcquired;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while seraching asset data, : " + exception.Message);
            }


        }// End show asset data.

        private void searchAssetIdTextBox_TextChanged(object sender, EventArgs e)
        {
            assetData();
        }

         // Update asset.
        private void updateAsset_Click(object sender, EventArgs e)
        {
           
        
            sqlConnection = new MySqlConnection(databaseConnection);

            try
            {
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("UPDATE asset SET name='" + this.assetNameTextBox.Text + "',category_id='" + this.assetCategoryForeignKeyTextBox.Text + "',model='" + this.assetModelTextBox.Text + "',quantity='" + this.assetQuantityTextBox.Text + "',description='" + this.assetDescriptionTextBox.Text + "',price_per_quantity='" + this.assetPriceTextBox.Text + "',date_aquired='" + this.dateAcquiredDateTimePicker.Text + "' WHERE asset_id='" + this.searchAssetIdTextBox.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Asset updated successfully!");
                showAssetData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while updating asset, : " + exception.Message);
            }

        }// End update asset

       
        // Insert asset data to database.
        private void addAsset_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(databaseConnection);
                sqlConnection.Open();

                MySqlCommand sqlCommand = new MySqlCommand("INSERT INTO asset VALUES(NULL,'" + this.assetCategoryForeignKeyTextBox.Text + "','" + this.assetNameTextBox.Text + "','" + this.assetModelTextBox.Text + "','" + this.assetQuantityTextBox.Text + "','" + this.assetDescriptionTextBox.Text + "','" + this.assetPriceTextBox.Text + "','" + this.dateAcquiredDateTimePicker.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Asset registered sucessfully.......!");
                showAssetData();
                clearAssetData();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error has occured while inserting asset data in database.......!" + exception.Message);
            }
        } // End inserting asset data to database.

        } 
        } 

