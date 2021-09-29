using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete
{
    public class Lanchonete_RT : Lanchonete
    {       
        public Lanchonete_RT()
        {
            this.nome = "Lanchonete RT";
        }

        public override void criarSanduiche()
        {
            
            Sanduiche_RT sanduiche = new Sanduiche_RT();

            sanduiche.apresentarSanduiche();

        }
     }
}
