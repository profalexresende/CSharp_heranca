using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Moto: Veiculo
    {
        //Classe Derivada
        public bool PartidaEletrica { get; set; }

        public void AcionarPartidaEletrica()
        {
            if (PartidaEletrica)
            {
                Console.WriteLine("Acionando a partida elétrica da moto");
            }
            else
            {
                Console.WriteLine("A moto não possui partida elétrica");
            }
        }
    }

}
