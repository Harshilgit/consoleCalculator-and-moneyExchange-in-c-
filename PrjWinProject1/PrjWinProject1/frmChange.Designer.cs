namespace PrjWinProject1
{
    partial class frmChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFraToUs = new System.Windows.Forms.RadioButton();
            this.radUsToFra = new System.Windows.Forms.RadioButton();
            this.lblUsToFra = new System.Windows.Forms.Label();
            this.lblFraToUs = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU-XCHANGE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFraToUs);
            this.groupBox1.Controls.Add(this.radUsToFra);
            this.groupBox1.Location = new System.Drawing.Point(98, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // radFraToUs
            // 
            this.radFraToUs.AutoSize = true;
            this.radFraToUs.Location = new System.Drawing.Point(41, 94);
            this.radFraToUs.Name = "radFraToUs";
            this.radFraToUs.Size = new System.Drawing.Size(184, 29);
            this.radFraToUs.TabIndex = 1;
            this.radFraToUs.TabStop = true;
            this.radFraToUs.Text = "France to USD";
            this.radFraToUs.UseVisualStyleBackColor = true;
            this.radFraToUs.CheckedChanged += new System.EventHandler(this.radFraToUs_CheckedChanged);
            // 
            // radUsToFra
            // 
            this.radUsToFra.AutoSize = true;
            this.radUsToFra.Location = new System.Drawing.Point(41, 43);
            this.radUsToFra.Name = "radUsToFra";
            this.radUsToFra.Size = new System.Drawing.Size(184, 29);
            this.radUsToFra.TabIndex = 0;
            this.radUsToFra.TabStop = true;
            this.radUsToFra.Text = "USD to France";
            this.radUsToFra.UseVisualStyleBackColor = true;
            this.radUsToFra.CheckedChanged += new System.EventHandler(this.radUsToFra_CheckedChanged);
            // 
            // lblUsToFra
            // 
            this.lblUsToFra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsToFra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsToFra.Location = new System.Drawing.Point(494, 194);
            this.lblUsToFra.Name = "lblUsToFra";
            this.lblUsToFra.Size = new System.Drawing.Size(356, 50);
            this.lblUsToFra.TabIndex = 3;
            this.lblUsToFra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFraToUs
            // 
            this.lblFraToUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFraToUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFraToUs.Location = new System.Drawing.Point(494, 268);
            this.lblFraToUs.Name = "lblFraToUs";
            this.lblFraToUs.Size = new System.Drawing.Size(356, 50);
            this.lblFraToUs.TabIndex = 4;
            this.lblFraToUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrency
            // 
            this.lblCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(535, 396);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(179, 40);
            this.lblCurrency.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(535, 458);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(182, 31);
            this.txtInput.TabIndex = 6;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(784, 413);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(136, 45);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(784, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(784, 528);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(136, 45);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(98, 582);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(356, 50);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(98, 158);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(285, 33);
            this.cboCountry.TabIndex = 11;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(942, 676);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblFraToUs);
            this.Controls.Add(this.lblUsToFra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmChange";
            this.Text = "Bureau de Change local";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFraToUs;
        private System.Windows.Forms.RadioButton radUsToFra;
        private System.Windows.Forms.Label lblUsToFra;
        private System.Windows.Forms.Label lblFraToUs;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cboCountry;
    }
}