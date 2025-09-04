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
    public partial class Form_Caixa : Form
    {
        Model.Usuário Usuário;

        public Form_Caixa(Model.Usuário usuário)
        {
            InitializeComponent();
            Usuário=usuário;
        }
    }
}
