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
        public double x, y;
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
            try
            {
                y = x - Convert.ToDouble(txtQty.Text);
                //label4.Text = y.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(@"Please input currect formate and currect qty. Thank you.", "Foramte invalid!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (y < 0)
            {
                MessageBox.Show(@"Store product qty not available. First input product qty and try again. Thank you.", "Stock Qty Transfer Faild!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (y >= 0)
            {
                if (MessageBox.Show(@"Are you went to save product information?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var db = new MISDBEntities();
                    var tb = new StockOutDetail();
                    var tb2 = new ProductStockDetail();
                    int outIn = 0, type = 1;
                    tb.Reg = Convert.ToInt32(lblReg.Text);
                    tb.ReceiverName = txtReceiver.Text.Trim();
                    tb.P_Id = Convert.ToInt32(cbxProduct.SelectedValue);
                    tb.Date = Convert.ToDateTime(dtpDate.Value);
                    tb.Qty = Convert.ToInt32(txtQty.Text.Trim());
                    tb.Remark = txtRemark.Text.Trim();
                    
                    tb2.P_Id = Convert.ToInt32(cbxProduct.SelectedValue);
                    tb2.Date = Convert.ToDateTime(dtpDate.Value);
                    tb2.OutQty = Convert.ToInt32(txtQty.Text.Trim());
                    tb2.InQty = Convert.ToInt32(outIn);
                    tb2.Type = Convert.ToInt32(type);

                    db.StockOutDetails.Add(tb);
                    db.ProductStockDetails.Add(tb2);
                    db.SaveChanges();
                    FillReg();
                    ClearText();
                }
            }
            else
            {
                MessageBox.Show(@"Store product qty not available. First input product qty and try again. Thank you.", "Stock Qty Transfer Faild!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void cbxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            string getPId;
            getPId = cbxProduct.GetItemText(cbxProduct.SelectedValue);
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
            x = TotalAvailable;
            lblTotalStock.Text = "Total In Stock: " + lblTotalStock.Text;
            lblTotalOut.Text = "Total Out Stock: " + lblTotalOut.Text;
            lblTotalAvailable.Text = "Total Available Stock: " + TotalAvailable;
        }
    }
}
