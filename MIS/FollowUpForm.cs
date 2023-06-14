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
    public partial class FollowUpForm : Form
    {
        public FollowUpForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FollowUpForm_Load(object sender, EventArgs e)
        {
            FillGrid();
            FilPurpose();
            ClearAll();            
        }
        

        private void FilPurpose()
        {
            var obj = new Manager();
            var list = obj.FillAllPurpose();
            cbxPurpose.DisplayMember = "Purpose";
            cbxPurpose.ValueMember = "PId";
            cbxPurpose.DataSource = list;
        }

        private void FillGrid()
        {
            var db = new Manager();
            var list = db.FillFollowGrid();
            dgvFollowUp.DataSource = list;
        }

        private void ClearAll()
        {
            txtFollowUpItemName.Text = string.Empty;
            txtRemark.Text = string.Empty;
            //cbxPurpose.Text = string.Empty;
            //dgvFollowUp.DataSource = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save the information?","Save information",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new FollowUpTable();

                tb.FollowUp = txtFollowUpItemName.Text.Trim();
                tb.Remark = txtRemark.Text.Trim();
                tb.PId = Convert.ToInt32(cbxPurpose.SelectedValue);

                db.FollowUpTables.Add(tb);
                db.SaveChanges();
                MessageBox.Show(@"Data save successfully.", "Save info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearAll();
                FillGrid();
                txtFollowUpItemName.Focus();
            }
            else
            {
                MessageBox.Show(@"Data save un-successfully.", "Warning info", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFollow();
        }

        private void SearchFollow()
        {
            try
            {
                var db = new MISDBEntities();

                var selector = db.FollowUpTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

                txtFollowUpItemName.Text = selector.FollowUp;
                txtRemark.Text = selector.Remark;
                cbxPurpose.SelectedValue = selector.PId;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Data not found", "Search failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtFollowUpItemName_TextChanged(object sender, EventArgs e)
        {
            if (txtFollowUpItemName.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtFollowUpItemName.Text != null)
            {
                btnSave.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                btnSearch.Enabled = false;
            }
            else if (txtSearch.Text != null)
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            var tb = new FollowUpTable();

            var selector = db.FollowUpTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

            selector.FollowUp = txtFollowUpItemName.Text.Trim();
            selector.Remark = txtRemark.Text.Trim();
            selector.PId = Convert.ToInt32(cbxPurpose.SelectedValue);
            btnEdit.Enabled = false;

            db.SaveChanges();
            FillGrid();
            ClearAll();
            btnDelete.Enabled = false;
            btnSave.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new MISDBEntities();

            var selector = db.FollowUpTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

            txtFollowUpItemName.Text = selector.FollowUp;
            txtRemark.Text = selector.Remark;
            cbxPurpose.SelectedValue = selector.PId;

            db.FollowUpTables.Remove(selector);
            db.SaveChanges();
            FillGrid();
            ClearAll();
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Visible = true;
        }
    }
}
