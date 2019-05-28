using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetera
{
    class Billetera
    {
        double inicial;
        int gasto;
        int saldo;
        double banco;
        double ahorro10;
        int opcion;

        public static double Inicial {get; set; }
   
        public static int Gasto { get; set; }

        public static int Saldo { get; set; }
        
        public static double Banco { get; set; }

        public static double Ahorro { get; set; }

        public static int Opcion { get; set; }
        public static string Menu{ get; set; }

        public Billetera(double inicial, int gasto,int saldo, double banco, double ahorro,int opcion, string menu)
        {
            Inicial = inicial;
            Gasto = gasto;
            Saldo = saldo;
            Banco = banco;
            Ahorro = ahorro;
            Opcion = opcion;
            Menu = menu;
        }

        public static List<Billetera> Usuario = new List<Billetera>();

        public static void Ingresar()
        {
            Console.WriteLine("Ingrese su saldo inicial");
            Inicial = int.Parse(Console.ReadLine());
        }
        public static void Gastar()
        {
            if (Inicial > 0)
            {
                Console.WriteLine("Ingrese la cantidad de dinero a gastar: ");
                Gasto = int.Parse(Console.ReadLine());
                Inicial = Inicial - Gasto;
                Ahorro = Gasto * 0.10;
                Inicial = Inicial - Ahorro;
                Banco = Banco + Ahorro;
            }
            else
            {
                Console.WriteLine("Actualmente no hay dinero en la billetera");
            }


        }
        public static void Depositar()
        {
            if (Inicial > 0)
            {
                Banco = Banco + Inicial;
                Inicial = 0;

            }

        }
        public static void ImprimirDinero()
        {
            Console.WriteLine("Dinero actualmente en la Billetera: ");
            Console.WriteLine(Inicial);
        }
        public static void TotalAhorrado()
        {
            Console.WriteLine("El total Ahorrado en el Banco es: ");
            Console.WriteLine("$ " + Banco + " COP");
        }
        public static void NotificarTransaccion()
        {
            if (Opcion == 1)
            {
                Console.WriteLine("Ha ingresado un valor inicial de $ " + Inicial);
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("Ha realizado un gasto de: $" + Gasto);
            }
            else if (Opcion == 3)
            {
                Console.WriteLine("Ha depositado su dinero a la billetera");
            }
            else if (Opcion == 4)
            {
                Console.WriteLine("Se realizó una consulta en la billetera");
            }
            else if (Opcion == 5)
            {
                Console.WriteLine("Se realizó una consulta en el banco");
            }
        }
        public static void menu()
        {
            Console.WriteLine("|-----------------------MENÚ-----------------------|");
            Console.WriteLine("|  [1] Ingresar Dinero Inicial.                    |");
            Console.WriteLine("|  [2] Ingresar un Gasto.                          |");
            Console.WriteLine("|  [3] Depositar toda la billetera en el Banco.    |");
            Console.WriteLine("|  [4] Consultar Saldo de la Billetera.            |");
            Console.WriteLine("|  [5] Consultar Dinero total Ahorrado en el Banco.|");
            Console.WriteLine("|  [6] Salir                                       |");
            Console.WriteLine("|---------------SELECCIONE UNA OPCIÓN--------------|");
            Opcion = int.Parse(Console.ReadLine());
        }


      
    }
}

