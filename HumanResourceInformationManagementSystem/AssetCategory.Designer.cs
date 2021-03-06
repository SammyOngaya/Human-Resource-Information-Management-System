﻿namespace HumanResourceInformationManagementSystem
{
    partial class AssetCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetCategory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateAssetCategory = new System.Windows.Forms.Button();
            this.addAssetCategory = new System.Windows.Forms.Button();
            this.assetCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchAssetCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.assetCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateAssetCategory);
            this.groupBox1.Controls.Add(this.addAssetCategory);
            this.groupBox1.Controls.Add(this.assetCategoryTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(112, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            // 
            // updateAssetCategory
            // 
            this.updateAssetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAssetCategory.Location = new System.Drawing.Point(302, 67);
            this.updateAssetCategory.Name = "updateAssetCategory";
            this.updateAssetCategory.Size = new System.Drawing.Size(101, 32);
            this.updateAssetCategory.TabIndex = 4;
            this.updateAssetCategory.Text = "Update";
            this.updateAssetCategory.UseVisualStyleBackColor = true;
            this.updateAssetCategory.Click += new System.EventHandler(this.updateAssetCategory_Click);
            // 
            // addAssetCategory
            // 
            this.addAssetCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssetCategory.Location = new System.Drawing.Point(186, 67);
            this.addAssetCategory.Name = "addAssetCategory";
            this.addAssetCategory.Size = new System.Drawing.Size(101, 32);
            this.addAssetCategory.TabIndex = 3;
            this.addAssetCategory.Text = "Add";
            this.addAssetCategory.UseVisualStyleBackColor = true;
            this.addAssetCategory.Click += new System.EventHandler(this.addAssetCategory_Click);
            // 
            // assetCategoryTextBox
            // 
            this.assetCategoryTextBox.Location = new System.Drawing.Point(167, 30);
            this.assetCategoryTextBox.Name = "assetCategoryTextBox";
            this.assetCategoryTextBox.Size = new System.Drawing.Size(295, 20);
            this.assetCategoryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asset Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Id";
            // 
            // searchAssetCategoryIdTextBox
            // 
            this.searchAssetCategoryIdTextBox.Location = new System.Drawing.Point(195, 19);
            this.searchAssetCategoryIdTextBox.Name = "searchAssetCategoryIdTextBox";
            this.searchAssetCategoryIdTextBox.Size = new System.Drawing.Size(295, 20);
            this.searchAssetCategoryIdTextBox.TabIndex = 2;
            this.searchAssetCategoryIdTextBox.TextChanged += new System.EventHandler(this.searchAssetCategoryIdTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchAssetCategoryIdTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(633, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // assetCategoryDataGridView
            // 
            this.assetCategoryDataGridView.AllowUserToOrderColumns = true;
            this.assetCategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.assetCategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assetCategoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assetCategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assetCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assetCategoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.assetCategoryDataGridView.Location = new System.Drawing.Point(633, 74);
            this.assetCategoryDataGridView.Name = "assetCategoryDataGridView";
            this.assetCategoryDataGridView.Size = new System.Drawing.Size(515, 365);
            this.assetCategoryDataGridView.TabIndex = 5;
            // 
            // AssetCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 447);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.assetCategoryDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssetCategory";
            this.Load += new System.EventHandler(this.AssetCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateAssetCategory;
        private System.Windows.Forms.Button addAssetCategory;
        private System.Windows.Forms.TextBox assetCategoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchAssetCategoryIdTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView assetCategoryDataGridView;
    }
}