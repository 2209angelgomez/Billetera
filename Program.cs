using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    class Program
    {
        private static Billetera billetera;
        static void Main(string[] args)
        {
  

                switch (Billetera.Opcion)
                {
                    case 1:
                        Billetera.Ingresar();
                        Billetera.NotificarTransaccion();
                        Console.WriteLine("Oprime una tecla para terminar la acción");
                        Console.ReadLine();
                        if (true)
                        {
                            Billetera.menu();
                        }

                        break;
                    case 2:
                        Billetera.Gastar();
                        Billetera.NotificarTransaccion();
                        Console.WriteLine("Oprime una tecla para terminar la acción");
                        Console.ReadLine();
                        if (true)
                        {
                            Billetera.menu();
                        }


                        break;
                    case 3:
                        Billetera.Depositar();
                        Billetera.NotificarTransaccion();
                        Console.WriteLine("Oprime una tecla para terminar la acción");
                        Console.ReadLine();
                        if (true)
                        {
                            Billetera.menu();
                        }


                        break;
                    case 4:
                        Billetera.ImprimirDinero();
                        Billetera.NotificarTransaccion();
                        Console.WriteLine("Oprime una tecla para terminar la acción");
                        Console.ReadLine();
                        if (true)
                        {
                            Billetera.menu();
                        }


                        break;
                    case 5:
                        Billetera.TotalAhorrado();
                        Billetera.NotificarTransaccion();
                        Console.WriteLine("Oprime una tecla para terminar la acción");
                        Console.ReadLine();
                        if (true)
                        {
                            Billetera.menu();
                        }


                        break;
                    case 6:
                        Console.WriteLine("Su sesion ha finalizado");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        Billetera.menu();
                        break;
                }
        }
    }
}