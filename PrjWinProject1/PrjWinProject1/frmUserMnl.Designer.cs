namespace PrjWinProject1
{
    partial class frmUserMnl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaindesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStd_desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSci_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Manual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Form";
            // 
            // txtMaindesc
            // 
            this.txtMaindesc.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaindesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaindesc.Location = new System.Drawing.Point(62, 199);
            this.txtMaindesc.Multiline = true;
            this.txtMaindesc.Name = "txtMaindesc";
            this.txtMaindesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMaindesc.Size = new System.Drawing.Size(887, 184);
            this.txtMaindesc.TabIndex = 2;
            this.txtMaindesc.TabStop = false;
            this.txtMaindesc.TextChanged += new System.EventHandler(this.txtMaindesc_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Standard Calculator";
            // 
            // txtStd_desc
            // 
            this.txtStd_desc.BackColor = System.Drawing.SystemColors.Control;
            this.txtStd_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStd_desc.Location = new System.Drawing.Point(62, 469);
            this.txtStd_desc.Multiline = true;
            this.txtStd_desc.Name = "txtStd_desc";
            this.txtStd_desc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStd_desc.Size = new System.Drawing.Size(887, 184);
            this.txtStd_desc.TabIndex = 4;
            this.txtStd_desc.TextChanged += new System.EventHandler(this.txtStd_desc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Scientific Calculator";
            // 
            // txtSci_desc
            // 
            this.txtSci_desc.BackColor = System.Drawing.SystemColors.Control;
            this.txtSci_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSci_desc.Location = new System.Drawing.Point(62, 769);
            this.txtSci_desc.Multiline = true;
            this.txtSci_desc.Name = "txtSci_desc";
            this.txtSci_desc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSci_desc.Size = new System.Drawing.Size(887, 184);
            this.txtSci_desc.TabIndex = 6;
            this.txtSci_desc.TextChanged += new System.EventHandler(this.txtSci_desc_TextChanged);
            // 
            // frmUserMnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 1212);
            this.Controls.Add(this.txtSci_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStd_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaindesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUserMnl";
            this.Text = "frmUserMnl";
            this.Load += new System.EventHandler(this.frmUserMnl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaindesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStd_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSci_desc;
    }
}