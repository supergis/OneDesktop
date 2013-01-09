using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OneDesktop
{
    public partial class UCDialogue : UserControl
    {
        public UCDialogue()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormLogin frmlogin = new FormLogin();
            frmlogin.ShowDialog();
        }
    }
}
