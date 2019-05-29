using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetaBic.Caneta
{
    class Caneta : Preco
    {
        private string modelo;
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return modelo;
        }



        public string cor { get; set; }
        public float ponta { get; set; }



        private bool carga;
        public void SetCarga(bool carga)
        {
            this.carga = carga;
        }
        public bool GetCarga()
        {
            return carga;
        }


        public bool tampada { get; set; }

        public bool TamparCaneta()
        {
            if (tampada == true)
            {
                Console.WriteLine("A caneta está tampada!");
            }
            else
            {
                Console.WriteLine("A caneta está destampada");
            }

            return tampada;
        }





    }
}

