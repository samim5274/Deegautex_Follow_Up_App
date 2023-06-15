namespace MIS
{
    partial class FollowUpWiseReportFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFollowUpReport = new System.Windows.Forms.DataGridView();
            this.sPPurposeWiseReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDBDataSet9 = new MIS.MISDBDataSet9();
            this.sP_Purpose_Wise_ReportTableAdapter = new MIS.MISDBDataSet9TableAdapters.SP_Purpose_Wise_ReportTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.followUpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowUpReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPurposeWiseReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purpose Wise Follow Up Report";
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Location = new System.Drawing.Point(506, 112);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(281, 34);
            this.cbxPurpose.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(289, 163);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(573, 50);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choses Item";
            // 
            // dgvFollowUpReport
            // 
            this.dgvFollowUpReport.AllowUserToAddRows = false;
            this.dgvFollowUpReport.AllowUserToDeleteRows = false;
            this.dgvFollowUpReport.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFollowUpReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFollowUpReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowUpReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.purposeDataGridViewTextBoxColumn,
            this.followUpDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dgvFollowUpReport.DataSource = this.sPPurposeWiseReportBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFollowUpReport.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFollowUpReport.Location = new System.Drawing.Point(126, 232);
            this.dgvFollowUpReport.Name = "dgvFollowUpReport";
            this.dgvFollowUpReport.ReadOnly = true;
            this.dgvFollowUpReport.RowHeadersVisible = false;
            this.dgvFollowUpReport.RowTemplate.Height = 24;
            this.dgvFollowUpReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFollowUpReport.Size = new System.Drawing.Size(907, 376);
            this.dgvFollowUpReport.TabIndex = 4;
            // 
            // sPPurposeWiseReportBindingSource
            // 
            this.sPPurposeWiseReportBindingSource.DataMember = "SP_Purpose_Wise_Report";
            this.sPPurposeWiseReportBindingSource.DataSource = this.mISDBDataSet9;
            // 
            // mISDBDataSet9
            // 
            this.mISDBDataSet9.DataSetName = "MISDBDataSet9";
            this.mISDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Purpose_Wise_ReportTableAdapter
            // 
            this.sP_Purpose_Wise_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            this.purposeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose";
            this.purposeDataGridViewTextBoxColumn.HeaderText = "Purpose";
            this.purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            this.purposeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // followUpDataGridViewTextBoxColumn
            // 
            this.followUpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.followUpDataGridViewTextBoxColumn.DataPropertyName = "FollowUp";
            this.followUpDataGridViewTextBoxColumn.HeaderText = "Follow Up";
            this.followUpDataGridViewTextBoxColumn.Name = "followUpDataGridViewTextBoxColumn";
            this.followUpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(289, 623);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(573, 50);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // FollowUpWiseReportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 692);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFollowUpReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxPurpose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FollowUpWiseReportFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FollowUpWiseReport";
            this.Load += new System.EventHandler(this.FollowUpWiseReportFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowUpReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPurposeWiseReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPurpose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFollowUpReport;
        private System.Windows.Forms.BindingSource sPPurposeWiseReportBindingSource;
        private MISDBDataSet9 mISDBDataSet9;
        private MISDBDataSet9TableAdapters.SP_Purpose_Wise_ReportTableAdapter sP_Purpose_Wise_ReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn followUpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowAll;
    }
}