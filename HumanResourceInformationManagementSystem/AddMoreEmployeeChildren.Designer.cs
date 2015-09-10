namespace HumanResourceInformationManagementSystem
{
    partial class AddMoreEmployeeChildren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMoreEmployeeChildren));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.childrenNamesTextBox = new System.Windows.Forms.TextBox();
            this.childrenDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveChildrenData = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.childrenDataGridView = new System.Windows.Forms.DataGridView();
            this.pfnoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pfnoTextBox);
            this.groupBox5.Controls.Add(this.childrenNamesTextBox);
            this.groupBox5.Controls.Add(this.childrenDateOfBirthDateTimePicker);
            this.groupBox5.Controls.Add(this.saveChildrenData);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Location = new System.Drawing.Point(38, 50);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 229);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Children";
            // 
            // childrenNamesTextBox
            // 
            this.childrenNamesTextBox.Location = new System.Drawing.Point(176, 53);
            this.childrenNamesTextBox.Name = "childrenNamesTextBox";
            this.childrenNamesTextBox.Size = new System.Drawing.Size(261, 20);
            this.childrenNamesTextBox.TabIndex = 42;
            // 
            // childrenDateOfBirthDateTimePicker
            // 
            this.childrenDateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.childrenDateOfBirthDateTimePicker.Location = new System.Drawing.Point(176, 101);
            this.childrenDateOfBirthDateTimePicker.Name = "childrenDateOfBirthDateTimePicker";
            this.childrenDateOfBirthDateTimePicker.Size = new System.Drawing.Size(261, 20);
            this.childrenDateOfBirthDateTimePicker.TabIndex = 37;
            // 
            // saveChildrenData
            // 
            this.saveChildrenData.Location = new System.Drawing.Point(206, 166);
            this.saveChildrenData.Name = "saveChildrenData";
            this.saveChildrenData.Size = new System.Drawing.Size(140, 27);
            this.saveChildrenData.TabIndex = 36;
            this.saveChildrenData.Text = "save";
            this.saveChildrenData.UseVisualStyleBackColor = true;
            this.saveChildrenData.Click += new System.EventHandler(this.saveChildrenData_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(25, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(112, 20);
            this.label29.TabIndex = 1;
            this.label29.Text = "Date of Birth";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(25, 53);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 20);
            this.label30.TabIndex = 0;
            this.label30.Text = "Name";
            // 
            // childrenDataGridView
            // 
            this.childrenDataGridView.AllowUserToOrderColumns = true;
            this.childrenDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.childrenDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.childrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenDataGridView.Location = new System.Drawing.Point(525, 50);
            this.childrenDataGridView.Name = "childrenDataGridView";
            this.childrenDataGridView.Size = new System.Drawing.Size(680, 388);
            this.childrenDataGridView.TabIndex = 42;
            // 
            // pfnoTextBox
            // 
            this.pfnoTextBox.Location = new System.Drawing.Point(186, 19);
            this.pfnoTextBox.Name = "pfnoTextBox";
            this.pfnoTextBox.Size = new System.Drawing.Size(234, 20);
            this.pfnoTextBox.TabIndex = 43;
            // 
            // AddMoreEmployeeChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 433);
            this.Controls.Add(this.childrenDataGridView);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMoreEmployeeChildren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMoreEmployeeChildren";
            this.Load += new System.EventHandler(this.AddMoreEmployeeChildren_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox childrenNamesTextBox;
        private System.Windows.Forms.DateTimePicker childrenDateOfBirthDateTimePicker;
        private System.Windows.Forms.Button saveChildrenData;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView childrenDataGridView;
        private System.Windows.Forms.TextBox pfnoTextBox;
    }
}