﻿namespace MIS
{
    partial class StockOutForm
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
            this.lblReg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalAvailable = new System.Windows.Forms.Label();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(73, 9);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(52, 25);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cbxProduct);
            this.groupBox1.Controls.Add(this.txtReceiver);
            this.groupBox1.Location = new System.Drawing.Point(134, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 465);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Remark\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Receiver Name";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(223, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(193, 251);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(277, 123);
            this.txtRemark.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(193, 176);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(277, 33);
            this.txtQty.TabIndex = 2;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(193, 118);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(277, 33);
            this.cbxProduct.TabIndex = 1;
            this.cbxProduct.SelectionChangeCommitted += new System.EventHandler(this.cbxProduct_SelectionChangeCommitted);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(193, 49);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(277, 33);
            this.txtReceiver.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(301, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(318, 33);
            this.dtpDate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 257);
            this.dataGridView1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalAvailable);
            this.groupBox2.Controls.Add(this.lblTotalOut);
            this.groupBox2.Controls.Add(this.lblTotalStock);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(659, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 465);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalAvailable
            // 
            this.lblTotalAvailable.AutoSize = true;
            this.lblTotalAvailable.Location = new System.Drawing.Point(17, 376);
            this.lblTotalAvailable.Name = "lblTotalAvailable";
            this.lblTotalAvailable.Size = new System.Drawing.Size(63, 25);
            this.lblTotalAvailable.TabIndex = 16;
            this.lblTotalAvailable.Text = "label6";
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.AutoSize = true;
            this.lblTotalOut.Location = new System.Drawing.Point(222, 319);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.Size = new System.Drawing.Size(63, 25);
            this.lblTotalOut.TabIndex = 15;
            this.lblTotalOut.Text = "label6";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(17, 319);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(63, 25);
            this.lblTotalStock.TabIndex = 14;
            this.lblTotalStock.Text = "label6";
            // 
            // StockOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReg);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StockOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockOutForm";
            this.Load += new System.EventHandler(this.StockOutForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalAvailable;
        private System.Windows.Forms.Label lblTotalOut;
        private System.Windows.Forms.Label lblTotalStock;
    }
}