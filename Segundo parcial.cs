using System;

namespace Sistema_de_votaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sistema de Votaciones.
            Console.WriteLine("-------------SISTEMA de Votaciones-----------------");
            Console.WriteLine();
            int voto1 = 0;
            int voto2 = 0;
            int voto3 = 0;
            int voto4 = 0;

            int aleatorio;
            string[] candidatos = { "Luis Abinader", "Gonzalo Castillo", "Leonel Fernandez", "Guillermo Moreno" };
            string[] partidos = { "Partido Revolucionario Moderno (PRM)", "Partido de la Liberacion Dominicana (PLD)", "Fuerza del Pueblo (FP)", "Alianza Pais (AP)" };
            int[] fundacion = {1940, 1970, 2020, 1993};

            for(int i = 0; i <=3; i++)
            {
                Console.WriteLine("-Partido politico: {0}", partidos[i]);
                Console.WriteLine("Año de fundacion: {0}", fundacion[i]);
                Console.WriteLine("Candidato: {0}", candidatos[i]);
                Console.WriteLine("Aspirante a: Presidente");
                Console.WriteLine();
            }
            Console.Write("Presione ENTER para ver los resultados de las votaciones ");
            var a = Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < 1000; i++)
            {
                Random aleatory = new Random();
                aleatorio = aleatory.Next(1, 5);

                if (aleatorio == 1)
                {
                    voto1++;
                }

                if (aleatorio == 2)
                {
                    voto2++;
                }
                if (aleatorio == 3)
                {
                    voto3++;
                }
                if (aleatorio == 4)
                {
                    voto4++;
                }

            }

            double resultado = voto1 + voto2 + voto3 + voto4;

            double Abinader = (voto1 / resultado) * 100;
            double Castillo = (voto2 / resultado) * 100;
            double Fernandez = (voto3 / resultado) * 100;
            double Guillermo = (voto4 / resultado) * 100;

            Console.WriteLine(candidatos[0] + " obtuvo " + voto1 + " Votos. Con un porcentaje de un " + Abinader + "%");
            Console.WriteLine();
            Console.WriteLine(candidatos[1] + " obtuvo " + voto2 + " Votos. Con un porcentaje de un " + Castillo + "%");
            Console.WriteLine();
            Console.WriteLine(candidatos[2] + " obtuvo " + voto3 + " Votos. Con un porcentaje de un " + Fernandez + "%");
            Console.WriteLine();
            Console.WriteLine(candidatos[3] + " obtuvo " + voto4 + " Votos. Con un porcentaje de un " + Guillermo + "%");
            Console.WriteLine();

            if (voto1 > voto2 && voto1 > voto3 && voto1 > voto4)
            {
                Console.WriteLine("El ganador a la presidencia es: {0}.", candidatos[0]);
            }
            else if(voto2 > voto1 && voto2 > voto3 && voto2 > voto4)
            {
                Console.WriteLine("El ganador a la presidencia es: {0}.", candidatos[1]);
            }
            else if(voto3 > voto1 && voto3 > voto2 && voto3 > voto4)
            {
                Console.WriteLine("El ganador a la presidencia es: {0}.", candidatos[2]);
            }
          else if (voto4 > voto1 && voto4 > voto2 && voto4 > voto3)
            {
                Console.WriteLine("El ganador a la presidencia es: {0}.", candidatos[3]);
            }
        
        }
            
           
        
    }
}
