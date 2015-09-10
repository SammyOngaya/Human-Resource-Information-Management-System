namespace HumanResourceInformationManagementSystem
{
    partial class PayGrade
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
            this.maximumSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minimumSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePayGrade = new System.Windows.Forms.Button();
            this.addPayGrade = new System.Windows.Forms.Button();
            this.payGradeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchPayGradeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payGradeDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payGradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maximumSalaryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minimumSalaryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updatePayGrade);
            this.groupBox1.Controls.Add(this.addPayGrade);
            this.groupBox1.Controls.Add(this.payGradeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(108, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "create";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maximumSalaryTextBox
            // 
            this.maximumSalaryTextBox.Location = new System.Drawing.Point(167, 155);
            this.maximumSalaryTextBox.Name = "maximumSalaryTextBox";
            this.maximumSalaryTextBox.Size = new System.Drawing.Size(295, 20);
            this.maximumSalaryTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum Salary";
            // 
            // minimumSalaryTextBox
            // 
            this.minimumSalaryTextBox.Location = new System.Drawing.Point(167, 88);
            this.minimumSalaryTextBox.Name = "minimumSalaryTextBox";
            this.minimumSalaryTextBox.Size = new System.Drawing.Size(295, 20);
            this.minimumSalaryTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minimum Salary";
            // 
            // updatePayGrade
            // 
            this.updatePayGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePayGrade.Location = new System.Drawing.Point(273, 244);
            this.updatePayGrade.Name = "updatePayGrade";
            this.updatePayGrade.Size = new System.Drawing.Size(101, 32);
            this.updatePayGrade.TabIndex = 4;
            this.updatePayGrade.Text = "Update";
            this.updatePayGrade.UseVisualStyleBackColor = true;
            this.updatePayGrade.Click += new System.EventHandler(this.updatePayGrade_Click);
            // 
            // addPayGrade
            // 
            this.addPayGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPayGrade.Location = new System.Drawing.Point(157, 244);
            this.addPayGrade.Name = "addPayGrade";
            this.addPayGrade.Size = new System.Drawing.Size(101, 32);
            this.addPayGrade.TabIndex = 3;
            this.addPayGrade.Text = "Add";
            this.addPayGrade.UseVisualStyleBackColor = true;
            this.addPayGrade.Click += new System.EventHandler(this.addPayGrade_Click);
            // 
            // payGradeNameTextBox
            // 
            this.payGradeNameTextBox.Location = new System.Drawing.Point(167, 30);
            this.payGradeNameTextBox.Name = "payGradeNameTextBox";
            this.payGradeNameTextBox.Size = new System.Drawing.Size(295, 20);
            this.payGradeNameTextBox.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchPayGradeName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(629, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "search ";
            // 
            // searchPayGradeName
            // 
            this.searchPayGradeName.Location = new System.Drawing.Point(195, 19);
            this.searchPayGradeName.Name = "searchPayGradeName";
            this.searchPayGradeName.Size = new System.Drawing.Size(295, 20);
            this.searchPayGradeName.TabIndex = 2;
            this.searchPayGradeName.TextChanged += new System.EventHandler(this.searchPayGradeName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay Grade Name";
            // 
            // payGradeDataGridView
            // 
            this.payGradeDataGridView.AllowUserToOrderColumns = true;
            this.payGradeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.payGradeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payGradeDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payGradeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.payGradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payGradeDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.payGradeDataGridView.Location = new System.Drawing.Point(629, 78);
            this.payGradeDataGridView.Name = "payGradeDataGridView";
            this.payGradeDataGridView.Size = new System.Drawing.Size(515, 365);
            this.payGradeDataGridView.TabIndex = 8;
            // 
            // PayGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.payGradeDataGridView);
            this.Name = "PayGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayGrade";
            this.Load += new System.EventHandler(this.PayGrade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payGradeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updatePayGrade;
        private System.Windows.Forms.Button addPayGrade;
        private System.Windows.Forms.TextBox payGradeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchPayGradeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView payGradeDataGridView;
        private System.Windows.Forms.TextBox maximumSalaryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minimumSalaryTextBox;
        private System.Windows.Forms.Label label3;
    }
}