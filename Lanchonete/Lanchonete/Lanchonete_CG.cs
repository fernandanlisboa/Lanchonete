using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete
{
    public class Lanchonete_CG : Lanchonete
    {
        public Lanchonete_CG()
        {
            this.nome = "Lanchonete CG";
        }
        public override void criarSanduiche()
        {
            Sanduiche_CG sanduiche = new Sanduiche_CG();

            sanduiche.apresentarSanduiche();
        }
    }
}
