using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Veiculo
    {
        //SUPERCLASSE
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public void Dirigir()
        {
            Console.WriteLine($"Dirigindo um {Marca} {Modelo}");
        }

    }
}
