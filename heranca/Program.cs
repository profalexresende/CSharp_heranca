// See https://aka.ms/new-console-template for more information
// Criando uma instância da classe derivada (Carro)
using heranca;

Carro meuCarro = new Carro
{
    Marca = "Toyota",
    Modelo = "Corolla",
    Portas = 4
};

meuCarro.Dirigir();    // Método da classe base
meuCarro.AbrirPortas();  // Método da classe derivada

// Criando uma instância da outra classe derivada (Moto)
Moto minhaMoto = new Moto
{
    Marca = "Honda",
    Modelo = "CB500",
    PartidaEletrica = true
};

minhaMoto.Dirigir();  // Método da classe base
minhaMoto.AcionarPartidaEletrica();  // Método da classe derivada
  
