using System;

namespace cad_voo
{
    public class Cadastro
    {
        #region Variáveis

        private int? _Codigo = null;
        private DateTime _Data;
        private decimal _Custo = 0;
        private int _Distancia = 0;
        private char _Captura;
        private int _Nivel = 0;

        #endregion

        #region Get Set

        public int? codigo
        {
            get { return this._Codigo; }
            set { this._Codigo = value; }
        }

        public DateTime data_voo
        {
            get { return this._Data; }
            set { this._Data = value; }
        }

        public decimal custo
        {
            get { return this._Custo; }
            set { this._Custo = value; }
        }

        public int distancia
        {
            get { return this._Distancia; }
            set { this._Distancia = value; }
        }

        public char captura
        {
            get { return this._Captura; }
            set { this._Captura = value; }
        }

        public int nivel
        {
            get { return this._Nivel; }
            set { this._Nivel = value; }
        }

        #endregion

        #region Construtor

        public Cadastro()
        {
            
        }


        public Cadastro(int codigo, DateTime data, decimal custoFoguete, int dist_alcancada, char indicadorCapt, int nivel_dor)
        {
            _Codigo = codigo;
            _Data = data;
            _Custo = custoFoguete;
            _Distancia = dist_alcancada;
            _Captura = indicadorCapt;
            _Nivel = nivel_dor;
        }

        #endregion

    }
}
