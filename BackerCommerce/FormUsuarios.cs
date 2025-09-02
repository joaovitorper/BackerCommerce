using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackerCommerce
{


    public partial class FormUsuarios : Form
    {// objetos Globais:
        Model.Usuário usuario;

        public FormUsuarios(Model.Usuário usuario)
        {
            InitializeComponent();
            this.usuario=usuario;

            atualizarDgb();
        }
          public void atualizarDgb()
        {
            dgvUsuarios.DataSource= usuario.listar();
        }

              
            

        

        private void grbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Validar Campo
            if (txtNome.Text.Length > 5)
            {
                MessageBox.Show("o Nome deve ter no minimo 5 Caracteristica.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtEmailCadastro.Text.Length > 7)// a@a.co
            {
                MessageBox.Show(" o email deve ter no minimo 7 caracteristica.",
               "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaCadastro.Text.Length < 6)
            {
                MessageBox.Show(" A Senha  deve ter no minimo 6 caracteristica.",
               "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Usuário usuárioCadastro = new Model.Usuário();

                // Salvar  os valores dos Campos nos atributos  do obj
                usuárioCadastro.NomeCompleto = txtNome.Text;
                usuárioCadastro.Email = txtEmailCadastro.Text;
                usuárioCadastro.Senha =txbSenhaCadastro.Text;

                // Executar o INSERT
                if (usuárioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    atualizarDgb();
                    // Apagar os campos de Cadastro
                    txtNome.Clear();
                    txtEmailCadastro.Clear();
                    txbSenhaCadastro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar usuário!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                

            }
            

        }   
    }
}
