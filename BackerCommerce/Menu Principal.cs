using BackerCommerce.Model;
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
    public partial class Menu_Principal : Form
    {
       // Variaveis globais:
        Model.Usuário usuario = new Model.Usuário();
        public Menu_Principal(Model.Usuário usuário)
        {
            InitializeComponent();
            this.usuario = usuário;
            lblDescricao.Text = $"{usuario.NomeCompleto}, \nEscolha uma opção abaixo:";

            
        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
         FormUsuarios formUsuarios = new FormUsuarios(usuario);
         formUsuarios.ShowDialog();// Mostrar o form 
         
        }
    }
}
