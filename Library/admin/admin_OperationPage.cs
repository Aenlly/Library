using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.admin
{
    public partial class admin_OperationPage : Form
    {
        public admin_OperationPage()
        {
            InitializeComponent();
        }

        private void mcd_time_DateChanged(object sender, DateRangeEventArgs e)
        {
            cmb_time.Text = mcd_time.SelectionStart.ToShortDateString();

            mcd_time.Hide();
        }

        private void cmb_time_MouseDown(object sender, MouseEventArgs e)
        {
            mcd_time.Show();
        }
    }
}
