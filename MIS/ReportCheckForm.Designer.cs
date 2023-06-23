namespace MIS
{
    partial class ReportCheckForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReportFollowYesNo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYes = new System.Windows.Forms.CheckBox();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.mISDBDataSet8 = new MIS.MISDBDataSet8();
            this.sPFollowUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_FollowUpTableAdapter = new MIS.MISDBDataSet8TableAdapters.SP_FollowUpTableAdapter();
            this.lblCheck = new System.Windows.Forms.Label();
            this.mISDBDataSet16 = new MIS.MISDBDataSet16();
            this.dailyFollowUpInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dailyFollowUpInfoTableAdapter = new MIS.MISDBDataSet16TableAdapters.DailyFollowUpInfoTableAdapter();
            this.mISDBDataSet17 = new MIS.MISDBDataSet17();
            this.sPDailyFollowupCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Daily_Followup_CheckTableAdapter = new MIS.MISDBDataSet17TableAdapters.SP_Daily_Followup_CheckTableAdapter();
            this.F_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FollowUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportFollowYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFollowUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyFollowUpInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDailyFollowupCheckBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1194, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvReportFollowYesNo
            // 
            this.dgvReportFollowYesNo.AllowUserToAddRows = false;
            this.dgvReportFollowYesNo.AllowUserToDeleteRows = false;
            this.dgvReportFollowYesNo.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportFollowYesNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportFollowYesNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportFollowYesNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_Date,
            this.FollowUp,
            this.fCheckDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvReportFollowYesNo.DataSource = this.sPDailyFollowupCheckBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportFollowYesNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportFollowYesNo.Location = new System.Drawing.Point(39, 376);
            this.dgvReportFollowYesNo.Name = "dgvReportFollowYesNo";
            this.dgvReportFollowYesNo.ReadOnly = true;
            this.dgvReportFollowYesNo.RowHeadersVisible = false;
            this.dgvReportFollowYesNo.RowTemplate.Height = 24;
            this.dgvReportFollowYesNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportFollowYesNo.Size = new System.Drawing.Size(907, 326);
            this.dgvReportFollowYesNo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choses Item";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(716, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxItem
            // 
            this.cbxItem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(414, 139);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(281, 34);
            this.cbxItem.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Purpose Wise Follow Up Report";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(414, 246);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(281, 112);
            this.txtRemark.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Remark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Check";
            // 
            // cbYes
            // 
            this.cbYes.AutoSize = true;
            this.cbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYes.Location = new System.Drawing.Point(472, 197);
            this.cbYes.Name = "cbYes";
            this.cbYes.Size = new System.Drawing.Size(64, 28);
            this.cbYes.TabIndex = 17;
            this.cbYes.Text = "Yes";
            this.cbYes.UseVisualStyleBackColor = true;
            this.cbYes.CheckedChanged += new System.EventHandler(this.cbYes_CheckedChanged);
            // 
            // cbNo
            // 
            this.cbNo.AutoSize = true;
            this.cbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNo.Location = new System.Drawing.Point(592, 197);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(57, 28);
            this.cbNo.TabIndex = 18;
            this.cbNo.Text = "No";
            this.cbNo.UseVisualStyleBackColor = true;
            this.cbNo.CheckedChanged += new System.EventHandler(this.cbNo_CheckedChanged);
            // 
            // dtpToday
            // 
            this.dtpToday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToday.CustomFormat = "";
            this.dtpToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToday.Location = new System.Drawing.Point(414, 88);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.Size = new System.Drawing.Size(281, 34);
            this.dtpToday.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date";
            // 
            // mISDBDataSet8
            // 
            this.mISDBDataSet8.DataSetName = "MISDBDataSet8";
            this.mISDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPFollowUpBindingSource
            // 
            this.sPFollowUpBindingSource.DataMember = "SP_FollowUp";
            this.sPFollowUpBindingSource.DataSource = this.mISDBDataSet8;
            // 
            // sP_FollowUpTableAdapter
            // 
            this.sP_FollowUpTableAdapter.ClearBeforeFill = true;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(676, 202);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(36, 20);
            this.lblCheck.TabIndex = 23;
            this.lblCheck.Text = "Y/N";
            this.lblCheck.Visible = false;
            // 
            // mISDBDataSet16
            // 
            this.mISDBDataSet16.DataSetName = "MISDBDataSet16";
            this.mISDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dailyFollowUpInfoBindingSource
            // 
            this.dailyFollowUpInfoBindingSource.DataMember = "DailyFollowUpInfo";
            this.dailyFollowUpInfoBindingSource.DataSource = this.mISDBDataSet16;
            // 
            // dailyFollowUpInfoTableAdapter
            // 
            this.dailyFollowUpInfoTableAdapter.ClearBeforeFill = true;
            // 
            // mISDBDataSet17
            // 
            this.mISDBDataSet17.DataSetName = "MISDBDataSet17";
            this.mISDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPDailyFollowupCheckBindingSource
            // 
            this.sPDailyFollowupCheckBindingSource.DataMember = "SP_Daily_Followup_Check";
            this.sPDailyFollowupCheckBindingSource.DataSource = this.mISDBDataSet17;
            // 
            // sP_Daily_Followup_CheckTableAdapter
            // 
            this.sP_Daily_Followup_CheckTableAdapter.ClearBeforeFill = true;
            // 
            // F_Date
            // 
            this.F_Date.DataPropertyName = "F_Date";
            this.F_Date.HeaderText = "Date";
            this.F_Date.Name = "F_Date";
            this.F_Date.ReadOnly = true;
            // 
            // FollowUp
            // 
            this.FollowUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FollowUp.DataPropertyName = "FollowUp";
            this.FollowUp.HeaderText = "Follow Up Item";
            this.FollowUp.Name = "FollowUp";
            this.FollowUp.ReadOnly = true;
            // 
            // fCheckDataGridViewTextBoxColumn
            // 
            this.fCheckDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fCheckDataGridViewTextBoxColumn.DataPropertyName = "F_Check";
            this.fCheckDataGridViewTextBoxColumn.HeaderText = "Follow up Check Yes/No";
            this.fCheckDataGridViewTextBoxColumn.Name = "fCheckDataGridViewTextBoxColumn";
            this.fCheckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ReportCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 738);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpToday);
            this.Controls.Add(this.cbNo);
            this.Controls.Add(this.cbYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dgvReportFollowYesNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportCheckForm";
            this.Load += new System.EventHandler(this.ReportCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportFollowYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPFollowUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyFollowUpInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDailyFollowupCheckBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReportFollowYesNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbYes;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.DateTimePicker dtpToday;
        private System.Windows.Forms.Label label6;
        private MISDBDataSet8 mISDBDataSet8;
        private System.Windows.Forms.BindingSource sPFollowUpBindingSource;
        private MISDBDataSet8TableAdapters.SP_FollowUpTableAdapter sP_FollowUpTableAdapter;
        private System.Windows.Forms.Label lblCheck;
        private MISDBDataSet16 mISDBDataSet16;
        private System.Windows.Forms.BindingSource dailyFollowUpInfoBindingSource;
        private MISDBDataSet16TableAdapters.DailyFollowUpInfoTableAdapter dailyFollowUpInfoTableAdapter;
        private MISDBDataSet17 mISDBDataSet17;
        private System.Windows.Forms.BindingSource sPDailyFollowupCheckBindingSource;
        private MISDBDataSet17TableAdapters.SP_Daily_Followup_CheckTableAdapter sP_Daily_Followup_CheckTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FollowUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}