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
    public partial class FollowUpWiseReportFrom : Form
    {
        public FollowUpWiseReportFrom()
        {
            InitializeComponent();
        }

        private void FollowUpWiseReportFrom_Load(object sender, EventArgs e)
        {
            FillGrid();
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

        private void FillGrid()
        {
            var db = new Manager();
            var list = db.FillFollowGrid();
            dgvFollowUpReport.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var PopId = Convert.ToInt32(cbxPurpose.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GetAllPurposeWiseReport(PopId);
            dgvFollowUpReport.DataSource = list;
        }
    }
}
