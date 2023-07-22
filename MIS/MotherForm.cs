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
    public partial class MotherForm : Form
    {
        private int childFormNumber = 0;

        public MotherForm()
        {
            InitializeComponent();
        }

        private void followUpIteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new FollowUpForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void followUpReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new FollowUpWiseReportFrom();
            obj.MdiParent = this;
            obj.Show();
        }

        private void reportCheckYesNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new ReportCheckForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void giverAndReciveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new GivenAndReciveForm();
            obj.MdiParent = this;
            obj.Show();
        }


        private void moneyTypeWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MoneyTypeWiseReport();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayAndMoneyTypeWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DayAndMoneyTypeWiseReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dayWiseTransectionReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var obj = new DayWiseMoneyReportForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new PersonInfoForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new AnalysisForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void createStoreProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new CreateStoreProductForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void storeStockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new StockDetailForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void storeStockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new StockOutForm();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
