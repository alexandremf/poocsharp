using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetaBic.Caneta
{
    class Preco
    {
        private double valor;
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return this.valor;
        }


        private string validade;
        public void SetValidade(string validade)
        {
            this.validade = validade;
        }
        public string GetValidade()
        {
            return this.validade;
        }

    }
}
