namespace HumanResourceInformationManagementSystem
{
    partial class Asset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assetDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateAcquiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.assetPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.assetQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.assetCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.assetCategoryForeignKeyTextBox = new System.Windows.Forms.TextBox();
            this.assetModelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateAsset = new System.Windows.Forms.Button();
            this.addAsset = new System.Windows.Forms.Button();
            this.assetNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAssetIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assetDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assetDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateAcquiredDateTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.assetPriceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.assetQuantityTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.assetCategoryComboBox);
            this.groupBox1.Controls.Add(this.assetCategoryForeignKeyTextBox);
            this.groupBox1.Controls.Add(this.assetModelTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updateAsset);
            this.groupBox1.Controls.Add(this.addAsset);
            this.groupBox1.Controls.Add(this.assetNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(110, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 432);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            // 
            // assetDescriptionTextBox
            // 
            this.assetDescriptionTextBox.Location = new System.Drawing.Point(167, 350);
            this.assetDescriptionTextBox.Name = "assetDescriptionTextBox";
            this.assetDescriptionTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetDescriptionTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description";
            // 
            // dateAcquiredDateTimePicker
            // 
            this.dateAcquiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAcquiredDateTimePicker.Location = new System.Drawing.Point(167, 302);
            this.dateAcquiredDateTimePicker.Name = "dateAcquiredDateTimePicker";
            this.dateAcquiredDateTimePicker.Size = new System.Drawing.Size(295, 20);
            this.dateAcquiredDateTimePicker.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date Acquired";
            // 
            // assetPriceTextBox
            // 
            this.assetPriceTextBox.Location = new System.Drawing.Point(167, 256);
            this.assetPriceTextBox.Name = "assetPriceTextBox";
            this.assetPriceTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetPriceTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price Per Item";
            // 
            // assetQuantityTextBox
            // 
            this.assetQuantityTextBox.Location = new System.Drawing.Point(167, 196);
            this.assetQuantityTextBox.Name = "assetQuantityTextBox";
            this.assetQuantityTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetQuantityTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // assetCategoryComboBox
            // 
            this.assetCategoryComboBox.FormattingEnabled = true;
            this.assetCategoryComboBox.Location = new System.Drawing.Point(167, 88);
            this.assetCategoryComboBox.Name = "assetCategoryComboBox";
            this.assetCategoryComboBox.Size = new System.Drawing.Size(295, 21);
            this.assetCategoryComboBox.TabIndex = 10;
            this.assetCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.assetCategoryComboBox_SelectedIndexChanged);
            // 
            // assetCategoryForeignKeyTextBox
            // 
            this.assetCategoryForeignKeyTextBox.Location = new System.Drawing.Point(194, 62);
            this.assetCategoryForeignKeyTextBox.Name = "assetCategoryForeignKeyTextBox";
            this.assetCategoryForeignKeyTextBox.Size = new System.Drawing.Size(168, 20);
            this.assetCategoryForeignKeyTextBox.TabIndex = 9;
            // 
            // assetModelTextBox
            // 
            this.assetModelTextBox.Location = new System.Drawing.Point(167, 144);
            this.assetModelTextBox.Name = "assetModelTextBox";
            this.assetModelTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetModelTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // updateAsset
            // 
            this.updateAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAsset.Location = new System.Drawing.Point(261, 391);
            this.updateAsset.Name = "updateAsset";
            this.updateAsset.Size = new System.Drawing.Size(101, 32);
            this.updateAsset.TabIndex = 4;
            this.updateAsset.Text = "Update";
            this.updateAsset.UseVisualStyleBackColor = true;
            this.updateAsset.Click += new System.EventHandler(this.updateAsset_Click);
            // 
            // addAsset
            // 
            this.addAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAsset.Location = new System.Drawing.Point(145, 391);
            this.addAsset.Name = "addAsset";
            this.addAsset.Size = new System.Drawing.Size(101, 32);
            this.addAsset.TabIndex = 3;
            this.addAsset.Text = "Add";
            this.addAsset.UseVisualStyleBackColor = true;
            this.addAsset.Click += new System.EventHandler(this.addAsset_Click);
            // 
            // assetNameTextBox
            // 
            this.assetNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.assetNameTextBox.Name = "assetNameTextBox";
            this.assetNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // searchAssetIdTextBox
            // 
            this.searchAssetIdTextBox.Location = new System.Drawing.Point(195, 19);
            this.searchAssetIdTextBox.Name = "searchAssetIdTextBox";
            this.searchAssetIdTextBox.Size = new System.Drawing.Size(295, 20);
            this.searchAssetIdTextBox.TabIndex = 2;
            this.searchAssetIdTextBox.TextChanged += new System.EventHandler(this.searchAssetIdTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchAssetIdTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(631, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asset Id";
            // 
            // assetDataGridView
            // 
            this.assetDataGridView.AllowUserToOrderColumns = true;
            this.assetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.assetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assetDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assetDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assetDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.assetDataGridView.Location = new System.Drawing.Point(631, 69);
            this.assetDataGridView.Name = "assetDataGridView";
            this.assetDataGridView.Size = new System.Drawing.Size(515, 365);
            this.assetDataGridView.TabIndex = 14;
            // 
            // Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.assetDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Asset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateAcquiredDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox assetPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox assetQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox assetCategoryComboBox;
        private System.Windows.Forms.TextBox assetCategoryForeignKeyTextBox;
        private System.Windows.Forms.TextBox assetModelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateAsset;
        private System.Windows.Forms.Button addAsset;
        private System.Windows.Forms.TextBox assetNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchAssetIdTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView assetDataGridView;
        private System.Windows.Forms.TextBox assetDescriptionTextBox;
        private System.Windows.Forms.Label label8;
    }
}