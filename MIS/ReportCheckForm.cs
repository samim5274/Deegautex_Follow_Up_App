using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class ReportCheckForm : Form
    {
        public ReportCheckForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportCheckForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mISDBDataSet17.SP_Daily_Followup_Check' table. You can move, or remove it, as needed.
            this.sP_Daily_Followup_CheckTableAdapter.Fill(this.mISDBDataSet17.SP_Daily_Followup_Check);
            FillGrid();
            FillItem();
            ClearTextbox();
            this.dtpToday.Value = DateTime.Now;
            
        }

        private void ClearTextbox()
        {
            cbxItem.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cbYes.Checked = false;
            cbNo.Checked = false;
        }

        private void FillGrid()
        {
            this.dailyFollowUpInfoTableAdapter.Fill(this.mISDBDataSet16.DailyFollowUpInfo);
        }

        private void FillItem()
        {
            var obj = new Manager();
            var list = obj.FillItem();  
            cbxItem.DisplayMember = "FollowUp";
            cbxItem.ValueMember = "Id";
            cbxItem.DataSource = list;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDailyFollowUpInfo();
            FillGrid();
            ClearTextbox();
        }

        private void SaveDailyFollowUpInfo()
        {
            if (MessageBox.Show(@"Are you sure checked the follow up item?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new DailyFollowUpInfo();
                tb.F_Date = Convert.ToDateTime(dtpToday.Value);
                tb.F_Id = Convert.ToInt32(cbxItem.SelectedValue);
                tb.F_Check = lblCheck.Text.Trim();
                tb.Remark = txtRemark.Text.Trim();
                db.DailyFollowUpInfoes.Add(tb);
                db.SaveChanges();
                MessageBox.Show(@"Daily follow up check save sucessfully.", "Follow up save info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }            
        }

        private void cbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYes.Checked)
            {
                lblCheck.Text = "Yes";
                cbNo.Checked = false;
                btnSave.Enabled = true;
            }
            else
            {
                lblCheck.Text = "Y/N";
                btnSave.Enabled = false;
            }
        }

        private void cbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNo.Checked)
            {
                lblCheck.Text = "No";
                cbYes.Checked = false;
                btnSave.Enabled = true;
            }
            else
            {
                lblCheck.Text = "Y/N";
                btnSave.Enabled = false;
            }
        }
    }
}
