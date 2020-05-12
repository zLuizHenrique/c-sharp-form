﻿using System;
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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        string sexo;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
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
            string Obversações = txtobservacoes.Text = "";

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
                " Observação: " + observação + "\n" ); 



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mtbNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}


