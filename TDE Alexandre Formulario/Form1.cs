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
        string sexo;
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text = "";
            string endereço = txtEndereco.Text = "";
            string Bairro = txtBairro.Text = "";
            string EstadoCivil = cmbEstadoCivil.Text = "";
            string CEP = txtCEP.Text = "";
            string telefone = mtbTelefone.Text = "";
            string Cidade = cmbCidade.Text = "";
            string Estado = cmbEstado.Text = "";
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            cmbCidade.SelectedIndex = - 1;
            cmbEstado.SelectedIndex = - 1;
            cmbEstadoCivil.SelectedIndex = - 1;
            dtpNascimento.Text = "03/04/2020";
            string CPF = mtxtCPF.Text = "";
            string observacao = txtobservacoes.Text = "";

            MessageBox.Show("Formulario Limpo.");





        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string endereço = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string CEP = txtCEP.Text;
            string telefone = mtbTelefone.Text;
            string cidade = cmbCidade.GetItemText(cmbCidade.SelectedItem);
            string estado = cmbEstado.GetItemText(cmbEstado.SelectedItem);
            string Nascimento = dtpNascimento.Text;
            string CPF = mtxtCPF.Text;
            string estadocivil = cmbEstadoCivil.GetItemText(cmbEstadoCivil.SelectedItem);
            string observação = txtobservacoes.Text;

            if (rdbMasculino.Checked)
            {
                sexo = "Masculino ";
            }
            else if (rdbFeminino.Checked)
            {
                sexo = "Feminino ";
            }

            MessageBox.Show( 
                " Nome: " + nome + "\n" +
                " Endereço: " + endereço + "\n" +
                " Bairro: " + bairro + "\n" +
                " CEP: " + CEP + "\n" + 
                " Telefone: " + telefone + "\n" + 
                " Cidade: " + cidade + "\n" + 
                " Estado: " + estado + "\n" +
                " Estado Civil: " + estadocivil + "\n" +
                " Sexo: " + sexo + "\n" +
                " CPF: " + CPF + "\n" + 
                " Observação: " + observação + "\n" ); 



        }
    }
}



