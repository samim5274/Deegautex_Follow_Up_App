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
    public partial class PurposeWiseFollowUpItemFillForm : Form
    {
        public PurposeWiseFollowUpItemFillForm()
        {
            InitializeComponent();
        }

        private void PurposeWiseFollowUpItemFillForm_Load(object sender, EventArgs e)
        {
            FillPurpose();
        }

        private void FillPurpose()
        {
            var obj = new Manager();
            var list = obj.FillAllPurpose();
            cbxPurpose.DisplayMember = "Purpose";
            cbxPurpose.ValueMember = "PId";
            cbxPurpose.DataSource = list;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillFollowCombobox();
        }

        private void FillFollowCombobox()
        {
            var pid = Convert.ToInt32(cbxPurpose.SelectedValue);
            var obj = new Manager();
            var list = obj.FillFollowCombo(pid);
            cbxFollowUpItem.DisplayMember = "FollowUp";
            cbxFollowUpItem.ValueMember = "PId";
            cbxFollowUpItem.DataSource = list;
        }

        private void cbxPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFollowCombobox();
        }
    }
}
