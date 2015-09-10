namespace HumanResourceInformationManagementSystem
{
    partial class JobTitle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JobCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.jobCategoryForeignKeyTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateJobTitle = new System.Windows.Forms.Button();
            this.addJobTitle = new System.Windows.Forms.Button();
            this.jobTitleNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jobTitleDataGridView = new System.Windows.Forms.DataGridView();
            this.searchJobTitleName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitleDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JobCategoryComboBox);
            this.groupBox1.Controls.Add(this.jobCategoryForeignKeyTextBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updateJobTitle);
            this.groupBox1.Controls.Add(this.addJobTitle);
            this.groupBox1.Controls.Add(this.jobTitleNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 304);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // JobCategoryComboBox
            // 
            this.JobCategoryComboBox.FormattingEnabled = true;
            this.JobCategoryComboBox.Location = new System.Drawing.Point(167, 88);
            this.JobCategoryComboBox.Name = "JobCategoryComboBox";
            this.JobCategoryComboBox.Size = new System.Drawing.Size(295, 21);
            this.JobCategoryComboBox.TabIndex = 10;
            this.JobCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.JobCategoryComboBox_SelectedIndexChanged);
            // 
            // jobCategoryForeignKeyTextBox
            // 
            this.jobCategoryForeignKeyTextBox.Location = new System.Drawing.Point(194, 62);
            this.jobCategoryForeignKeyTextBox.Name = "jobCategoryForeignKeyTextBox";
            this.jobCategoryForeignKeyTextBox.Size = new System.Drawing.Size(168, 20);
            this.jobCategoryForeignKeyTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(167, 155);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 20);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Category";
            // 
            // updateJobTitle
            // 
            this.updateJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateJobTitle.Location = new System.Drawing.Point(273, 244);
            this.updateJobTitle.Name = "updateJobTitle";
            this.updateJobTitle.Size = new System.Drawing.Size(101, 32);
            this.updateJobTitle.TabIndex = 4;
            this.updateJobTitle.Text = "Update";
            this.updateJobTitle.UseVisualStyleBackColor = true;
            this.updateJobTitle.Click += new System.EventHandler(this.updateJobTitle_Click);
            // 
            // addJobTitle
            // 
            this.addJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJobTitle.Location = new System.Drawing.Point(157, 244);
            this.addJobTitle.Name = "addJobTitle";
            this.addJobTitle.Size = new System.Drawing.Size(101, 32);
            this.addJobTitle.TabIndex = 3;
            this.addJobTitle.Text = "Add";
            this.addJobTitle.UseVisualStyleBackColor = true;
            this.addJobTitle.Click += new System.EventHandler(this.addJobTitle_Click);
            // 
            // jobTitleNameTextBox
            // 
            this.jobTitleNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.jobTitleNameTextBox.Name = "jobTitleNameTextBox";
            this.jobTitleNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.jobTitleNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Title";
            // 
            // jobTitleDataGridView
            // 
            this.jobTitleDataGridView.AllowUserToOrderColumns = true;
            this.jobTitleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.jobTitleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobTitleDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobTitleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobTitleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobTitleDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.jobTitleDataGridView.Location = new System.Drawing.Point(615, 85);
            this.jobTitleDataGridView.Name = "jobTitleDataGridView";
            this.jobTitleDataGridView.Size = new System.Drawing.Size(515, 365);
            this.jobTitleDataGridView.TabIndex = 11;
            // 
            // searchJobTitleName
            // 
            this.searchJobTitleName.Location = new System.Drawing.Point(195, 19);
            this.searchJobTitleName.Name = "searchJobTitleName";
            this.searchJobTitleName.Size = new System.Drawing.Size(295, 20);
            this.searchJobTitleName.TabIndex = 2;
            this.searchJobTitleName.TextChanged += new System.EventHandler(this.searchJobTitleName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchJobTitleName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(615, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Title";
            // 
            // JobTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jobTitleDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Name = "JobTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobTitle";
            this.Load += new System.EventHandler(this.JobTitle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobTitleDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateJobTitle;
        private System.Windows.Forms.Button addJobTitle;
        private System.Windows.Forms.TextBox jobTitleNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView jobTitleDataGridView;
        private System.Windows.Forms.TextBox searchJobTitleName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobCategoryForeignKeyTextBox;
        private System.Windows.Forms.ComboBox JobCategoryComboBox;
    }
}