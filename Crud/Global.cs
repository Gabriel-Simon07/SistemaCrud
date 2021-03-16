
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
        #endregion

        #region
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
    }
}
