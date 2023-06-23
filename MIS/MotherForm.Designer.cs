namespace MIS
{
    partial class MotherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUpIteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.followUpReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportCheckYesNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giverAndReciveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyTypeWiseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayAndMoneyTypeWiseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayWiseTransectionReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.userToolStripMenuItem,
            this.transectionToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followUpIteamToolStripMenuItem,
            this.reportCheckYesNoToolStripMenuItem,
            this.followUpReportToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.userToolStripMenuItem.Text = "Follow Up";
            // 
            // followUpIteamToolStripMenuItem
            // 
            this.followUpIteamToolStripMenuItem.Name = "followUpIteamToolStripMenuItem";
            this.followUpIteamToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.followUpIteamToolStripMenuItem.Text = "Add Iteam";
            this.followUpIteamToolStripMenuItem.Click += new System.EventHandler(this.followUpIteamToolStripMenuItem_Click);
            // 
            // followUpReportToolStripMenuItem
            // 
            this.followUpReportToolStripMenuItem.Name = "followUpReportToolStripMenuItem";
            this.followUpReportToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.followUpReportToolStripMenuItem.Text = "Report";
            this.followUpReportToolStripMenuItem.Click += new System.EventHandler(this.followUpReportToolStripMenuItem_Click);
            // 
            // reportCheckYesNoToolStripMenuItem
            // 
            this.reportCheckYesNoToolStripMenuItem.Name = "reportCheckYesNoToolStripMenuItem";
            this.reportCheckYesNoToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.reportCheckYesNoToolStripMenuItem.Text = "Report Check";
            this.reportCheckYesNoToolStripMenuItem.Click += new System.EventHandler(this.reportCheckYesNoToolStripMenuItem_Click);
            // 
            // transectionToolStripMenuItem
            // 
            this.transectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giverAndReciveToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.transectionToolStripMenuItem.Name = "transectionToolStripMenuItem";
            this.transectionToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.transectionToolStripMenuItem.Text = "Transection";
            // 
            // giverAndReciveToolStripMenuItem
            // 
            this.giverAndReciveToolStripMenuItem.Name = "giverAndReciveToolStripMenuItem";
            this.giverAndReciveToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.giverAndReciveToolStripMenuItem.Text = "Giver and Recive";
            this.giverAndReciveToolStripMenuItem.Click += new System.EventHandler(this.giverAndReciveToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moneyTypeWiseReportToolStripMenuItem,
            this.dayAndMoneyTypeWiseReportToolStripMenuItem,
            this.dayWiseTransectionReportToolStripMenuItem1});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // moneyTypeWiseReportToolStripMenuItem
            // 
            this.moneyTypeWiseReportToolStripMenuItem.Name = "moneyTypeWiseReportToolStripMenuItem";
            this.moneyTypeWiseReportToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.moneyTypeWiseReportToolStripMenuItem.Text = "Money Type Wise Report";
            this.moneyTypeWiseReportToolStripMenuItem.Click += new System.EventHandler(this.moneyTypeWiseReportToolStripMenuItem_Click);
            // 
            // dayAndMoneyTypeWiseReportToolStripMenuItem
            // 
            this.dayAndMoneyTypeWiseReportToolStripMenuItem.Name = "dayAndMoneyTypeWiseReportToolStripMenuItem";
            this.dayAndMoneyTypeWiseReportToolStripMenuItem.Size = new System.Drawing.Size(362, 26);
            this.dayAndMoneyTypeWiseReportToolStripMenuItem.Text = "Day And Money Type Wise Report";
            this.dayAndMoneyTypeWiseReportToolStripMenuItem.Click += new System.EventHandler(this.dayAndMoneyTypeWiseReportToolStripMenuItem_Click);
            // 
            // dayWiseTransectionReportToolStripMenuItem1
            // 
            this.dayWiseTransectionReportToolStripMenuItem1.Name = "dayWiseTransectionReportToolStripMenuItem1";
            this.dayWiseTransectionReportToolStripMenuItem1.Size = new System.Drawing.Size(362, 26);
            this.dayWiseTransectionReportToolStripMenuItem1.Text = "Day Wise transection report";
            this.dayWiseTransectionReportToolStripMenuItem1.Click += new System.EventHandler(this.dayWiseTransectionReportToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MotherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 665);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MotherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followUpIteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem followUpReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportCheckYesNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giverAndReciveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyTypeWiseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayAndMoneyTypeWiseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayWiseTransectionReportToolStripMenuItem1;
    }
}



