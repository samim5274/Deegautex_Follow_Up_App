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
    }
}
