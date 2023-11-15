using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrjWinProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuStandard_Click(object sender, EventArgs e)
        {
            frmcalstandard fstd = new frmcalstandard();
            fstd.MdiParent = this;
            fstd.Show();
            fstd.Left = (this.Width - fstd.Width) / 2;
            fstd.Top = (this.Height - fstd.Height) / 2;
        }

        private void mnuScientific_Click(object sender, EventArgs e)
        {
            frmCalScientific fsci = new frmCalScientific();
            fsci.MdiParent = this;
            fsci.Show();
            fsci.Left = (this.Width - fsci.Width) / 2;
            fsci.Top = (this.Height - fsci.Height) / 2;
        }

        private void btnCalStandard_Click(object sender, EventArgs e)
        {
            frmcalstandard fstd = new frmcalstandard();
            fstd.MdiParent = this;
            fstd.Show();
            fstd.Left = (this.Width - fstd.Width) / 2;
            fstd.Top = (this.Height - fstd.Height) / 2;
        }

        private void btnCalScientific_Click(object sender, EventArgs e)
        {
            frmCalScientific fsci = new frmCalScientific();
            fsci.MdiParent = this;
            fsci.Show();
            fsci.Left = (this.Width - fsci.Width) / 2;
            fsci.Top = (this.Height - fsci.Height) / 2;
        }

        private void mnu_tool_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = mnu_tool.Checked ? true : false;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutUs fabt = new AboutUs();
            fabt.MdiParent = this;
            fabt.Show();
            fabt.Left = (this.Width - fabt.Width) / 2;
            fabt.Top = (this.Height - fabt.Height) / 2;
        }

        private void mnuUserMnul_Click(object sender, EventArgs e)
        {
            frmUserMnl fum = new frmUserMnl();
            fum.MdiParent = this;
            fum.Show();
            //fum.Left = (this.Width - fum.Width) / 2;
            //fum.Top = (this.Height - fum.Height) / 2;
        }

        private void mnu_status_Click(object sender, EventArgs e)
        {
            status_str.Visible = mnu_status.Checked ? true : false;
        }

        private void versionLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChange fchng = new frmChange();
            fchng.MdiParent = this;
            fchng.Show();
            fchng.Left = (this.Width - fchng.Width) / 2;
            fchng.Top = (this.Height - fchng.Height) / 2;
        }

        private void versionEnLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBC1exchange fchngall = new frmBC1exchange();
            fchngall.MdiParent = this;
            fchngall.Show();
            fchngall.Left = (this.Width - fchngall.Width) / 2;
            fchngall.Top = (this.Height - fchngall.Height) / 2;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmChange fchng = new frmChange();
            fchng.MdiParent = this;
            fchng.Show();
            fchng.Left = (this.Width - fchng.Width) / 2;
            fchng.Top = (this.Height - fchng.Height) / 2;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmBC1exchange fchngall = new frmBC1exchange();
            fchngall.MdiParent = this;
            fchngall.Show();
            fchngall.Left = (this.Width - fchngall.Width) / 2;
            fchngall.Top = (this.Height - fchngall.Height) / 2;
        }
    }
}
