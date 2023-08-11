using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_31_07_2023
{
    public class Venda
    {
        private int _qtde;

        internal int Qtde
        {
            get => _qtde;
            set => _qtde = value;
        }

        internal double Valor
        {
            get => _valor;
            set => _valor = value;
        }

        private double _valor;

        public Venda(int qtde, double valor)
        {
            _qtde = qtde;
            _valor = valor;
        }
        

        public Venda() : this(0, 0.0)
        {
        }

        public double ValorMedio()
        {

            return this._valor/this._qtde;
        }
        
        public override string ToString()
        {
            return $"{nameof(Qtde)}: {_qtde}, {nameof(Valor)}: {_valor}";
        }

    }
}
