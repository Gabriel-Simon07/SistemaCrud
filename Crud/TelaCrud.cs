
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

		private void limpaInformacoes()
		{
			txtId.Text = "";
			txtCliente.Text = "";
			txtProduto.Text = "";
			txtQtd.Text = "";
			txtUni.Text = "";
			txtTotal.Text = "";
			txtPesquisa.Text = "";
		}



		private void tblRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{

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
			txtId.Text = aux.ID.ToString();
			txtCliente.Text = aux.CLIENTE.ToString();
			txtProduto.Text = aux.PEDIDO.ToString();
			txtTotal.Text = aux.TOTAL.ToString();
			txtUni.Text = aux.PRECO.ToString();
			txtQtd.Text = aux.QUANTIDADE.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtCliente.Focus();
			if (txtId.Text.Length == 0)
			{
				Global aux = new Global(txtCliente.Text, txtProduto.Text, int.Parse(txtQtd.Text),
					float.Parse(txtUni.Text), float.Parse(txtTotal.Text = Convert.ToString(int.Parse
					(txtQtd.Text) * float.Parse(txtUni.Text))));
				aux.Inserir();
			}
			else
			{
				Global aux = new Global(int.Parse(txtId.Text),txtCliente.Text, txtProduto.Text, int.Parse(txtQtd.Text),
					float.Parse(txtUni.Text), float.Parse(txtTotal.Text = Convert.ToString(int.Parse
					(txtQtd.Text) * float.Parse(txtUni.Text))));
				aux.Alterar();

			} 
			preencheTbl(Global.Consultar());
			limpaInformacoes();

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnAlterar_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limpaInformacoes();
		}
	}
}
