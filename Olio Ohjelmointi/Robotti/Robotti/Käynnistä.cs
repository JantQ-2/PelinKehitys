using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotti
{
    public class Käynnistä : RobottiKäsky
    {
        public override void Suorita(Robotti robotti)
        {
            robotti.OnKäynnissä = true;
        }
    }
}
