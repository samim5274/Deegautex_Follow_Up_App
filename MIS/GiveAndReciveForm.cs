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
    public partial class GivenAndReciveForm : Form
    {
        public GivenAndReciveForm()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }

        private void dtpDate_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ClearText();
            FillGrid();     
        }

        private void FillGrid()
        {
            var obj = new Manager();
            var list = obj.GetAllMoneyInfo();
            dgvGivenAndRecive.DataSource = list;
        }

        private void ClearText()
        {
            txtGiverName.Text = string.Empty;
            txtReciverName.Text = string.Empty;
            txtMoney.Text = string.Empty;
            txtResion.Text = string.Empty;
            chkGivenMoney.Checked = false;
            chkTaking.Checked = false;
            lblTime2.Visible = false;
            txtSearch.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Save")
            {
                SaveInfo();
                FillGrid();
            }
            else if (button1.Text== "Edit")
            {
                EditInfo();
                FillGrid();
            }            
        }

        private void EditInfo()
        {
            var db = new MISDBEntities();
            var tb = new GiveAndReciveDeailTable();
            var selector = db.GiveAndReciveDeailTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();

            selector.Date = Convert.ToDateTime(dtpDate.Value);
            selector.GiverName = txtGiverName.Text.Trim();
            selector.ReciverName = txtReciverName.Text.Trim();
            selector.Time = lblTime.Text.Trim();
            selector.Reson = txtResion.Text.Trim();
            selector.MoneyType = Convert.ToInt32(lblMoneyType.Text.Trim());
            selector.Money = Convert.ToInt32(txtMoney.Text.Trim());

            //db.GiveAndReciveDeailTables.Add(tb);
            db.SaveChanges();
            MessageBox.Show(@"Data edit done.", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearText();
        }

        private void SaveInfo()
        {
            if (MessageBox.Show(@"Do you went to save the data.","Save Inof",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var db = new MISDBEntities();
                var tb = new GiveAndReciveDeailTable();

                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.GiverName = txtGiverName.Text.Trim();
                tb.ReciverName = txtReciverName.Text.Trim();
                tb.Time = lblTime.Text.Trim();
                tb.Reson = txtResion.Text.Trim();
                tb.MoneyType = Convert.ToInt32(lblMoneyType.Text.Trim());
                tb.Money = Convert.ToInt32(txtMoney.Text.Trim());

                db.GiveAndReciveDeailTables.Add(tb);
                db.SaveChanges();
                MessageBox.Show(@"Save done.", "Save Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearText();
            }
        }

        private void chkGivenMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGivenMoney.Checked)
            {
                chkTaking.Checked = false;
                txtMoney.Enabled = true;
                lblMoneyType.Text = "0";                
            }
            else
            {
                txtMoney.Enabled = false;
                lblMoneyType.Text = "00";
                txtMoney.Text = string.Empty;
            }
        }

        private void chkTaking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaking.Checked)
            {
                chkGivenMoney.Checked = false;
                txtMoney.Enabled = true;
                lblMoneyType.Text = "1";
            }
            else
            {
                txtMoney.Enabled = false;
                lblMoneyType.Text = "00";
                txtMoney.Text = string.Empty;
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtMoney.Text != null)
            {
                button1.Enabled = true;
            }
            if (txtMoney.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                button4.Enabled = false;
            }
            else if (txtSearch.Text != null)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                var db = new MISDBEntities();

                var selector = db.GiveAndReciveDeailTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();
                txtGiverName.Text = selector.GiverName;
                txtReciverName.Text = selector.ReciverName;
                dtpDate.Value = Convert.ToDateTime(selector.Date);
                lblTime2.Text = selector.Time;
                lblTime2.Visible = true;
                txtResion.Text = selector.Reson;
                txtMoney.Text = selector.Money.ToString();
                lblMoneyType.Text = selector.MoneyType.ToString();
                if (lblMoneyType.Text == "0")
                {
                    chkGivenMoney.Checked = true;
                }
                else if (lblMoneyType.Text == "1")
                {
                    chkTaking.Checked = true;
                }
                else
                {
                    chkTaking.Checked = false;
                    chkGivenMoney.Checked = false;
                }
                button1.Enabled = true;
                button3.Enabled = true;
                button1.Text = "Edit";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error !",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you went to delete the data.", "Delete Inof", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new MISDBEntities();

                var selector = db.GiveAndReciveDeailTables.Where(a => a.Id.ToString() == txtSearch.Text).FirstOrDefault();
                
                db.GiveAndReciveDeailTables.Remove(selector);
                db.SaveChanges();
                MessageBox.Show(@"Data edit done.", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearText();
            }                
        }
    }
}
