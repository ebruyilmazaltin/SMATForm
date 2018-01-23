using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class FrmIsGuvenligi : Form
    {
        public Form frmUsers;
        public Form frmDeterminations;
        public FrmIsGuvenligi()
        {
            InitializeComponent();
        }

        private void kişiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUsers == null || frmUsers.IsDisposed)
            {
                frmUsers = new frmUsers();
                frmUsers.MdiParent = this;
            }
            frmUsers.Show();
        }

        private void tespitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDeterminations == null || frmDeterminations.IsDisposed)
            {
                frmDeterminations = new frmDeterminations();
                frmDeterminations.MdiParent = this;
            }
            frmDeterminations.Show();
        }
    }
}
