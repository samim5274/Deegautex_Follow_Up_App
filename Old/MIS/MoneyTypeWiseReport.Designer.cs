namespace MIS
{
    partial class MoneyTypeWiseReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMoneyType = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.mISDBDataSet13 = new MIS.MISDBDataSet13();
            this.giveAndReciveDeailTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giveAndReciveDeailTableTableAdapter = new MIS.MISDBDataSet13TableAdapters.GiveAndReciveDeailTableTableAdapter();
            this.dgvMoneyType = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPMoneyTypeWiseTransectionReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDBDataSet14 = new MIS.MISDBDataSet14();
            this.sP_MoneyType_Wise_Transection_ReportTableAdapter = new MIS.MISDBDataSet14TableAdapters.SP_MoneyType_Wise_Transection_ReportTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMoneyTypeWiseTransectionReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(864, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money Type Wise Transection Report";
            // 
            // cbxMoneyType
            // 
            this.cbxMoneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMoneyType.FormattingEnabled = true;
            this.cbxMoneyType.Items.AddRange(new object[] {
            "I\'m Taking",
            "I\'ll Give"});
            this.cbxMoneyType.Location = new System.Drawing.Point(279, 89);
            this.cbxMoneyType.Name = "cbxMoneyType";
            this.cbxMoneyType.Size = new System.Drawing.Size(436, 33);
            this.cbxMoneyType.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(721, 83);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(243, 43);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // mISDBDataSet13
            // 
            this.mISDBDataSet13.DataSetName = "MISDBDataSet13";
            this.mISDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giveAndReciveDeailTableBindingSource
            // 
            this.giveAndReciveDeailTableBindingSource.DataMember = "GiveAndReciveDeailTable";
            this.giveAndReciveDeailTableBindingSource.DataSource = this.mISDBDataSet13;
            // 
            // giveAndReciveDeailTableTableAdapter
            // 
            this.giveAndReciveDeailTableTableAdapter.ClearBeforeFill = true;
            // 
            // dgvMoneyType
            // 
            this.dgvMoneyType.AllowUserToAddRows = false;
            this.dgvMoneyType.AllowUserToDeleteRows = false;
            this.dgvMoneyType.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoneyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoneyType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.giverNameDataGridViewTextBoxColumn,
            this.reciverNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.resonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dgvMoneyType.DataSource = this.sPMoneyTypeWiseTransectionReportBindingSource;
            this.dgvMoneyType.Location = new System.Drawing.Point(48, 156);
            this.dgvMoneyType.Name = "dgvMoneyType";
            this.dgvMoneyType.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyType.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoneyType.RowHeadersVisible = false;
            this.dgvMoneyType.RowTemplate.Height = 24;
            this.dgvMoneyType.Size = new System.Drawing.Size(1058, 437);
            this.dgvMoneyType.TabIndex = 4;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giverNameDataGridViewTextBoxColumn
            // 
            this.giverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giverNameDataGridViewTextBoxColumn.DataPropertyName = "GiverName";
            this.giverNameDataGridViewTextBoxColumn.HeaderText = "Giver Name";
            this.giverNameDataGridViewTextBoxColumn.Name = "giverNameDataGridViewTextBoxColumn";
            this.giverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciverNameDataGridViewTextBoxColumn
            // 
            this.reciverNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reciverNameDataGridViewTextBoxColumn.DataPropertyName = "ReciverName";
            this.reciverNameDataGridViewTextBoxColumn.HeaderText = "Reciver Name";
            this.reciverNameDataGridViewTextBoxColumn.Name = "reciverNameDataGridViewTextBoxColumn";
            this.reciverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resonDataGridViewTextBoxColumn
            // 
            this.resonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resonDataGridViewTextBoxColumn.DataPropertyName = "Reson";
            this.resonDataGridViewTextBoxColumn.HeaderText = "Reson";
            this.resonDataGridViewTextBoxColumn.Name = "resonDataGridViewTextBoxColumn";
            this.resonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPMoneyTypeWiseTransectionReportBindingSource
            // 
            this.sPMoneyTypeWiseTransectionReportBindingSource.DataMember = "SP_MoneyType_Wise_Transection_Report";
            this.sPMoneyTypeWiseTransectionReportBindingSource.DataSource = this.mISDBDataSet14;
            // 
            // mISDBDataSet14
            // 
            this.mISDBDataSet14.DataSetName = "MISDBDataSet14";
            this.mISDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_MoneyType_Wise_Transection_ReportTableAdapter
            // 
            this.sP_MoneyType_Wise_Transection_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(770, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Amount ৳:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(950, 630);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(24, 25);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "0";
            // 
            // MoneyTypeWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 720);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMoneyType);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cbxMoneyType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyTypeWiseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyTypeWiseReport";
            this.Load += new System.EventHandler(this.MoneyTypeWiseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMoneyTypeWiseTransectionReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMoneyType;
        private System.Windows.Forms.Button btnShow;
        private MISDBDataSet13 mISDBDataSet13;
        private System.Windows.Forms.BindingSource giveAndReciveDeailTableBindingSource;
        private MISDBDataSet13TableAdapters.GiveAndReciveDeailTableTableAdapter giveAndReciveDeailTableTableAdapter;
        private System.Windows.Forms.DataGridView dgvMoneyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPMoneyTypeWiseTransectionReportBindingSource;
        private MISDBDataSet14 mISDBDataSet14;
        private MISDBDataSet14TableAdapters.SP_MoneyType_Wise_Transection_ReportTableAdapter sP_MoneyType_Wise_Transection_ReportTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMoney;
    }
}