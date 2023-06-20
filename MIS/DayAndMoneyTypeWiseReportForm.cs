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
    public partial class DayAndMoneyTypeWiseReportForm : Form
    {
        public DayAndMoneyTypeWiseReportForm()
        {
            InitializeComponent();
        }

        private void DayAndMoneyTypeWiseReportForm_Load(object sender, EventArgs e)
        {
            dtpSDate.Value = DateTime.Now;
            dtpEDate.Value = DateTime.Now;
            FillCombobox();
        }

        private void FillCombobox()
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
            ShowData();
            FillAmount();
        }

        private void FillAmount()
        {
            for (int i = 0; i < dgvMoneyTypeShow.Rows.Count; i++)
            {
                lblMoney.Text = Convert.ToString(double.Parse(lblMoney.Text) + double.Parse(dgvMoneyTypeShow.Rows[i].Cells[6].Value.ToString()));
            }
        }

        private void ShowData()
        {
            var Sdate = Convert.ToDateTime(dtpSDate.Value);
            var Edate = Convert.ToDateTime(dtpEDate.Value);
            var MoneyType = Convert.ToInt32(cbxMoneyType.SelectedValue);

            var mngr = new Manager();
            var list = mngr.GetDayAndMoneyTypeReport(Sdate,Edate,MoneyType);
            dgvMoneyTypeShow.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
