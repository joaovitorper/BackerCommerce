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
    public partial class Form_Produtos : Form
    {
        Model.Usuário usuario;

        public Form_Produtos(Model.Usuário usuario)
        {
            InitializeComponent();
            this.usuario=usuario;
            ListarCategoriasCmb();


        }
        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela pra Receber o Resultado do SDelect
            DataTable tabela = categoria.listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1- Salgados
                //2- Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }

        }
    }
}
