using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ADO_ApartmentOtomation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            new IForm().Show();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            new EForm().Show();
        }
    }
}
