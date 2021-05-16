
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
		public Global(int id, string cliente, string pedido, int qtd, float preco, float total)
		{
			_Cliente = cliente;
			_Pedido = pedido;
			_Quantidade = qtd;
			_Preco = preco;
			_Total = total;
			_Id = id;
		}

		public Global( int id)
		{
			Global informacoes = listaGlobal.Find(listaDoCliente => listaDoCliente.ID == id);
			_Id = informacoes.ID;
			_Cliente = informacoes.CLIENTE;
			_Pedido = informacoes.PEDIDO;
			_Quantidade = informacoes.QUANTIDADE;
			_Preco = informacoes.PRECO;
			_Total = informacoes.TOTAL;			
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

		public static List<Global> Consultar(string clientePesquisar)
		{
			return listaGlobal.FindAll(lista => lista.CLIENTE.Contains(clientePesquisar));
			
		}

		public void Inserir()
		{
			MaxId++;
			_Id = MaxId;
			listaGlobal.Add(this);
		}
		public void Deletar()
		{

		}
		public void Alterar()
		{
			int i;
			i = listaGlobal.FindIndex(listGlobal => listGlobal.ID == _Id);
			listaGlobal[i].CLIENTE = _Cliente;
			listaGlobal[i].PEDIDO= _Pedido;
			listaGlobal[i].QUANTIDADE = _Quantidade;
			listaGlobal[i].PRECO= _Preco;
			listaGlobal[i].TOTAL = _Total;
		}

		#endregion
	}
}
