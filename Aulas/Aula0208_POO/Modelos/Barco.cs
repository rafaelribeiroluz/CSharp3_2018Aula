using System;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Barco: Acelerando...");
            Velocidade += 8;
        }

        public void Frenar()
        {
            Console.WriteLine("Barco: Frenando...");
            Velocidade -= 6;
        }
    }
}
