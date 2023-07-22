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
    public partial class StockDetailForm : Form
    {
        public StockDetailForm()
        {
            InitializeComponent();
        }

        private void StockDetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mISDBDataSet18.StockDetail' table. You can move, or remove it, as needed.
            this.stockDetailTableAdapter.Fill(this.mISDBDataSet18.StockDetail);
            FillAllProduct();
            clearText();
            FillReg();
            FillStock();
        }

        private void FillStock()
        {
            var obj = new Manager();
            var list = obj.GetAllStock();
            dgvStock.DataSource = list;
        }

        private void FillReg()
        {
            var db = new MISDBEntities();
            var reg = db.StockDetails.Count() + 1;
            var num = Convert.ToDateTime(dtpDate.Value);
            lblReg.Text = num.ToString("yyyyMMdd") + reg;
        }

        private void clearText()
        {
            cbxProductName.Text = string.Empty;
            txtQty.Text = string.Empty;
        }

        private void FillAllProduct()
        {
            var obj = new Manager();
            var list = obj.GetAllProduct();
            cbxProductName.DisplayMember = "P_Name";
            cbxProductName.ValueMember = "Id";
            cbxProductName.DataSource = list;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != null)
            {
                btnSave.Enabled = true;
            }
            if (txtQty.Text == "")
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you went to save product information?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new StockDetail();

                tb.Reg = Convert.ToInt32(lblReg.Text);
                tb.P_Id = Convert.ToInt32(cbxProductName.SelectedValue);
                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.Qty = Convert.ToInt32(txtQty.Text.Trim());

                db.StockDetails.Add(tb);
                db.SaveChanges();
                FillReg();
                clearText();
                FillStock();
            }
        }
    }
}
