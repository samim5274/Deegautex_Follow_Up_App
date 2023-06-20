namespace MIS
{
    partial class DayAndMoneyTypeWiseReportForm
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
            this.lblMoney = new System.Windows.Forms.Label();
            this.sP_MoneyType_Wise_Transection_ReportTableAdapter = new MIS.MISDBDataSet14TableAdapters.SP_MoneyType_Wise_Transection_ReportTableAdapter();
            this.mISDBDataSet14 = new MIS.MISDBDataSet14();
            this.sPMoneyTypeWiseTransectionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMoneyTypeShow = new System.Windows.Forms.DataGridView();
            this.giveAndReciveDeailTableTableAdapter = new MIS.MISDBDataSet13TableAdapters.GiveAndReciveDeailTableTableAdapter();
            this.giveAndReciveDeailTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDBDataSet13 = new MIS.MISDBDataSet13();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cbxMoneyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMoneyTypeWiseTransectionReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyTypeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(943, 677);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 25);
            this.lblMoney.TabIndex = 13;
            this.lblMoney.Text = "0";
            // 
            // sP_MoneyType_Wise_Transection_ReportTableAdapter
            // 
            this.sP_MoneyType_Wise_Transection_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // mISDBDataSet14
            // 
            this.mISDBDataSet14.DataSetName = "MISDBDataSet14";
            this.mISDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMoneyTypeWiseTransectionReportBindingSource
            // 
            this.sPMoneyTypeWiseTransectionReportBindingSource.DataMember = "SP_MoneyType_Wise_Transection_Report";
            this.sPMoneyTypeWiseTransectionReportBindingSource.DataSource = this.mISDBDataSet14;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resonDataGridViewTextBoxColumn
            // 
            this.resonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resonDataGridViewTextBoxColumn.DataPropertyName = "Reson";
            this.resonDataGridViewTextBoxColumn.HeaderText = "Reson";
            this.resonDataGridViewTextBoxColumn.Name = "resonDataGridViewTextBoxColumn";
            this.resonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciverNameDataGridViewTextBoxColumn
            // 
            this.reciverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reciverNameDataGridViewTextBoxColumn.DataPropertyName = "ReciverName";
            this.reciverNameDataGridViewTextBoxColumn.HeaderText = "Reciver Name";
            this.reciverNameDataGridViewTextBoxColumn.Name = "reciverNameDataGridViewTextBoxColumn";
            this.reciverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giverNameDataGridViewTextBoxColumn
            // 
            this.giverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giverNameDataGridViewTextBoxColumn.DataPropertyName = "GiverName";
            this.giverNameDataGridViewTextBoxColumn.HeaderText = "Giver Name";
            this.giverNameDataGridViewTextBoxColumn.Name = "giverNameDataGridViewTextBoxColumn";
            this.giverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvMoneyTypeShow
            // 
            this.dgvMoneyTypeShow.AllowUserToAddRows = false;
            this.dgvMoneyTypeShow.AllowUserToDeleteRows = false;
            this.dgvMoneyTypeShow.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyTypeShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoneyTypeShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneyTypeShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.giverNameDataGridViewTextBoxColumn,
            this.reciverNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.resonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dgvMoneyTypeShow.DataSource = this.sPMoneyTypeWiseTransectionReportBindingSource;
            this.dgvMoneyTypeShow.Location = new System.Drawing.Point(41, 222);
            this.dgvMoneyTypeShow.Name = "dgvMoneyTypeShow";
            this.dgvMoneyTypeShow.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyTypeShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoneyTypeShow.RowHeadersVisible = false;
            this.dgvMoneyTypeShow.RowTemplate.Height = 24;
            this.dgvMoneyTypeShow.Size = new System.Drawing.Size(1058, 437);
            this.dgvMoneyTypeShow.TabIndex = 11;
            // 
            // giveAndReciveDeailTableTableAdapter
            // 
            this.giveAndReciveDeailTableTableAdapter.ClearBeforeFill = true;
            // 
            // giveAndReciveDeailTableBindingSource
            // 
            this.giveAndReciveDeailTableBindingSource.DataMember = "GiveAndReciveDeailTable";
            this.giveAndReciveDeailTableBindingSource.DataSource = this.mISDBDataSet13;
            // 
            // mISDBDataSet13
            // 
            this.mISDBDataSet13.DataSetName = "MISDBDataSet13";
            this.mISDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Amount ৳:";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(714, 153);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(243, 43);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // cbxMoneyType
            // 
            this.cbxMoneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMoneyType.FormattingEnabled = true;
            this.cbxMoneyType.Items.AddRange(new object[] {
            "I\'m Taking",
            "I\'ll Give"});
            this.cbxMoneyType.Location = new System.Drawing.Point(272, 159);
            this.cbxMoneyType.Name = "cbxMoneyType";
            this.cbxMoneyType.Size = new System.Drawing.Size(436, 33);
            this.cbxMoneyType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1065, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = "Day and Money Type Wise Transection Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // dtpSDate
            // 
            this.dtpSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSDate.Location = new System.Drawing.Point(199, 107);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(325, 28);
            this.dtpSDate.TabIndex = 14;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDate.Location = new System.Drawing.Point(714, 107);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(325, 28);
            this.dtpEDate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(599, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date";
            // 
            // DayAndMoneyTypeWiseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 733);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.dgvMoneyTypeShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxMoneyType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayAndMoneyTypeWiseReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayAndMoneyTypeWiseReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMoneyTypeWiseTransectionReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyTypeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private MISDBDataSet14TableAdapters.SP_MoneyType_Wise_Transection_ReportTableAdapter sP_MoneyType_Wise_Transection_ReportTableAdapter;
        private MISDBDataSet14 mISDBDataSet14;
        private System.Windows.Forms.BindingSource sPMoneyTypeWiseTransectionReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvMoneyTypeShow;
        private MISDBDataSet13TableAdapters.GiveAndReciveDeailTableTableAdapter giveAndReciveDeailTableTableAdapter;
        private System.Windows.Forms.BindingSource giveAndReciveDeailTableBindingSource;
        private MISDBDataSet13 mISDBDataSet13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbxMoneyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}