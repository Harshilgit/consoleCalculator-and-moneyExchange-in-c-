namespace PrjWinProject1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScientific = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauDeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionEnLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_status = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserMnul = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCalStandard = new System.Windows.Forms.ToolStripButton();
            this.btnCalScientific = new System.Windows.Forms.ToolStripButton();
            this.status_str = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.status_str.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmesToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmesToolStripMenuItem
            // 
            this.programmesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.bureauDeChangeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.programmesToolStripMenuItem.Name = "programmesToolStripMenuItem";
            this.programmesToolStripMenuItem.Size = new System.Drawing.Size(168, 40);
            this.programmesToolStripMenuItem.Text = "Programmes";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStandard,
            this.mnuScientific});
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // mnuStandard
            // 
            this.mnuStandard.Name = "mnuStandard";
            this.mnuStandard.Size = new System.Drawing.Size(328, 44);
            this.mnuStandard.Text = "Version Standard";
            this.mnuStandard.Click += new System.EventHandler(this.mnuStandard_Click);
            // 
            // mnuScientific
            // 
            this.mnuScientific.Name = "mnuScientific";
            this.mnuScientific.Size = new System.Drawing.Size(328, 44);
            this.mnuScientific.Text = "Version Scientific";
            this.mnuScientific.Click += new System.EventHandler(this.mnuScientific_Click);
            // 
            // bureauDeChangeToolStripMenuItem
            // 
            this.bureauDeChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionLocalToolStripMenuItem,
            this.versionEnLigneToolStripMenuItem});
            this.bureauDeChangeToolStripMenuItem.Name = "bureauDeChangeToolStripMenuItem";
            this.bureauDeChangeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.bureauDeChangeToolStripMenuItem.Text = "Bureau de change";
            // 
            // versionLocalToolStripMenuItem
            // 
            this.versionLocalToolStripMenuItem.Name = "versionLocalToolStripMenuItem";
            this.versionLocalToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.versionLocalToolStripMenuItem.Text = "Version Local";
            this.versionLocalToolStripMenuItem.Click += new System.EventHandler(this.versionLocalToolStripMenuItem_Click);
            // 
            // versionEnLigneToolStripMenuItem
            // 
            this.versionEnLigneToolStripMenuItem.Name = "versionEnLigneToolStripMenuItem";
            this.versionEnLigneToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.versionEnLigneToolStripMenuItem.Text = "Version en ligne";
            this.versionEnLigneToolStripMenuItem.Click += new System.EventHandler(this.versionEnLigneToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_tool,
            this.mnu_status});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnu_tool
            // 
            this.mnu_tool.Name = "mnu_tool";
            this.mnu_tool.Size = new System.Drawing.Size(245, 44);
            this.mnu_tool.Text = "Toolbar";
            this.mnu_tool.Click += new System.EventHandler(this.mnu_tool_Click);
            // 
            // mnu_status
            // 
            this.mnu_status.Name = "mnu_status";
            this.mnu_status.Size = new System.Drawing.Size(245, 44);
            this.mnu_status.Text = "Statusbar";
            this.mnu_status.Click += new System.EventHandler(this.mnu_status_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserMnul,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuUserMnul
            // 
            this.mnuUserMnul.Name = "mnuUserMnul";
            this.mnuUserMnul.Size = new System.Drawing.Size(281, 44);
            this.mnuUserMnul.Text = "User Manual";
            this.mnuUserMnul.Click += new System.EventHandler(this.mnuUserMnul_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(281, 44);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCalStandard,
            this.btnCalScientific,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 50);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCalStandard
            // 
            this.btnCalStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalStandard.Image = ((System.Drawing.Image)(resources.GetObject("btnCalStandard.Image")));
            this.btnCalStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalStandard.Name = "btnCalStandard";
            this.btnCalStandard.Size = new System.Drawing.Size(46, 44);
            this.btnCalStandard.Text = "CalStandard";
            this.btnCalStandard.Click += new System.EventHandler(this.btnCalStandard_Click);
            // 
            // btnCalScientific
            // 
            this.btnCalScientific.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalScientific.Image = ((System.Drawing.Image)(resources.GetObject("btnCalScientific.Image")));
            this.btnCalScientific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalScientific.Name = "btnCalScientific";
            this.btnCalScientific.Size = new System.Drawing.Size(46, 36);
            this.btnCalScientific.Text = "CalScientific";
            this.btnCalScientific.Click += new System.EventHandler(this.btnCalScientific_Click);
            // 
            // status_str
            // 
            this.status_str.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.status_str.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status_str.Location = new System.Drawing.Point(0, 701);
            this.status_str.Name = "status_str";
            this.status_str.Size = new System.Drawing.Size(956, 42);
            this.status_str.TabIndex = 2;
            this.status_str.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 32);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(956, 743);
            this.Controls.Add(this.status_str);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "College Lasalle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.status_str.ResumeLayout(false);
            this.status_str.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStandard;
        private System.Windows.Forms.ToolStripMenuItem mnuScientific;
        private System.Windows.Forms.ToolStripMenuItem bureauDeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionEnLigneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_tool;
        private System.Windows.Forms.ToolStripMenuItem mnu_status;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUserMnul;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip status_str;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnCalStandard;
        private System.Windows.Forms.ToolStripButton btnCalScientific;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

