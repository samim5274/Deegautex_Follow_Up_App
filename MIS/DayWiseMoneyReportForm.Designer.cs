namespace MIS
{
    partial class DayWiseMoneyReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDayWiseTransection = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPDAYWISEMONEYREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDBDataSet12 = new MIS.MISDBDataSet12();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sP_DAY_WISE_MONEY_REPORTTableAdapter = new MIS.MISDBDataSet12TableAdapters.SP_DAY_WISE_MONEY_REPORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayWiseTransection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDAYWISEMONEYREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(236, 154);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(738, 55);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Day Wise Money Trasection Report";
            // 
            // dtpSDate
            // 
            this.dtpSDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSDate.Location = new System.Drawing.Point(236, 98);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(348, 28);
            this.dtpSDate.TabIndex = 3;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEDate.Location = new System.Drawing.Point(626, 98);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(348, 28);
            this.dtpEDate.TabIndex = 4;
            // 
            // dgvDayWiseTransection
            // 
            this.dgvDayWiseTransection.AllowUserToAddRows = false;
            this.dgvDayWiseTransection.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayWiseTransection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDayWiseTransection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayWiseTransection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.giverNameDataGridViewTextBoxColumn,
            this.reciverNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.resonDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dgvDayWiseTransection.DataSource = this.sPDAYWISEMONEYREPORTBindingSource;
            this.dgvDayWiseTransection.Location = new System.Drawing.Point(41, 243);
            this.dgvDayWiseTransection.Name = "dgvDayWiseTransection";
            this.dgvDayWiseTransection.ReadOnly = true;
            this.dgvDayWiseTransection.RowTemplate.Height = 24;
            this.dgvDayWiseTransection.Size = new System.Drawing.Size(1116, 429);
            this.dgvDayWiseTransection.TabIndex = 5;
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
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resonDataGridViewTextBoxColumn
            // 
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
            // sPDAYWISEMONEYREPORTBindingSource
            // 
            this.sPDAYWISEMONEYREPORTBindingSource.DataMember = "SP_DAY_WISE_MONEY_REPORT";
            this.sPDAYWISEMONEYREPORTBindingSource.DataSource = this.mISDBDataSet12;
            // 
            // mISDBDataSet12
            // 
            this.mISDBDataSet12.DataSetName = "MISDBDataSet12";
            this.mISDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date";
            // 
            // sP_DAY_WISE_MONEY_REPORTTableAdapter
            // 
            this.sP_DAY_WISE_MONEY_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // DayWiseMoneyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 706);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDayWiseTransection);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayWiseMoneyReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayWiseMoneyReportForm";
            this.Load += new System.EventHandler(this.DayWiseMoneyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayWiseTransection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDAYWISEMONEYREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.DataGridView dgvDayWiseTransection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPDAYWISEMONEYREPORTBindingSource;
        private MISDBDataSet12 mISDBDataSet12;
        private MISDBDataSet12TableAdapters.SP_DAY_WISE_MONEY_REPORTTableAdapter sP_DAY_WISE_MONEY_REPORTTableAdapter;
    }
}