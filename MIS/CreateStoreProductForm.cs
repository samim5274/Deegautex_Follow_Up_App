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
    public partial class CreateStoreProductForm : Form
    {
        public CreateStoreProductForm()
        {
            InitializeComponent();
        }

        private void CreateStoreProductForm_Load(object sender, EventArgs e)
        {
            FillDepartment();
            ClearText();
        }
        

        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            cbxDepartment.Text = string.Empty;
            txtPurchasePrice.Text = string.Empty;
            txtRemark.Text = string.Empty;
        }

        private void FillDepartment()
        {
            var obj = new Manager();
            var list = obj.GetAllDepartment();
            cbxDepartment.DisplayMember = "Dep_Name";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPurchasePrice.Text != null)
            {
                btnSave.Enabled = true;
            }
            if (txtPurchasePrice.Text == "")
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you went to save product information?","Save Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new ProductDetail();

                tb.P_Name = txtProductName.Text.Trim();
                tb.P_DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
                tb.P_PurchasePrice = Convert.ToInt32(txtPurchasePrice.Text.Trim());
                tb.P_Description = txtRemark.Text.Trim();

                db.ProductDetails.Add(tb);
                db.SaveChanges();                
                ClearText();
            }
        }
    }
}
