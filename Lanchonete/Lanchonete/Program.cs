using System;
using System.Collections.Generic;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanchonete_CG cg = new Lanchonete_CG();
            Lanchonete_JP jp = new Lanchonete_JP();
            Lanchonete_RT rt = new Lanchonete_RT();

            List<Lanchonete> lanchonetes = new List<Lanchonete>();
            lanchonetes.Add(rt);
            lanchonetes.Add(jp);
            lanchonetes.Add(cg);

            foreach(Lanchonete l in lanchonetes)
            {
                l.pedirSanduiche();
                Console.WriteLine("=============================================================================");
            }
        }
    }
}
