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
    public partial class StockOutForm : Form
    {
        public StockOutForm()
        {
            InitializeComponent();
        }

        private void StockOutForm_Load(object sender, EventArgs e)
        {
            FillReg();
            FillProduct();
            ClearText();
        }

        private void ClearText()
        {
            txtReceiver.Text = string.Empty;
            cbxProduct.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtRemark.Text = string.Empty;
            lblTotalAvailable.Text = string.Empty;
            lblTotalOut.Text = string.Empty;
            lblTotalStock.Text = string.Empty;
        }

        private void FillProduct()
        {
            var obj = new Manager();
            var list = obj.GetAllProduct();
            cbxProduct.DisplayMember = "P_Name";
            cbxProduct.ValueMember = "Id";
            cbxProduct.DataSource = list;
        }

        private void FillReg()
        {
            var db = new MISDBEntities();
            var reg = db.StockOutDetails.Count() + 1;
            var num = DateTime.Now;
            lblReg.Text = num.ToString("yyyyMMdd") + reg;
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

            if (txtQty.Text == null || txtQtyUp.Text == null)
            {
                txtQty.Text = "0";
                txtQtyUp.Text = "0";
            }
            else if (txtQty.Text != null && txtQtyUp.Text != null)
            {
                if (txtQty.Text == "") { txtQty.Text = "0"; }
                else if (txtQtyUp.Text == "") { txtQtyUp.Text = "0"; }
                txtQtyUpResult.Text = (Convert.ToDouble(txtQtyUp.Text) - Convert.ToDouble(txtQty.Text)).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you went to save product information?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new StockOutDetail();

                tb.Reg = Convert.ToInt32(lblReg.Text);
                tb.ReceiverName = txtReceiver.Text.Trim();
                tb.P_Id = Convert.ToInt32(cbxProduct.SelectedValue);
                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.Qty = Convert.ToInt32(txtQty.Text.Trim());
                tb.Remark = txtReceiver.Text.Trim();

                db.StockOutDetails.Add(tb);
                db.SaveChanges();
                FillReg();
                ClearText();
            }
        }

        private void cbxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            string getPId;
            getPId = cbxProduct.GetItemText(cbxProduct.SelectedValue);

            //var num = db.ProductStockDetails.Where(a => a.P_Id.ToString() == lblQty.Text).FirstOrDefault();

            dataGridView1.DataSource = db.ProductStockDetails.Where(a => a.P_Id.ToString() == getPId).ToList();

            lblTotalStock.Text = "0";
            lblTotalOut.Text = "0";
            lblTotalAvailable.Text = "0";
            for (int i = 0; i < dataGridView1.Rows.Count; i = i + 1)
            {
                lblTotalStock.Text = Convert.ToString(double.Parse(lblTotalStock.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                lblTotalOut.Text = Convert.ToString(double.Parse(lblTotalOut.Text) + double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
            }
            double TotalAvailable = Convert.ToDouble(lblTotalStock.Text) - Convert.ToDouble(lblTotalOut.Text);
            lblTotalStock.Text = "Total In Stock: " + lblTotalStock.Text;
            lblTotalOut.Text = "Total Out Stock: " + lblTotalOut.Text;
            lblTotalAvailable.Text = "Total Available Stock: " + TotalAvailable;
        }        
    }
}
