namespace MIS
{
    partial class GivenAndReciveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTaking = new System.Windows.Forms.CheckBox();
            this.chkGivenMoney = new System.Windows.Forms.CheckBox();
            this.txtGiverName = new System.Windows.Forms.TextBox();
            this.txtReciverName = new System.Windows.Forms.TextBox();
            this.txtResion = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvGivenAndRecive = new System.Windows.Forms.DataGridView();
            this.giverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveAndReciveDeailTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDBDataSet11 = new MIS.MISDBDataSet11();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMoneyType = new System.Windows.Forms.Label();
            this.giveAndReciveDeailTableTableAdapter = new MIS.MISDBDataSet11TableAdapters.GiveAndReciveDeailTableTableAdapter();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenAndRecive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1304, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moeny Given and Recived Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giver Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reciver Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Resion";
            // 
            // chkTaking
            // 
            this.chkTaking.AutoSize = true;
            this.chkTaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTaking.Location = new System.Drawing.Point(347, 341);
            this.chkTaking.Name = "chkTaking";
            this.chkTaking.Size = new System.Drawing.Size(110, 28);
            this.chkTaking.TabIndex = 7;
            this.chkTaking.Text = "I\'m taking";
            this.chkTaking.UseVisualStyleBackColor = true;
            this.chkTaking.CheckedChanged += new System.EventHandler(this.chkTaking_CheckedChanged);
            // 
            // chkGivenMoney
            // 
            this.chkGivenMoney.AutoSize = true;
            this.chkGivenMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGivenMoney.Location = new System.Drawing.Point(233, 341);
            this.chkGivenMoney.Name = "chkGivenMoney";
            this.chkGivenMoney.Size = new System.Drawing.Size(79, 28);
            this.chkGivenMoney.TabIndex = 8;
            this.chkGivenMoney.Text = "I Give";
            this.chkGivenMoney.UseVisualStyleBackColor = true;
            this.chkGivenMoney.CheckedChanged += new System.EventHandler(this.chkGivenMoney_CheckedChanged);
            // 
            // txtGiverName
            // 
            this.txtGiverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiverName.Location = new System.Drawing.Point(233, 244);
            this.txtGiverName.Name = "txtGiverName";
            this.txtGiverName.Size = new System.Drawing.Size(224, 28);
            this.txtGiverName.TabIndex = 9;
            // 
            // txtReciverName
            // 
            this.txtReciverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReciverName.Location = new System.Drawing.Point(233, 291);
            this.txtReciverName.Name = "txtReciverName";
            this.txtReciverName.Size = new System.Drawing.Size(224, 28);
            this.txtReciverName.TabIndex = 10;
            // 
            // txtResion
            // 
            this.txtResion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResion.Location = new System.Drawing.Point(233, 435);
            this.txtResion.Multiline = true;
            this.txtResion.Name = "txtResion";
            this.txtResion.Size = new System.Drawing.Size(224, 127);
            this.txtResion.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(26, 96);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 25);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "00:00:00";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(233, 207);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 22);
            this.dtpDate.TabIndex = 13;
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(233, 384);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(224, 28);
            this.txtMoney.TabIndex = 15;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(494, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(494, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(494, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(233, 161);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 28);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvGivenAndRecive
            // 
            this.dgvGivenAndRecive.AllowUserToAddRows = false;
            this.dgvGivenAndRecive.AllowUserToDeleteRows = false;
            this.dgvGivenAndRecive.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGivenAndRecive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGivenAndRecive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGivenAndRecive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giverNameDataGridViewTextBoxColumn,
            this.reciverNameDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.resonDataGridViewTextBoxColumn});
            this.dgvGivenAndRecive.DataSource = this.giveAndReciveDeailTableBindingSource;
            this.dgvGivenAndRecive.Location = new System.Drawing.Point(618, 125);
            this.dgvGivenAndRecive.Name = "dgvGivenAndRecive";
            this.dgvGivenAndRecive.ReadOnly = true;
            this.dgvGivenAndRecive.RowHeadersVisible = false;
            this.dgvGivenAndRecive.RowTemplate.Height = 24;
            this.dgvGivenAndRecive.Size = new System.Drawing.Size(696, 437);
            this.dgvGivenAndRecive.TabIndex = 21;
            // 
            // giverNameDataGridViewTextBoxColumn
            // 
            this.giverNameDataGridViewTextBoxColumn.DataPropertyName = "GiverName";
            this.giverNameDataGridViewTextBoxColumn.HeaderText = "Giver Name";
            this.giverNameDataGridViewTextBoxColumn.Name = "giverNameDataGridViewTextBoxColumn";
            this.giverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciverNameDataGridViewTextBoxColumn
            // 
            this.reciverNameDataGridViewTextBoxColumn.DataPropertyName = "ReciverName";
            this.reciverNameDataGridViewTextBoxColumn.HeaderText = "Reciver Name";
            this.reciverNameDataGridViewTextBoxColumn.Name = "reciverNameDataGridViewTextBoxColumn";
            this.reciverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resonDataGridViewTextBoxColumn
            // 
            this.resonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resonDataGridViewTextBoxColumn.DataPropertyName = "Reson";
            this.resonDataGridViewTextBoxColumn.HeaderText = "Reson";
            this.resonDataGridViewTextBoxColumn.Name = "resonDataGridViewTextBoxColumn";
            this.resonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giveAndReciveDeailTableBindingSource
            // 
            this.giveAndReciveDeailTableBindingSource.DataMember = "GiveAndReciveDeailTable";
            this.giveAndReciveDeailTableBindingSource.DataSource = this.mISDBDataSet11;
            // 
            // mISDBDataSet11
            // 
            this.mISDBDataSet11.DataSetName = "MISDBDataSet11";
            this.mISDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMoneyType
            // 
            this.lblMoneyType.AutoSize = true;
            this.lblMoneyType.Location = new System.Drawing.Point(463, 347);
            this.lblMoneyType.Name = "lblMoneyType";
            this.lblMoneyType.Size = new System.Drawing.Size(24, 17);
            this.lblMoneyType.TabIndex = 22;
            this.lblMoneyType.Text = "00";
            this.lblMoneyType.Visible = false;
            // 
            // giveAndReciveDeailTableTableAdapter
            // 
            this.giveAndReciveDeailTableTableAdapter.ClearBeforeFill = true;
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(26, 125);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(90, 25);
            this.lblTime2.TabIndex = 23;
            this.lblTime2.Text = "00:00:00";
            this.lblTime2.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(494, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 33);
            this.button5.TabIndex = 24;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Me Taking or Give";
            // 
            // GivenAndReciveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblMoneyType);
            this.Controls.Add(this.dgvGivenAndRecive);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtResion);
            this.Controls.Add(this.txtReciverName);
            this.Controls.Add(this.txtGiverName);
            this.Controls.Add(this.chkGivenMoney);
            this.Controls.Add(this.chkTaking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GivenAndReciveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiveAndReciveForm";
            this.Load += new System.EventHandler(this.dtpDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGivenAndRecive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giveAndReciveDeailTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDBDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkTaking;
        private System.Windows.Forms.CheckBox chkGivenMoney;
        private System.Windows.Forms.TextBox txtGiverName;
        private System.Windows.Forms.TextBox txtReciverName;
        private System.Windows.Forms.TextBox txtResion;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvGivenAndRecive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMoneyType;
        private MISDBDataSet11 mISDBDataSet11;
        private System.Windows.Forms.BindingSource giveAndReciveDeailTableBindingSource;
        private MISDBDataSet11TableAdapters.GiveAndReciveDeailTableTableAdapter giveAndReciveDeailTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}