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

                // Tabela que vai receber o resultado Do Select (Logar)
                DataTable resultado = usuario.Logar();

                // Verifica se acertou o email e senha:
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e /ou senha invalidos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Armazenar as infos vindas do bd no objeto "usuario"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para Menu Principal:
                    Menu_Principal menuPrincipal = new Menu_Principal();
                    Hide(); // Esconder a janela Atual:
                    menuPrincipal.ShowDialog();// Mostrar o MenuPrincipal
                    Show(); // Mostrar a tela de login ao sair do menu Principal


                }


            }
        }
    }
}
