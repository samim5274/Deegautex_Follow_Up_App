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
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                SaveInfo();
                ClearText();
            }
            else if (btnSave.Text=="Edit")
            {
                EditInfo();
                ClearText();
            }
        }

        private void EditInfo()
        {
            var db = new MISDBEntities();

            var info = db.PersonInfoTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

            info.P_Name = txtName.Text.Trim();
            info.P_PostId = Convert.ToInt32(cbxPost.SelectedValue);
            info.P_Phone = Convert.ToInt32(txtPhone.Text.Trim());
            info.P_Remark = txtRemark.Text.Trim();
            info.P_Brand = txtDeviceBrand.Text.Trim();
            info.P_DeviceLocation = txtDeviceLocation.Text.Trim();
            info.P_DeviceSerial = txtDeviceSerial.Text.Trim();

            db.SaveChanges();
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void SaveInfo()
        {
            if (MessageBox.Show("Are you sure to save the information?", "Save information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new PersonInfoTable();

                tb.P_Name = txtName.Text.Trim();
                tb.P_Phone = Convert.ToInt32(txtPhone.Text.Trim());
                tb.P_PostId = Convert.ToInt32(cbxPost.SelectedValue);
                tb.P_Remark = txtRemark.Text.Trim();
                tb.P_Brand = txtDeviceBrand.Text.Trim();
                tb.P_DeviceSerial = txtDeviceSerial.Text.Trim();
                tb.P_DeviceLocation = txtDeviceLocation.Text.Trim();

                db.PersonInfoTables.Add(tb);
                db.SaveChanges();
                MessageBox.Show(@"Data Save Successfully. Thank you.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(@"Data save un-successfully.", "Warning info", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbxPost.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtDeviceBrand.Text = string.Empty;
            txtDeviceSerial.Text = string.Empty;
            txtDeviceLocation.Text = string.Empty;
            txtSearch.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Text = "Save";
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {
            FillPost();
            ClearText();
        }

        private void FillPost()
        {
            var obj = new Manager();
            var list = obj.FillAllPost();
            cbxPost.DisplayMember = "PostName";
            cbxPost.ValueMember = "Id";
            cbxPost.DataSource = list;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtName.Text != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtPhone.Text != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new MISDBEntities();

                var selector = db.PersonInfoTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

                txtName.Text = selector.P_Name;
                cbxPost.SelectedValue = selector.P_PostId;
                txtPhone.Text = selector.P_Phone.ToString();
                txtRemark.Text = selector.P_Remark;
                txtDeviceBrand.Text = selector.P_Brand;
                txtDeviceLocation.Text = selector.P_DeviceLocation;
                txtDeviceSerial.Text = selector.P_DeviceSerial;
                btnSave.Enabled = true;
                btnSave.Text = "Edit";
                btnDelete.Enabled = true;

            }
            catch(Exception)
            {
                MessageBox.Show(@"Data not found", "Search failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text=="")
            {
                btnSearch.Enabled = false;
            }
            else if (txtSearch.Text != null)
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new MISDBEntities();

            var selector = db.PersonInfoTables.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

            db.PersonInfoTables.Remove(selector);
            ClearText();
            btnSave.Enabled = false;
            btnSearch.Enabled = false;
        }
    }
}
