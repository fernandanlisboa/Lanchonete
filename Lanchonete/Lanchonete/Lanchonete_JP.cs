using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete
{
    public class Lanchonete_JP : Lanchonete
    {
        public Lanchonete_JP()
        {
            this.nome = "Lanchonete JP";
        }
        public override void criarSanduiche()
        {
            Sanduiche_JP sanduiche = new Sanduiche_JP();

            sanduiche.apresentarSanduiche();
        }
    }
}
