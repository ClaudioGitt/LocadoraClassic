using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaGenero frmTelaGenero=new FrmTelaGenero();
            frmTelaGenero.Show();
        }

        private void FrmCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria=new FrmCategoria();
            frmCategoria.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilmes frmFilmes=new FrmFilmes();
            frmFilmes.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes=new FrmClientes();
            frmClientes.Show();
        }
    }
}
