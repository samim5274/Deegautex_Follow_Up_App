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
            // TODO: This line of code loads data into the 'mISDBDataSet8.SP_FollowUp' table. You can move, or remove it, as needed.
            this.sP_FollowUpTableAdapter.Fill(this.mISDBDataSet8.SP_FollowUp);
            FillItem();
            this.dtpToday.Value = DateTime.Now;
        }

        private void FillItem()
        {
            var obj = new Manager();
            var list = obj.FillItem();  
            cbxItem.DisplayMember = "FollowUp";
            cbxItem.ValueMember = "Id";
            cbxItem.DataSource = list;
        }
    
    }
}
