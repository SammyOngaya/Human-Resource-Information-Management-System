namespace HumanResourceInformationManagementSystem
{
    partial class AddSkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSkill));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.skillTextBox = new System.Windows.Forms.TextBox();
            this.skillYearOfExperienceComboBox = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.saveSkillData = new System.Windows.Forms.Button();
            this.skillCommentTextBox = new System.Windows.Forms.TextBox();
            this.skillComboBox = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.skillDataGridView = new System.Windows.Forms.DataGridView();
            this.pfnoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.skillTextBox);
            this.groupBox4.Controls.Add(this.skillYearOfExperienceComboBox);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.saveSkillData);
            this.groupBox4.Controls.Add(this.skillCommentTextBox);
            this.groupBox4.Controls.Add(this.skillComboBox);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Location = new System.Drawing.Point(12, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 291);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skills";
            // 
            // skillTextBox
            // 
            this.skillTextBox.Location = new System.Drawing.Point(208, 20);
            this.skillTextBox.Name = "skillTextBox";
            this.skillTextBox.Size = new System.Drawing.Size(229, 20);
            this.skillTextBox.TabIndex = 39;
            // 
            // skillYearOfExperienceComboBox
            // 
            this.skillYearOfExperienceComboBox.FormattingEnabled = true;
            this.skillYearOfExperienceComboBox.Items.AddRange(new object[] {
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
            this.skillYearOfExperienceComboBox.Location = new System.Drawing.Point(208, 100);
            this.skillYearOfExperienceComboBox.Name = "skillYearOfExperienceComboBox";
            this.skillYearOfExperienceComboBox.Size = new System.Drawing.Size(229, 21);
            this.skillYearOfExperienceComboBox.TabIndex = 38;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(25, 153);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(85, 20);
            this.label31.TabIndex = 37;
            this.label31.Text = "Comment";
            // 
            // saveSkillData
            // 
            this.saveSkillData.Location = new System.Drawing.Point(188, 226);
            this.saveSkillData.Name = "saveSkillData";
            this.saveSkillData.Size = new System.Drawing.Size(140, 27);
            this.saveSkillData.TabIndex = 36;
            this.saveSkillData.Text = "save";
            this.saveSkillData.UseVisualStyleBackColor = true;
            this.saveSkillData.Click += new System.EventHandler(this.saveSkillData_Click);
            // 
            // skillCommentTextBox
            // 
            this.skillCommentTextBox.Location = new System.Drawing.Point(208, 164);
            this.skillCommentTextBox.Name = "skillCommentTextBox";
            this.skillCommentTextBox.Size = new System.Drawing.Size(229, 20);
            this.skillCommentTextBox.TabIndex = 6;
            // 
            // skillComboBox
            // 
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.Location = new System.Drawing.Point(208, 52);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(229, 21);
            this.skillComboBox.TabIndex = 5;
            this.skillComboBox.SelectedIndexChanged += new System.EventHandler(this.skillComboBox_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(25, 101);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(171, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = "Years of Experience";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(25, 53);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "Skill";
            // 
            // skillDataGridView
            // 
            this.skillDataGridView.AllowUserToOrderColumns = true;
            this.skillDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skillDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillDataGridView.Location = new System.Drawing.Point(522, 32);
            this.skillDataGridView.Name = "skillDataGridView";
            this.skillDataGridView.Size = new System.Drawing.Size(726, 388);
            this.skillDataGridView.TabIndex = 23;
            // 
            // pfnoTextBox
            // 
            this.pfnoTextBox.Location = new System.Drawing.Point(220, 6);
            this.pfnoTextBox.Name = "pfnoTextBox";
            this.pfnoTextBox.Size = new System.Drawing.Size(229, 20);
            this.pfnoTextBox.TabIndex = 40;
            // 
            // AddSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 406);
            this.Controls.Add(this.pfnoTextBox);
            this.Controls.Add(this.skillDataGridView);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSkill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSkill";
            this.Load += new System.EventHandler(this.AddSkill_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox skillTextBox;
        private System.Windows.Forms.ComboBox skillYearOfExperienceComboBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button saveSkillData;
        private System.Windows.Forms.TextBox skillCommentTextBox;
        private System.Windows.Forms.ComboBox skillComboBox;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView skillDataGridView;
        private System.Windows.Forms.TextBox pfnoTextBox;
    }
}