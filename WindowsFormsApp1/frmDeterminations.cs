using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDeterminations : Form
    {
        public frmDeterminations()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Bu SMAT için S-TWTTP formu iste.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Bu SMAT için S-TWTTP formu iste.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            label7.BackColor = Color.MediumSeaGreen;
           
        }
    }
}
