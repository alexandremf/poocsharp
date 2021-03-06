﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetaBic.Caneta
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta = new Caneta();

            caneta.SetModelo("BIC");
            Console.WriteLine("Modelo da Caneta " + caneta.GetModelo());

            caneta.tampada = true;
            Console.WriteLine("A Caneta está tampada? " + caneta.tampada);

            caneta.cor = "Azul";
            Console.WriteLine("Cor da Caneta: " + caneta.cor);

            caneta.SetCarga(true);
            Console.WriteLine("Carga da Caneta " + caneta.GetCarga());

            Preco preco = new Preco();

            preco.SetValor(2.50);
            Console.WriteLine("O valor da caneta é " + preco.GetValor());

            preco.SetValidade("20/12/2019");
            Console.WriteLine("A validade da caneta é " + preco.GetValidade());
            



            Console.ReadLine();

           
        }
    }
}
