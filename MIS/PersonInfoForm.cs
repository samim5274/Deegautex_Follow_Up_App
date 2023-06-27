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
            SaveInfo();
            ClearText();
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
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {
            ClearText();
            FillPost();
        }

        private void FillPost()
        {
            var obj = new Manager();
            var list = obj.FillAllPost();
            cbxPost.DisplayMember = "PostName";
            cbxPost.ValueMember = "Id";
            cbxPost.DataSource = list;
        }
    }
}
