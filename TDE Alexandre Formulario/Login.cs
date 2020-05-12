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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Campos Obrigatórios");
            }
            else
            {
                if (txtUsuario.Text == "luh" && txtSenha.Text == "luh")
                {
                    this.Hide();

                    Form registro = new Principal();

                    registro.Closed += (s,a) => this.Close();

                    registro.Show();

                }
                else
                {
                    MessageBox.Show("LoginIncorreto");
                }
             
            }   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
