
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

		private void tblRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnCadastrar_Click(object sender, EventArgs e)
		{

		}

		private void btnProcurar_Click(object sender, EventArgs e)
		{

		}

		private void tblRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Global aux = new Global(txtCliente.Text, txtProduto.Text, int.Parse(txtQtd.Text),
				float.Parse(txtUni.Text), float.Parse(txtTotal.Text = Convert.ToString(int.Parse
				(txtQtd.Text) * float.Parse(txtUni.Text))));
			aux.Inserir();
			tblRegistros.DataSource = "";
			tblRegistros.DataSource = Global.Consultar();
		}
	}
}
