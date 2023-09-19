using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistriColor
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("       ¿Desea SALIR del programa?.\n\nSe perderán los cambios NO guardados...", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
