namespace HumanResourceInformationManagementSystem
{
    partial class DepartmentalHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentalHead));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteDepartmentalHead = new System.Windows.Forms.Button();
            this.departmentalHeadDepartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addDepartmentalHead = new System.Windows.Forms.Button();
            this.departmentaHeadStaffIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDepartmentalHeadStaffIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departmentalHeadDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentalHeadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteDepartmentalHead);
            this.groupBox1.Controls.Add(this.departmentalHeadDepartmentNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addDepartmentalHead);
            this.groupBox1.Controls.Add(this.departmentaHeadStaffIdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(102, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            // 
            // deleteDepartmentalHead
            // 
            this.deleteDepartmentalHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepartmentalHead.Location = new System.Drawing.Point(309, 149);
            this.deleteDepartmentalHead.Name = "deleteDepartmentalHead";
            this.deleteDepartmentalHead.Size = new System.Drawing.Size(101, 32);
            this.deleteDepartmentalHead.TabIndex = 7;
            this.deleteDepartmentalHead.Text = "Delete";
            this.deleteDepartmentalHead.UseVisualStyleBackColor = true;
            this.deleteDepartmentalHead.Click += new System.EventHandler(this.deleteDepartmentalHead_Click);
            // 
            // departmentalHeadDepartmentNameTextBox
            // 
            this.departmentalHeadDepartmentNameTextBox.Location = new System.Drawing.Point(170, 89);
            this.departmentalHeadDepartmentNameTextBox.Name = "departmentalHeadDepartmentNameTextBox";
            this.departmentalHeadDepartmentNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.departmentalHeadDepartmentNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department Name";
            // 
            // addDepartmentalHead
            // 
            this.addDepartmentalHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentalHead.Location = new System.Drawing.Point(167, 149);
            this.addDepartmentalHead.Name = "addDepartmentalHead";
            this.addDepartmentalHead.Size = new System.Drawing.Size(101, 32);
            this.addDepartmentalHead.TabIndex = 3;
            this.addDepartmentalHead.Text = "Add";
            this.addDepartmentalHead.UseVisualStyleBackColor = true;
            this.addDepartmentalHead.Click += new System.EventHandler(this.addDepartmentalHead_Click);
            // 
            // departmentaHeadStaffIdTextBox
            // 
            this.departmentaHeadStaffIdTextBox.Location = new System.Drawing.Point(167, 30);
            this.departmentaHeadStaffIdTextBox.Name = "departmentaHeadStaffIdTextBox";
            this.departmentaHeadStaffIdTextBox.Size = new System.Drawing.Size(295, 20);
            this.departmentaHeadStaffIdTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Id";
            // 
            // searchDepartmentalHeadStaffIdTextBox
            // 
            this.searchDepartmentalHeadStaffIdTextBox.Location = new System.Drawing.Point(195, 19);
            this.searchDepartmentalHeadStaffIdTextBox.Name = "searchDepartmentalHeadStaffIdTextBox";
            this.searchDepartmentalHeadStaffIdTextBox.Size = new System.Drawing.Size(295, 20);
            this.searchDepartmentalHeadStaffIdTextBox.TabIndex = 2;
            this.searchDepartmentalHeadStaffIdTextBox.TextChanged += new System.EventHandler(this.searchDepartmentalHeadStaffIdTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchDepartmentalHeadStaffIdTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(623, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // departmentalHeadDataGridView
            // 
            this.departmentalHeadDataGridView.AllowUserToOrderColumns = true;
            this.departmentalHeadDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.departmentalHeadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.departmentalHeadDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentalHeadDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.departmentalHeadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.departmentalHeadDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.departmentalHeadDataGridView.Location = new System.Drawing.Point(623, 73);
            this.departmentalHeadDataGridView.Name = "departmentalHeadDataGridView";
            this.departmentalHeadDataGridView.Size = new System.Drawing.Size(515, 365);
            this.departmentalHeadDataGridView.TabIndex = 5;
            // 
            // DepartmentalHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.departmentalHeadDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepartmentalHead";
            this.Text = "DepartmentalHead";
            this.Load += new System.EventHandler(this.DepartmentalHead_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentalHeadDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addDepartmentalHead;
        private System.Windows.Forms.TextBox departmentaHeadStaffIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDepartmentalHeadStaffIdTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView departmentalHeadDataGridView;
        private System.Windows.Forms.TextBox departmentalHeadDepartmentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteDepartmentalHead;
    }
}