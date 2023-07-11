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
    public partial class MoneyTypeWiseReport : Form
    {
        public MoneyTypeWiseReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoneyTypeWiseReport_Load(object sender, EventArgs e)
        {
            FillMoneyType();
        }

        private void FillMoneyType()
        {
            List<Manager> list = new List<Manager>();
            list.Add(new Manager() { Id = "0", Name = "I Give" });
            list.Add(new Manager() { Id = "1", Name = "I Taking" });

            cbxMoneyType.DisplayMember = "Name";
            cbxMoneyType.ValueMember = "Id";
            cbxMoneyType.DataSource = list;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MoneyTypeWiseReportGenaret();
            FillTotalAmount();
        }

        private void FillTotalAmount()
        {
            lblMoney.Text = "0";
            for (int i = 0; i < dgvMoneyType.Rows.Count; i++)
            {
                lblMoney.Text = Convert.ToString(double.Parse(lblMoney.Text) + double.Parse(dgvMoneyType.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void MoneyTypeWiseReportGenaret()
        {
            var mtp = Convert.ToInt32(cbxMoneyType.SelectedValue);
            var mngr = new Manager();
            var list = mngr.GettMoneyTypeReport(mtp);
            dgvMoneyType.DataSource = list;
        }
    }
}
