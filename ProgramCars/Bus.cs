using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCars
{
    public class Bus //dodać jescze modyfikator public by była dostępna dla innego projektu
    {

        internal string Brand; //modyfikatorów internal nie można wykorzystać w innym projekcie od tak, chyba że addReferences->projects->i utworzyć most pomiędzy projektami
    }
}
