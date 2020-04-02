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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtobservacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text = "";
            string código = txtcodigo.Text = "";
            string endereço = txtEndereco.Text = "";
            string Bairro = txtBairro.Text = "";
            string CEP = txtCEP.Text = "";
            string telefone = txtTelefone.Text = "";
            string Cidade = cmbCidade.Text = "";
            string Estado = cmbEstado.Text = "";
            string Obversações = txtobservacoes.Text = "";

            MessageBox.Show("Formulario Limpo.");





        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            String codigo = txtcodigo.Text;
            string nome = txtnome.Text;
            string endereço = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string CEP = txtCEP.Text;
            string telefone = txtTelefone.Text;
            string cidade = cmbCidade.GetItemText(cmbCidade.SelectedItem);
            string estado = cmbEstado.GetItemText(cmbEstado.SelectedItem);
            string observação = txtobservacoes.Text;

            MessageBox.Show("codigo: " + codigo + "\n" + 
                " Nome: " + nome + "\n" +
                " Endereço: " + endereço + "\n" +
                " Bairro: " + bairro +
                " CEP: " + CEP + "\n" + 
                " Telefone: " + telefone + "\n" + 
                " Cidade: " + cidade + "\n" + 
                " Estado: " + estado + "\n" + 
                " Observação: " + observação + "\n" ); 



        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



