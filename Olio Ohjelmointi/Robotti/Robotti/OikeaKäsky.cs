using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotti
{
    public class OikeaKäsky : IRobottiKäsky
    {
        public void Suorita(Robotti robotti)
        {
            if (robotti.OnKäynnissä == true)
                robotti.X += 1;
        }
    }
}
