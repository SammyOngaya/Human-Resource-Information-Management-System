using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HumanResourceInformationManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // Display date and time on the menu bar
        private void dateTime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.dateTimeShow.Text = dateTime.ToString();
        }

        private void departmentLabel_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.ShowDialog();
        }

        private void nationalityLabel_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            JobCategory jobCategory = new JobCategory();
            jobCategory.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PayGrade payGrade = new PayGrade();
            payGrade.ShowDialog();
        }

        private void recruitmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            JobTitle jobTitle = new JobTitle();
            jobTitle.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        private void departmentalHead_Click(object sender, EventArgs e)
        {
            DepartmentalHead departmentalHead = new DepartmentalHead();
            departmentalHead.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStaff updateStaff = new UpdateStaff();
            updateStaff.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AssetCategory assetCategory = new AssetCategory();
            assetCategory.ShowDialog();
        }

        private void addAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asset asset = new Asset();
            asset.ShowDialog();
        }

     

      
    }
}
