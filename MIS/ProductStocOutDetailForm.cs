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
    public partial class ProductStocOutDetailForm : Form
    {
        public ProductStocOutDetailForm()
        {
            InitializeComponent();
        }

        private void ProductStocOutDetailForm_Load(object sender, EventArgs e)
        {
            GetProductName();
            ClearTextBox();
            dtpDate.Value = DateTime.Now;
            FillGird();
        }

        private void GetProductName()
        {
            var obj = new Manager();
            var list = obj.GetAllProduct();
            cbxProductName.DisplayMember = "P_Name";
            cbxProductName.ValueMember = "Id";
            cbxProductName.DataSource = list;
        }

        private void ClearTextBox()
        {
            txtQty.Text = string.Empty;
            cbxProductName.Text = string.Empty;
            lblTotalQty.Text = string.Empty;
            lblTotalOut.Text = string.Empty;
        }

        private void FillGird()
        {
            var db = new MISDBEntities();
            dgvStock.DataSource = db.ProductStockDetails.ToList();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtQty.Text != null)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void cbxProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            string lblQty;
            lblQty = cbxProductName.GetItemText(cbxProductName.SelectedValue);
            var num = db.ProductStockDetails.Where(a => a.P_Id.ToString() == lblQty).FirstOrDefault();
            dgvStock.DataSource = db.ProductStockDetails.Where(a => a.P_Id.ToString() == lblQty).ToList();

            lblTotalQty.Text = "0";
            lblTotalOut.Text = "0";
            for (int i = 0; i < dgvStock.Rows.Count; i = i + 1)
            {
                lblTotalQty.Text = Convert.ToString(double.Parse(lblTotalQty.Text) + double.Parse(dgvStock.Rows[i].Cells[2].Value.ToString()));
                lblTotalOut.Text = Convert.ToString(double.Parse(lblTotalOut.Text) + double.Parse(dgvStock.Rows[i].Cells[3].Value.ToString()));
            }
            double TotalAvailable = Convert.ToDouble(lblTotalQty.Text) - Convert.ToDouble(lblTotalOut.Text);
            lblTotalQty.Text = "Total Qty: " + lblTotalQty.Text;
            lblTotalOut.Text = "Total Out Qty: " + lblTotalOut.Text;
            lblAvailableQty.Text = "Available Qty: " + TotalAvailable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            var tb = new ProductStockDetail();
            int outIn = 0, type = 1;
            tb.P_Id = Convert.ToInt32(cbxProductName.SelectedValue);
            tb.Date = Convert.ToDateTime(dtpDate.Value);
            tb.OutQty = Convert.ToInt32(txtQty.Text.Trim());
            tb.InQty = Convert.ToInt32(outIn);
            tb.Type = Convert.ToInt32(type);

            double TotalQty = Convert.ToDouble(txtQty.Text) - Convert.ToDouble(lblTotalQty.Text);

            //tb.TotalQty = Convert.ToInt32(TotalQty);

            db.ProductStockDetails.Add(tb);
            db.SaveChanges();
            ClearTextBox();
            FillGird();
        }
    }
}
