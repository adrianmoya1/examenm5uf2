using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenM5
{
    public partial class FrmMain : Form
    {
        private FrmMenjar frmMen = null;
        private FrmVintage frmVin = null;
        private FrmAnimal frmAn = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btMenjar_Click(object sender, EventArgs e)
        {
            frmMen = new FrmMenjar();
            frmMen.Show();
        }

        private void btVintage_Click(object sender, EventArgs e)
        {
            frmVin = new FrmVintage();
            frmVin.Show();
        }

        private void btAnimal_Click(object sender, EventArgs e)
        {
            frmAn = new FrmAnimal();
            frmAn.Show();
        }
    }
}
