using System;

namespace segundo_corte
{
    class Program
    {
        static void Main(string[] args)
            
            //Edad y Estatura de personas que desean entrar a un parque
        {
            string cadena = "";
            int Edad = 0;
            double Altura = 1.7;

            Console.WriteLine("Buen dia, bienvenido al parque Snowland, por favor ingrese su edad");
            cadena = Console.ReadLine();
            Edad = Convert.ToInt32(cadena);


            if(Edad<=18)
            {
                Console.WriteLine("Disculpe, usted ha superado la edad para ingresar al parque Snowland");

            }
            
            else
        
            {
                Console.WriteLine("Bienvenido a Snowland");
                Console.WriteLine("¿Cual es su altura?, en metros");
                cadena = Console.ReadLine();
                Altura = Convert.ToDouble(cadena);

                if(Altura>=1.6)
                {
                    Console.WriteLine("Puedes ingresar a los gokarts, pista de patinaje, montaña rusa y rueda de la fortuna");
                }
                
                else
                {
                    Console.WriteLine("Puedes ingresar a la pista de hielo, montaña rusa y rueda de la fortuna. No tienes permitido el acceso a los gokarts ya que superas la altura minima");
                }
            }

            Console.ReadLine();

        }
    }
}
