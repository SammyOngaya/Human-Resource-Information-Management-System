namespace HumanResourceInformationManagementSystem
{
    partial class JobCategory
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
            this.updateJobCategory = new System.Windows.Forms.Button();
            this.addJobCategory = new System.Windows.Forms.Button();
            this.jobCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchJobCategoryName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jobCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateJobCategory);
            this.groupBox1.Controls.Add(this.addJobCategory);
            this.groupBox1.Controls.Add(this.jobCategoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(77, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // updateJobCategory
            // 
            this.updateJobCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateJobCategory.Location = new System.Drawing.Point(283, 64);
            this.updateJobCategory.Name = "updateJobCategory";
            this.updateJobCategory.Size = new System.Drawing.Size(101, 32);
            this.updateJobCategory.TabIndex = 4;
            this.updateJobCategory.Text = "Update";
            this.updateJobCategory.UseVisualStyleBackColor = true;
            this.updateJobCategory.Click += new System.EventHandler(this.updateJobCategory_Click);
            // 
            // addJobCategory
            // 
            this.addJobCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addJobCategory.Location = new System.Drawing.Point(167, 64);
            this.addJobCategory.Name = "addJobCategory";
            this.addJobCategory.Size = new System.Drawing.Size(101, 32);
            this.addJobCategory.TabIndex = 3;
            this.addJobCategory.Text = "Add";
            this.addJobCategory.UseVisualStyleBackColor = true;
            this.addJobCategory.Click += new System.EventHandler(this.addJobCategory_Click);
            // 
            // jobCategoryNameTextBox
            // 
            this.jobCategoryNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.jobCategoryNameTextBox.Name = "jobCategoryNameTextBox";
            this.jobCategoryNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.jobCategoryNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // searchJobCategoryName
            // 
            this.searchJobCategoryName.Location = new System.Drawing.Point(195, 19);
            this.searchJobCategoryName.Name = "searchJobCategoryName";
            this.searchJobCategoryName.Size = new System.Drawing.Size(295, 20);
            this.searchJobCategoryName.TabIndex = 2;
            this.searchJobCategoryName.TextChanged += new System.EventHandler(this.searchJobCategoryName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchJobCategoryName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(598, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // jobCategoryDataGridView
            // 
            this.jobCategoryDataGridView.AllowUserToOrderColumns = true;
            this.jobCategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.jobCategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobCategoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobCategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jobCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobCategoryDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.jobCategoryDataGridView.Location = new System.Drawing.Point(598, 82);
            this.jobCategoryDataGridView.Name = "jobCategoryDataGridView";
            this.jobCategoryDataGridView.Size = new System.Drawing.Size(515, 365);
            this.jobCategoryDataGridView.TabIndex = 5;
            // 
            // JobCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.jobCategoryDataGridView);
            this.Name = "JobCategory";
            this.Text = "JobCategory";
            this.Load += new System.EventHandler(this.JobCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateJobCategory;
        private System.Windows.Forms.Button addJobCategory;
        private System.Windows.Forms.TextBox jobCategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchJobCategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView jobCategoryDataGridView;
    }
}