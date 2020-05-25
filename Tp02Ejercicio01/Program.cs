using System;

namespace Tp02Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01 Práctico 02";
            int radio;
            double area, volumen;
            Console.Write("Ingrese el valor del radio:");
            if (int.TryParse(Console.ReadLine(),out radio))
            {
                area = CalcularArea(radio);
                volumen = CalcularVolumen(radio);
                Console.WriteLine($"Área....:{area:N2}");
                Console.WriteLine($"Volumen.:{volumen:N2}");

                Console.Write("Ingrese la coordenada X del punto:");
                if (int.TryParse(Console.ReadLine(), out int x1))
                {
                    if (int.TryParse(Console.ReadLine(),out int y1))
                    {
                        if (int.TryParse(Console.ReadLine(),out int z1))
                        {
                            double distancia = CalcularDistancia(x1, y1, z1);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Coordenada X no válida");
                }
            }
            Console.ReadLine();
        }

        private static double CalcularDistancia(int x1, int y1, int z1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2));
        }

        private static double CalcularVolumen(int radio)
        {
            return 4 / 3 * Math.PI * Math.Pow(radio, 3);
        }

        private static double CalcularArea(int radio)
        {
            return 4 * Math.PI * Math.Pow(radio, 2);
        }
    }
}
