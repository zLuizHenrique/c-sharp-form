using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace TDE_Alexandre_Formulario
{
    public partial class Registro2 : Form
    {
        static String path = "C:/Faculdade/Faculdade/Professor Alexandre/Projetos Alexandre GitHub/(c-sharp-form) Formulario/Logge";
        static String file = path + "/Banco.txt";
        public Registro2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text = "";
            string endereço = txtEndereco.Text = "";
            string Bairro = txtBairro.Text = "";
            string EstadoCivil = cmbEstado.Text = "";
            string CEP = txtCEP.Text = "";
            string telefone = txtTelefone.Text = "";
            string Cidade = cmbCidade.Text = "";
            string Estado = cmbEstado.Text = "";
            string Obversações = txtobservacoes.Text = "";

            MessageBox.Show("Formulario Limpo.");





        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            /*
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

              */

            //=================TeacherCode====================//

            //if (String.IsNullOrEmpty(txtName.Text.Trim())) {
            //if (String.IsNullOrEmpty(txtName.Text)) {

            //if (String.IsNullOrWhiteSpace(txtName.Text)) {

            //if (txtName.Text.Length == 0) {
            //if (txtName.Text.Trim().Length == 0) {

            //if (txtName.Text == "") {
            //if (txtName.Text.Trim() == "")

            if (String.IsNullOrWhiteSpace(txtnome.Text))
            {
                // MessageBox.Show("Name is required");
                erpRegistro.SetError(txtnome, "Nome Obrigatório");

                txtnome.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRegistro.SetError(txtnome, "");

                txtnome.BackColor = Color.FromName("Window");
            }

            if (String.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                erpRegistro.SetError(txtEndereco, "Endereço Obrigatório");

                txtEndereco.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRegistro.SetError(txtEndereco, "");

                txtEndereco.BackColor = Color.FromArgb(250, 128, 114);
            }
            if (String.IsNullOrWhiteSpace(txtBairro.Text))
            {
                erpRegistro.SetError(txtBairro, "");
                txtBairro.BackColor = Color.FromArgb(250, 128, 114);

            }
            else
            {
                erpRegistro.SetError(txtBairro, "");
                txtBairro.BackColor = Color.FromArgb(250, 128, 114);

            }
            if (String.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                erpRegistro.SetError(txtBairro, "");
                txtBairro.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpRegistro.SetError(txtBairro, "");
                txtBairro.BackColor = Color.FromArgb(250, 128, 114);
            }


            /* mktPostalCode.Mask = "";

            if (mktPostalCode.Text == "     -")
            //if (mktPostalCode.Mask == mktPostalCode.Text)
            {
                erpCustomer.SetError(mktPostalCode, "CEP is required");

                mktPostalCode.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpCustomer.SetError(mktPostalCode, "");

                mktPostalCode.BackColor = Color.FromName("Window");
            }

            // = Atribuição 
            // == Comparar valores
            // != Diferente
            if (txtPass.Text != txtConPass.Text)
            {
                erpCustomer.SetError(txtConPass, "Passwords does not match");

                txtConPass.BackColor = Color.FromArgb(250, 128, 114);
            }
            else
            {
                erpCustomer.SetError(txtConPass, "");

                txtConPass.BackColor = Color.FromName("Window"); */
            // }


        }

       
        private void btnlimpa_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text = "";
            string endereço = txtEndereco.Text = "";
            string Bairro = txtBairro.Text = "";
            string CEP = txtCEP.Text = "";
            string telefone = txtTelefone.Text = "";
            string Cidade = cmbCidade.Text = "";
            string Estado = cmbEstado.Text = "";
            string Obversações = txtobservacoes.Text = "";

            MessageBox.Show("Formulario Limpo.");





        }


        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtnome.Text))
            {
                erpRegistro.SetError(txtnome, "Campo invalido!");
            }
           
            if (String.IsNullOrEmpty(txtEndereco.Text))
            {
                erpRegistro.SetError(txtEndereco, "Campo invalido!");
            }
            
            if (String.IsNullOrEmpty(txtBairro.Text))
            {
                erpRegistro.SetError(txtBairro, "Campo invalido!");
            }
            
            if (String.IsNullOrEmpty(txtCEP.Text))
            {
                erpRegistro.SetError(txtCEP, "Campo invalido!");
            }
            
            if (String.IsNullOrEmpty(txtTelefone.Text))
            {
                erpRegistro.SetError(txtTelefone, "Campo invalido!");
            }

            if (cmbCidade.SelectedIndex > - 1)
            {
                erpRegistro.SetError(cmbCidade, "Campo invalido!");
            }
            
            if (cmbEstado.SelectedIndex > - 1)
            {
                erpRegistro.SetError(cmbEstado, "Campo invalido!");
            }

            bool checkDirExist = Directory.Exists(path);
            if (!checkDirExist)
            {
                Directory.CreateDirectory(path);
            }

            bool checkFileExist = File.Exists(file);

            String line = txtnome.Text + "|" + txtEndereco.Text + "|" + txtBairro.Text + "|" + txtCEP.Text + "|" + txtTelefone.Text + "|" + cmbCidade.Text + "|" + cmbEstado.Text + "|";

            if (!checkFileExist)
            {
                using (StreamWriter sw = File.CreateText(file))
                {
                    sw.WriteLine(line);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(file))
                {
                    sw.WriteLine(line);
                }
            }

            string nome = txtnome.Text;
            string endereço = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string CEP = txtCEP.Text;
            string telefone = txtTelefone.Text;
            string cidade = cmbCidade.GetItemText(cmbCidade.SelectedItem);
            string estado = cmbEstado.GetItemText(cmbEstado.SelectedItem);
            string observação = txtobservacoes.Text;

            //MessageBox.Show(
            //    " Nome: " + nome + "\n" +
            //    " Endereço: " + endereço + "\n" +
            //    " Bairro: " + bairro +
            //    " CEP: " + CEP + "\n" +
            //    " Telefone: " + telefone + "\n" +
            //    " Cidade: " + cidade + "\n" +
            //    " Estado: " + estado + "\n" +
            //    " Observação: " + observação + "\n");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}



