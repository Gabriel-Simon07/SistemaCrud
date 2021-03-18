
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class TelaCrud : Form
    {
        public TelaCrud()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCrud_Load(object sender, EventArgs e)
        {
            tblRegistros.DataSource = Global.Consultar();
        }

        private void tblRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Global salvar = new Global(
                txtCliente.Text,txtPedido.Text,int.Parse(txtQtdProd.Text),float.Parse(txtUni.Text),
                float.Parse(txtTotal.Text));
        }
    }
}
