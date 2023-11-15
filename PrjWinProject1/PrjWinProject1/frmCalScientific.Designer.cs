namespace PrjWinProject1
{
    partial class frmCalScientific
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
            this.lblShowOperation = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ans = new System.Windows.Forms.Button();
            this.btn_fraction = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_inverse = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn_ln = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_10power = new System.Windows.Forms.Button();
            this.btn_XtoY = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_pie = new System.Windows.Forms.Button();
            this.btn_2nd = new System.Windows.Forms.Button();
            this.btn_open_par = new System.Windows.Forms.Button();
            this.btn_close_par = new System.Windows.Forms.Button();
            this.btn_factorial = new System.Windows.Forms.Button();
            this.btn_modX = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_M = new System.Windows.Forms.Button();
            this.btn_MS = new System.Windows.Forms.Button();
            this.btnM_minus = new System.Windows.Forms.Button();
            this.btnM_plus = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_MC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowOperation
            // 
            this.lblShowOperation.AutoSize = true;
            this.lblShowOperation.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOperation.Location = new System.Drawing.Point(651, 75);
            this.lblShowOperation.Name = "lblShowOperation";
            this.lblShowOperation.Size = new System.Drawing.Size(0, 31);
            this.lblShowOperation.TabIndex = 59;
            this.lblShowOperation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 135);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(799, 80);
            this.txtDisplay.TabIndex = 58;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 61);
            this.label1.TabIndex = 57;
            this.label1.Text = "Scientific";
            // 
            // btn_ans
            // 
            this.btn_ans.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ans.FlatAppearance.BorderSize = 0;
            this.btn_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ans.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ans.Location = new System.Drawing.Point(657, 707);
            this.btn_ans.Name = "btn_ans";
            this.btn_ans.Size = new System.Drawing.Size(155, 56);
            this.btn_ans.TabIndex = 56;
            this.btn_ans.Text = "=";
            this.btn_ans.UseVisualStyleBackColor = false;
            this.btn_ans.Click += new System.EventHandler(this.btn_ans_Click);
            // 
            // btn_fraction
            // 
            this.btn_fraction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_fraction.FlatAppearance.BorderSize = 0;
            this.btn_fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fraction.Location = new System.Drawing.Point(496, 705);
            this.btn_fraction.Name = "btn_fraction";
            this.btn_fraction.Size = new System.Drawing.Size(155, 56);
            this.btn_fraction.TabIndex = 55;
            this.btn_fraction.Text = ".";
            this.btn_fraction.UseVisualStyleBackColor = false;
            this.btn_fraction.Click += new System.EventHandler(this.numbers);
            // 
            // btn_sign
            // 
            this.btn_sign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sign.FlatAppearance.BorderSize = 0;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.Location = new System.Drawing.Point(174, 705);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(155, 56);
            this.btn_sign.TabIndex = 54;
            this.btn_sign.Text = "+/-";
            this.btn_sign.UseVisualStyleBackColor = false;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(335, 705);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(155, 56);
            this.btn0.TabIndex = 53;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numbers);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(657, 645);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 56);
            this.btn_add.TabIndex = 52;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sub.FlatAppearance.BorderSize = 0;
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sub.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(657, 583);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(155, 56);
            this.btn_sub.TabIndex = 51;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_multi.FlatAppearance.BorderSize = 0;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multi.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(657, 521);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(155, 56);
            this.btn_multi.TabIndex = 50;
            this.btn_multi.Text = "x";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_division.FlatAppearance.BorderSize = 0;
            this.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_division.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(657, 457);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(155, 56);
            this.btn_division.TabIndex = 49;
            this.btn_division.Text = "÷";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(657, 333);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(155, 56);
            this.btn_back.TabIndex = 48;
            this.btn_back.Text = "⌫";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.Location = new System.Drawing.Point(496, 333);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(155, 56);
            this.btn_C.TabIndex = 47;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_root
            // 
            this.btn_root.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_root.FlatAppearance.BorderSize = 0;
            this.btn_root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_root.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_root.Location = new System.Drawing.Point(13, 457);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(155, 56);
            this.btn_root.TabIndex = 44;
            this.btn_root.Text = "√x";
            this.btn_root.UseVisualStyleBackColor = false;
            this.btn_root.Click += new System.EventHandler(this.btn_root_Click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_square.FlatAppearance.BorderSize = 0;
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_square.Location = new System.Drawing.Point(13, 395);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(155, 56);
            this.btn_square.TabIndex = 43;
            this.btn_square.Text = "x²";
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_inverse
            // 
            this.btn_inverse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inverse.FlatAppearance.BorderSize = 0;
            this.btn_inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inverse.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inverse.Location = new System.Drawing.Point(174, 395);
            this.btn_inverse.Name = "btn_inverse";
            this.btn_inverse.Size = new System.Drawing.Size(155, 56);
            this.btn_inverse.TabIndex = 42;
            this.btn_inverse.Text = "1/x";
            this.btn_inverse.UseVisualStyleBackColor = false;
            this.btn_inverse.Click += new System.EventHandler(this.btn_inverse_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(496, 519);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(155, 56);
            this.btn9.TabIndex = 41;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(335, 519);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(155, 56);
            this.btn8.TabIndex = 40;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numbers);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(174, 519);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(155, 56);
            this.btn7.TabIndex = 39;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numbers);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(496, 581);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(155, 56);
            this.btn6.TabIndex = 38;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(335, 581);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(155, 56);
            this.btn5.TabIndex = 37;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numbers);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(174, 581);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(155, 56);
            this.btn4.TabIndex = 36;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numbers);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(496, 643);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(155, 56);
            this.btn3.TabIndex = 35;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(335, 643);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(155, 56);
            this.btn2.TabIndex = 34;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(174, 643);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(155, 56);
            this.btn1.TabIndex = 33;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numbers);
            // 
            // btn_ln
            // 
            this.btn_ln.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ln.FlatAppearance.BorderSize = 0;
            this.btn_ln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ln.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ln.Location = new System.Drawing.Point(13, 705);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(155, 56);
            this.btn_ln.TabIndex = 66;
            this.btn_ln.Text = "ln";
            this.btn_ln.UseVisualStyleBackColor = false;
            this.btn_ln.Click += new System.EventHandler(this.btn_ln_Click);
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(13, 643);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(155, 56);
            this.btn_log.TabIndex = 67;
            this.btn_log.Text = "log";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_10power
            // 
            this.btn_10power.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_10power.FlatAppearance.BorderSize = 0;
            this.btn_10power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_10power.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10power.Location = new System.Drawing.Point(13, 581);
            this.btn_10power.Name = "btn_10power";
            this.btn_10power.Size = new System.Drawing.Size(155, 56);
            this.btn_10power.TabIndex = 68;
            this.btn_10power.Text = "10^x";
            this.btn_10power.UseVisualStyleBackColor = false;
            this.btn_10power.Click += new System.EventHandler(this.btn_10power_Click);
            // 
            // btn_XtoY
            // 
            this.btn_XtoY.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_XtoY.FlatAppearance.BorderSize = 0;
            this.btn_XtoY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XtoY.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XtoY.Location = new System.Drawing.Point(12, 519);
            this.btn_XtoY.Name = "btn_XtoY";
            this.btn_XtoY.Size = new System.Drawing.Size(155, 56);
            this.btn_XtoY.TabIndex = 69;
            this.btn_XtoY.Text = "x^y";
            this.btn_XtoY.UseVisualStyleBackColor = false;
            this.btn_XtoY.Click += new System.EventHandler(this.btn_XtoY_Click);
            // 
            // btn_e
            // 
            this.btn_e.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_e.FlatAppearance.BorderSize = 0;
            this.btn_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_e.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_e.Location = new System.Drawing.Point(335, 333);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(155, 56);
            this.btn_e.TabIndex = 72;
            this.btn_e.Text = "e";
            this.btn_e.UseVisualStyleBackColor = false;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_pie
            // 
            this.btn_pie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pie.FlatAppearance.BorderSize = 0;
            this.btn_pie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pie.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pie.Location = new System.Drawing.Point(174, 333);
            this.btn_pie.Name = "btn_pie";
            this.btn_pie.Size = new System.Drawing.Size(155, 56);
            this.btn_pie.TabIndex = 71;
            this.btn_pie.Text = "∏";
            this.btn_pie.UseVisualStyleBackColor = false;
            this.btn_pie.Click += new System.EventHandler(this.btn_pie_Click);
            // 
            // btn_2nd
            // 
            this.btn_2nd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_2nd.FlatAppearance.BorderSize = 0;
            this.btn_2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2nd.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2nd.Location = new System.Drawing.Point(13, 333);
            this.btn_2nd.Name = "btn_2nd";
            this.btn_2nd.Size = new System.Drawing.Size(155, 56);
            this.btn_2nd.TabIndex = 70;
            this.btn_2nd.Text = "2nd";
            this.btn_2nd.UseVisualStyleBackColor = false;
            // 
            // btn_open_par
            // 
            this.btn_open_par.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_open_par.FlatAppearance.BorderSize = 0;
            this.btn_open_par.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_par.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_par.Location = new System.Drawing.Point(174, 457);
            this.btn_open_par.Name = "btn_open_par";
            this.btn_open_par.Size = new System.Drawing.Size(155, 56);
            this.btn_open_par.TabIndex = 73;
            this.btn_open_par.Text = "(";
            this.btn_open_par.UseVisualStyleBackColor = false;
            this.btn_open_par.Click += new System.EventHandler(this.btn_open_par_Click);
            // 
            // btn_close_par
            // 
            this.btn_close_par.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close_par.FlatAppearance.BorderSize = 0;
            this.btn_close_par.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_par.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_par.Location = new System.Drawing.Point(335, 457);
            this.btn_close_par.Name = "btn_close_par";
            this.btn_close_par.Size = new System.Drawing.Size(155, 56);
            this.btn_close_par.TabIndex = 74;
            this.btn_close_par.Text = ")";
            this.btn_close_par.UseVisualStyleBackColor = false;
            this.btn_close_par.Click += new System.EventHandler(this.btn_close_par_Click);
            // 
            // btn_factorial
            // 
            this.btn_factorial.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_factorial.FlatAppearance.BorderSize = 0;
            this.btn_factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factorial.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factorial.Location = new System.Drawing.Point(496, 457);
            this.btn_factorial.Name = "btn_factorial";
            this.btn_factorial.Size = new System.Drawing.Size(155, 56);
            this.btn_factorial.TabIndex = 75;
            this.btn_factorial.Text = "n!";
            this.btn_factorial.UseVisualStyleBackColor = false;
            this.btn_factorial.Click += new System.EventHandler(this.btn_factorial_Click);
            // 
            // btn_modX
            // 
            this.btn_modX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_modX.FlatAppearance.BorderSize = 0;
            this.btn_modX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modX.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modX.Location = new System.Drawing.Point(335, 395);
            this.btn_modX.Name = "btn_modX";
            this.btn_modX.Size = new System.Drawing.Size(155, 56);
            this.btn_modX.TabIndex = 76;
            this.btn_modX.Text = "|x|";
            this.btn_modX.UseVisualStyleBackColor = false;
            this.btn_modX.Click += new System.EventHandler(this.btn_modX_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_exp.FlatAppearance.BorderSize = 0;
            this.btn_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exp.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exp.Location = new System.Drawing.Point(496, 395);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(155, 56);
            this.btn_exp.TabIndex = 77;
            this.btn_exp.Text = "exp";
            this.btn_exp.UseVisualStyleBackColor = false;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_mod.FlatAppearance.BorderSize = 0;
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(657, 395);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(155, 56);
            this.btn_mod.TabIndex = 78;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = false;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_M
            // 
            this.btn_M.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_M.FlatAppearance.BorderSize = 0;
            this.btn_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_M.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_M.Location = new System.Drawing.Point(711, 274);
            this.btn_M.Name = "btn_M";
            this.btn_M.Size = new System.Drawing.Size(101, 51);
            this.btn_M.TabIndex = 84;
            this.btn_M.Text = "M";
            this.btn_M.UseVisualStyleBackColor = false;
            // 
            // btn_MS
            // 
            this.btn_MS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MS.FlatAppearance.BorderSize = 0;
            this.btn_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MS.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MS.Location = new System.Drawing.Point(521, 275);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(101, 53);
            this.btn_MS.TabIndex = 83;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = false;
            this.btn_MS.Click += new System.EventHandler(this.btn_MS_Click_1);
            // 
            // btnM_minus
            // 
            this.btnM_minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM_minus.FlatAppearance.BorderSize = 0;
            this.btnM_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_minus.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_minus.Location = new System.Drawing.Point(389, 275);
            this.btnM_minus.Name = "btnM_minus";
            this.btnM_minus.Size = new System.Drawing.Size(101, 53);
            this.btnM_minus.TabIndex = 82;
            this.btnM_minus.Text = "M-";
            this.btnM_minus.UseVisualStyleBackColor = false;
            this.btnM_minus.Click += new System.EventHandler(this.btnM_minus_Click);
            // 
            // btnM_plus
            // 
            this.btnM_plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnM_plus.FlatAppearance.BorderSize = 0;
            this.btnM_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM_plus.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM_plus.Location = new System.Drawing.Point(257, 275);
            this.btnM_plus.Name = "btnM_plus";
            this.btnM_plus.Size = new System.Drawing.Size(101, 52);
            this.btnM_plus.TabIndex = 81;
            this.btnM_plus.Text = "M+";
            this.btnM_plus.UseVisualStyleBackColor = false;
            this.btnM_plus.Click += new System.EventHandler(this.btnM_plus_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MR.FlatAppearance.BorderSize = 0;
            this.btn_MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MR.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MR.Location = new System.Drawing.Point(134, 275);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(101, 52);
            this.btn_MR.TabIndex = 80;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = false;
            this.btn_MR.Click += new System.EventHandler(this.btn_MR_Click);
            // 
            // btn_MC
            // 
            this.btn_MC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MC.FlatAppearance.BorderSize = 0;
            this.btn_MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MC.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MC.Location = new System.Drawing.Point(13, 275);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(101, 52);
            this.btn_MC.TabIndex = 79;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = false;
            this.btn_MC.Click += new System.EventHandler(this.btn_MC_Click);
            // 
            // frmCalScientific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(824, 771);
            this.Controls.Add(this.btn_M);
            this.Controls.Add(this.btn_MS);
            this.Controls.Add(this.btnM_minus);
            this.Controls.Add(this.btnM_plus);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_modX);
            this.Controls.Add(this.btn_factorial);
            this.Controls.Add(this.btn_close_par);
            this.Controls.Add(this.btn_open_par);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btn_pie);
            this.Controls.Add(this.btn_2nd);
            this.Controls.Add(this.btn_XtoY);
            this.Controls.Add(this.btn_10power);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.lblShowOperation);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ans);
            this.Controls.Add(this.btn_fraction);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_root);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_inverse);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.Name = "frmCalScientific";
            this.Text = "frmCalScientific";
            this.Load += new System.EventHandler(this.frmCalScientific_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShowOperation;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ans;
        private System.Windows.Forms.Button btn_fraction;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_inverse;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn_ln;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_10power;
        private System.Windows.Forms.Button btn_XtoY;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_pie;
        private System.Windows.Forms.Button btn_2nd;
        private System.Windows.Forms.Button btn_open_par;
        private System.Windows.Forms.Button btn_close_par;
        private System.Windows.Forms.Button btn_factorial;
        private System.Windows.Forms.Button btn_modX;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_M;
        private System.Windows.Forms.Button btn_MS;
        private System.Windows.Forms.Button btnM_minus;
        private System.Windows.Forms.Button btnM_plus;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_MC;
    }
}