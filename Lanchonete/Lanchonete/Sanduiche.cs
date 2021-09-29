using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete
{
    public abstract class Sanduiche
    {
        public string Pao;
        public string Queijo;
        public string Presunto;
        public string Salada;

        public void apresentarSanduiche()
        {
            Console.WriteLine("Sanduíche de Pão " + this.Pao);
            Console.WriteLine("Com queijo " + this.Queijo + ", Presunto " + this.Presunto + " e Salada " + this.Salada);
        }
        
    }
}
