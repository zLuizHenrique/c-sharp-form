using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_Alexandre_Formulario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mmuPessoaFisica_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
          
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();

            //Application.Exit();
            // Fecha todo o programa.
            // --------------------------------------------------------
            //this.Close();
            //Ele fecha o formulário, pórem deixa a Tela de Login aberta. 
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja sair do Sistema?", "Atenção", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Environment.Exit(4);
            }
            else if (DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
