using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_projeto
{
    public partial class MDIprincipal : Form
    {
        private int childFormNumber = 0;

        public MDIprincipal()
        {
            InitializeComponent();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroParaUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cad_user frm_cad_user = new frm_cad_user();
            frm_cad_user.MdiParent = this;
            frm_cad_user.Show();
        }

        private void cadastroParaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_prod frm_Prod = new frm_prod();
           frm_Prod.MdiParent = this;
           frm_Prod.Show();
        }

        private void cadastroParaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoria frm_categoria = new frm_categoria();  
            frm_categoria.MdiParent = this;
            frm_categoria.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
