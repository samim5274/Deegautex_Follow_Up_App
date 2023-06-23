namespace MIS
{
    partial class PurposeWiseFollowUpItemFillForm
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
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.cbxFollowUpItem = new System.Windows.Forms.ComboBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Location = new System.Drawing.Point(348, 85);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(228, 33);
            this.cbxPurpose.TabIndex = 0;
            this.cbxPurpose.SelectedIndexChanged += new System.EventHandler(this.cbxPurpose_SelectedIndexChanged);
            // 
            // cbxFollowUpItem
            // 
            this.cbxFollowUpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFollowUpItem.FormattingEnabled = true;
            this.cbxFollowUpItem.Location = new System.Drawing.Point(348, 230);
            this.cbxFollowUpItem.Name = "cbxFollowUpItem";
            this.cbxFollowUpItem.Size = new System.Drawing.Size(228, 33);
            this.cbxFollowUpItem.TabIndex = 1;
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(375, 146);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(172, 52);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // PurposeWiseFollowUpItemFillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 651);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.cbxFollowUpItem);
            this.Controls.Add(this.cbxPurpose);
            this.Name = "PurposeWiseFollowUpItemFillForm";
            this.Text = "PurposeWiseFollowUpItemFillForm";
            this.Load += new System.EventHandler(this.PurposeWiseFollowUpItemFillForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPurpose;
        private System.Windows.Forms.ComboBox cbxFollowUpItem;
        private System.Windows.Forms.Button btnFill;
    }
}