namespace HumanResourceInformationManagementSystem
{
    partial class AddExperience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExperience));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.experienceJobTitleTextBox = new System.Windows.Forms.TextBox();
            this.experienceNumberOfYearsComboBox = new System.Windows.Forms.ComboBox();
            this.saveEmployeeExperienceData = new System.Windows.Forms.Button();
            this.jobTitleExperienceComboBox = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.pfnoTextBox = new System.Windows.Forms.TextBox();
            this.experienceDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experienceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.experienceJobTitleTextBox);
            this.groupBox8.Controls.Add(this.experienceNumberOfYearsComboBox);
            this.groupBox8.Controls.Add(this.saveEmployeeExperienceData);
            this.groupBox8.Controls.Add(this.jobTitleExperienceComboBox);
            this.groupBox8.Controls.Add(this.label46);
            this.groupBox8.Controls.Add(this.label47);
            this.groupBox8.Location = new System.Drawing.Point(25, 28);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(484, 245);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Experience";
            // 
            // experienceJobTitleTextBox
            // 
            this.experienceJobTitleTextBox.Location = new System.Drawing.Point(208, 26);
            this.experienceJobTitleTextBox.Name = "experienceJobTitleTextBox";
            this.experienceJobTitleTextBox.Size = new System.Drawing.Size(229, 20);
            this.experienceJobTitleTextBox.TabIndex = 39;
            // 
            // experienceNumberOfYearsComboBox
            // 
            this.experienceNumberOfYearsComboBox.FormattingEnabled = true;
            this.experienceNumberOfYearsComboBox.Items.AddRange(new object[] {
            "Less than a year",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.experienceNumberOfYearsComboBox.Location = new System.Drawing.Point(208, 100);
            this.experienceNumberOfYearsComboBox.Name = "experienceNumberOfYearsComboBox";
            this.experienceNumberOfYearsComboBox.Size = new System.Drawing.Size(229, 21);
            this.experienceNumberOfYearsComboBox.TabIndex = 38;
            // 
            // saveEmployeeExperienceData
            // 
            this.saveEmployeeExperienceData.Location = new System.Drawing.Point(189, 170);
            this.saveEmployeeExperienceData.Name = "saveEmployeeExperienceData";
            this.saveEmployeeExperienceData.Size = new System.Drawing.Size(140, 27);
            this.saveEmployeeExperienceData.TabIndex = 36;
            this.saveEmployeeExperienceData.Text = "save";
            this.saveEmployeeExperienceData.UseVisualStyleBackColor = true;
            this.saveEmployeeExperienceData.Click += new System.EventHandler(this.saveEmployeeExperienceData_Click);
            // 
            // jobTitleExperienceComboBox
            // 
            this.jobTitleExperienceComboBox.FormattingEnabled = true;
            this.jobTitleExperienceComboBox.Location = new System.Drawing.Point(208, 52);
            this.jobTitleExperienceComboBox.Name = "jobTitleExperienceComboBox";
            this.jobTitleExperienceComboBox.Size = new System.Drawing.Size(229, 21);
            this.jobTitleExperienceComboBox.TabIndex = 5;
            this.jobTitleExperienceComboBox.SelectedIndexChanged += new System.EventHandler(this.jobTitleExperienceComboBox_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(25, 101);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(109, 20);
            this.label46.TabIndex = 1;
            this.label46.Text = "No. of Years";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(25, 53);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 20);
            this.label47.TabIndex = 0;
            this.label47.Text = "Job Title";
            // 
            // pfnoTextBox
            // 
            this.pfnoTextBox.Location = new System.Drawing.Point(233, 13);
            this.pfnoTextBox.Name = "pfnoTextBox";
            this.pfnoTextBox.Size = new System.Drawing.Size(229, 20);
            this.pfnoTextBox.TabIndex = 4;
            // 
            // experienceDataGridView
            // 
            this.experienceDataGridView.AllowUserToOrderColumns = true;
            this.experienceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.experienceDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.experienceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.experienceDataGridView.Location = new System.Drawing.Point(532, 9);
            this.experienceDataGridView.Name = "experienceDataGridView";
            this.experienceDataGridView.Size = new System.Drawing.Size(720, 388);
            this.experienceDataGridView.TabIndex = 41;
            // 
            // AddExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 409);
            this.Controls.Add(this.experienceDataGridView);
            this.Controls.Add(this.pfnoTextBox);
            this.Controls.Add(this.groupBox8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddExperience";
            this.Text = "AddExperience";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experienceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox experienceJobTitleTextBox;
        private System.Windows.Forms.ComboBox experienceNumberOfYearsComboBox;
        private System.Windows.Forms.Button saveEmployeeExperienceData;
        private System.Windows.Forms.ComboBox jobTitleExperienceComboBox;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox pfnoTextBox;
        private System.Windows.Forms.DataGridView experienceDataGridView;
    }
}