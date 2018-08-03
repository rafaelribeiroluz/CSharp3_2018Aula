﻿using System;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("Moto: Acelerando...");
            Velocidade += 10;
        }

        public void Frenar()
        {
            Console.WriteLine("Moto: Pisando...");
            Velocidade -= 7;
        }
    }
}
