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
            ClearText();
            FillReg();
            FillProduct();
        }

        private void ClearText()
        {
            txtReceiver.Text = string.Empty;
            cbxProduct.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtRemark.Text = string.Empty;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you went to save product information?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new StockOutDetail();

                tb.Reg = Convert.ToInt32(lblReg.Text);
                tb.P_Id = Convert.ToInt32(cbxProduct.SelectedValue);
                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.Qty = Convert.ToInt32(txtQty.Text.Trim());

                db.StockOutDetails.Add(tb);
                db.SaveChanges();
                FillReg();
                ClearText();
            }
        }

        private void cbxProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            //var db = new MISDBEntities();
            //int x = Convert.ToInt32(cbxProduct.SelectedValue);
            //var num = db.StockDetails.Where(a => a.P_Id.ToString() == x.ToString()).FirstOrDefault();

            //textBox1.Text = num.Qty.ToString();
        }

        private void cbxProduct_ValueMemberChanged(object sender, EventArgs e)
        {
            //var db = new MISDBEntities();
            //int x = Convert.ToInt32(cbxProduct.SelectedValue);
            //var num = db.StockDetails.Where(a => a.P_Id.ToString() == x.ToString()).FirstOrDefault();            
        }

        private void cbxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new MISDBEntities();
            lblQty.Text = cbxProduct.GetItemText(cbxProduct.SelectedValue);
            var num = db.StockDetails.Where(a => a.P_Id.ToString() == lblQty.Text).FirstOrDefault();

            textBox1.Text = num.Qty.ToString();
        }
    }
}
