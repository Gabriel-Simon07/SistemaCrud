
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
        private void preencheTbl(List<Global> listatbl)
        {
            tblRegistros.DataSource = new BindingList<Global>(listatbl);
        }
        private void limpaTela()
        {
            txtCliente.Text = "";
            txtProduto.Text = "";
            txtPedido.Text = "";
            txtQtdProd.Text = "";
            txtUni.Text = "";
            txtTotal.Text = "";
        }
        private void tblRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            txtCliente.Focus();
            Global salvar = new Global(int.Parse(txtQtdProd.Text),txtCliente.Text,float.Parse(txtUni.Text)
                ,float.Parse(txtTotal.Text=Convert.ToString(int.Parse(txtQtdProd.Text)*float.Parse(txtUni.Text))),int.Parse(txtPedido.Text));
            salvar.inserir();
            tblRegistros.DataSource = "";
            tblRegistros.DataSource = Global.Consultar();
            limpaTela();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            preencheTbl(Global.Consultar(txtPesquisa.Text));
        }

        private void tblRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = (int)tblRegistros["ID", e.ColumnIndex].Value;
            Global aux = new Global(id);
            txtPedido.Text = aux.ID.ToString();
            txtCliente.Text = aux.Cliente;
            txt
        }
    }
}
