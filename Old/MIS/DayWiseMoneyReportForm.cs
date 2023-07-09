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
    public partial class DayWiseMoneyReportForm : Form
    {
        public DayWiseMoneyReportForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReportGenaret();
            FillTotalTaka();
        }

        private void FillTotalTaka()
        {
            lblTotal.Text = "0";
            for (int i = 0; i < dgvDayWiseTransection.Rows.Count; i++)
            {
                lblTotal.Text = Convert.ToString(double.Parse(lblTotal.Text) + double.Parse(dgvDayWiseTransection.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void ReportGenaret()
        {
            var SDate = dtpSDate.Value;
            var EDate = dtpEDate.Value;
            var mngr = new Manager();
            var list = mngr.GetDateWiseReport(SDate, EDate);
            dgvDayWiseTransection.DataSource = list;
        }

        private void DayWiseMoneyReportForm_Load(object sender, EventArgs e)
        {
            ReportGenaret();
            FillTotalTaka();
        }
        
    }
}
