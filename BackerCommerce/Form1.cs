using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackerCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a Pessoa Digitou o Email e Senha
            if (txtEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um Email invalido",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma Senha invalido",
             "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proseguir
                Model.Usuário usuario = new Model.Usuário();
                
                //Colocar os valores dos Campos nos Atributos do Usuários:
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
            }
        }
    }
}
