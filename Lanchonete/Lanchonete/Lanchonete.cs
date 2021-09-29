using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete
{
    public abstract class Lanchonete
    {
        public string nome;

        public void pedirSanduiche()
        {
            Console.WriteLine("Pedindo seu sanduíche na " + this.nome);
            this.criarSanduiche();
        }
        public abstract void criarSanduiche();
    }
}
