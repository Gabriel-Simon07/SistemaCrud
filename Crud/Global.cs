
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
	public class Global
	{
		static List<Global> listaGlobal = new List<Global>();

		protected string _Cliente;
		protected string _Pedido;
		protected int _Quantidade;
		protected float _Preco;
		protected float _Total;
		protected int _Id;
		protected int MaxId = 0;

		#region Construtores
		public Global(string cliente, string pedido, int qtd, float preco, float total, int id)
		{
			_Cliente = cliente;
			_Pedido = pedido;
			_Quantidade = qtd;
			_Preco = preco;
			_Total = total;
			_Id = id;
		}
		public Global(string cliente, string pedido, int qtd, float preco, float total)
		{
			_Cliente = cliente;
			_Pedido = pedido;
			_Quantidade = qtd;
			_Preco = preco;
			_Total = total;
		}

		#endregion

		#region Propriedades
		public int QUANTIDADE
		{
			set { _Quantidade = value; }
			get { return _Quantidade; }
		}

		public int ID
		{
			set { _Id = value; }
			get { return _Id; }
		}
		public string CLIENTE
		{
			set { _Cliente = value; }
			get { return _Cliente; }
		}
		public string PEDIDO
		{
			set { _Pedido = value; }
			get { return _Pedido; }
		}
		public float PRECO
		{
			set { _Preco = value; }
			get { return _Preco; }
		}

		public float TOTAL
		{
			set { _Total = value; }
			get { return _Total; }
		}

		#endregion

		#region Metodos
		public static List<Global> Consultar()
		{
			return listaGlobal;
		}
		public void Inserir()
		{

		}
		public void Deletar()
		{

		}
		public void Alterar()
		{

		}

		#endregion
	}
}
