using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week13_Part2.Views;

namespace Week13_Part2
{
  
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm document = new ChildForm();
            document.MdiParent = this;
            document.Text = "Document" + this.MdiChildren.Length;
            document.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = (toolStrip1.Visible) ? false : true;
        }
        private void statusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusStrip1.Visible = (statusStrip1.Visible) ? false : true;
        }
    }
}
