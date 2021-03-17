
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    public class Global
    {
        static List<Global> listaGlobal = new List<Global>();
        protected string _Cliente;
        protected int _Quantidade;
        protected float _PrecoUNI;
        protected float _totalValor;
        protected int _pedido;
        protected string _Produto;
        static int _idMax;
        protected int _id;

        #region Construtores
        public Global()
        {
            _Cliente = "";
            _Quantidade = 0;
            _PrecoUNI = 0;
            _totalValor = 0;
            _pedido = 0;
            _Produto = "";
            _idMax = 0;
            _id = 0;
        }
        public Global(string cliente,  float preçoUNI, float valorTotal, int pedido, string produto, int idMax, int id)
        {
            _Cliente = "";
            _Quantidade = 0;
            _PrecoUNI = 0;
            _totalValor = 0;
            _pedido = 0;
            _Produto = "";
            _idMax = 0;
            
        }
        public Global(string cliente, int quantidade, float preçoUNI, float valorTotal, int pedido, string produto, int idMax, int id)
        {
            _Cliente = "";
            _Quantidade = 0;
            _PrecoUNI = 0;
            _totalValor = 0;
            _pedido = 0;
            _Produto = "";
            _idMax = 0;
            _id = 0;
        }
        #endregion

        #region Propriedades
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Cliente
        {
            set { _Cliente= value; }
            get { return _Cliente; }
        }
        public int Quantidade
        {
            set { _Quantidade= value; }
            get { return _Quantidade; }
        }
        public float PreçoUnitario
        {
            set { _PrecoUNI= value; }
            get { return _PrecoUNI; }
        }
        public float PrecoTotal
        {
            set { _totalValor= value; }
            get { return _totalValor; }
        }
        public int Pedido
        {
            set { _pedido= value; }
            get { return _pedido; }
        }
        public string Produto
        {
            set { _Produto= value; }
            get { return _Produto; }
        }
        public int IdMax
        {
            set { _idMax= value; }
            get { return _idMax; }
        }

        #endregion
    }
}
