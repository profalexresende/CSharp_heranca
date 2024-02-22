using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Carro: Veiculo
    {
        //Classe Derivada
        public int Portas { get; set; }
        public void AbrirPortas()
        {
            Console.WriteLine($"Abrindo as {Portas} portas do carro");
        }
    }
}
