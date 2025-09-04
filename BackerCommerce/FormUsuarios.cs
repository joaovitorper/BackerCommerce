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


        int idSelecionado = 0; // Armazenar o id do usuário Selecionado P/ apagar ou Editar

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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha Selecionada:
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            //Colocar os valores da Células no txbs de ediçao:
            txtEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txtEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi  Selecionado
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:  
            grbEditar.Enabled = true;


            // Ajustes no grbApagar:
            lblApagardescricao.Text = $"Apagar: {dgvUsuarios.Rows[ls].Cells[1].Value}";


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente  quer Apagar:
            DialogResult r = MessageBox.Show("tem Certeza que deseja Apagar este usuário?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuário usuarioApagar = new Model.Usuário();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com Sucesso!", "show!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                    
                }
                else
                {
                    MessageBox.Show("Falha ao Apagar o Usuario!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Validar Campo
            if (txtEditar.Text.Length > 5)
            {
                MessageBox.Show("o Nome deve ter no minimo 5 Caracteristica.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtEmailEditar.Text.Length > 7)// a@a.co
            {
                MessageBox.Show(" o email deve ter no minimo 7 caracteristica.",
               "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show(" A Senha  deve ter no minimo 6 caracteristica.",
               "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Proseguir com a Ediçao:
                Model.Usuário usuárioEditar = new Model.Usuário();
                usuárioEditar.Id = idSelecionado;
                usuárioEditar.NomeCompleto = txtNome.Text;
                usuárioEditar.Email = txtEmailEditar.Text;
                usuárioEditar.Senha = txtSenhaEditar.Text;

                if(usuárioEditar.Modificar())
                {
                    MessageBox.Show(" Usuário modificado Com Sucesso!",
               "Show ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show(" Falha ao Modificar usuario!", 
               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

           

            
        }
        public void ResetarCampos()
        {
            // atualizar o dvg:
            atualizarDgb();

            // Limpar os Campos de edição
            txtEmailEditar.Clear();
            txtSenhaEditar.Clear();
            txtNome.Clear();

            //  Retornar o idSelecionado para 0
            idSelecionado = 0;


            // Retornar o texto padrão de apagar:
            lblApagardescricao.Text = "Selecione o usuário que deseja Apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

    }
    
} 

 
                

       