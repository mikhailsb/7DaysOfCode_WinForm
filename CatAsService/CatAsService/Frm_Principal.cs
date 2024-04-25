using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            this.Text = "Bem vindo ao Cat As Service";
            lbl_frmPrincipal.Text = "Bem vindo ao Cat As Service";
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BuscarRacas frmBusca = new frm_BuscarRacas();
            frmBusca.ShowDialog();
            frmBusca.Focus();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Favoritas frmFavorito = new frm_Favoritas();
            frmFavorito.ShowDialog();
            frmFavorito.Focus();
        }
    }
}
