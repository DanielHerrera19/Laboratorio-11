using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_11.Carpeta;

namespace Laboratorio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = InterfazConsola.MenuPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = InterfazConsola.RegistrarNota();
                        break;
                    case 2:
                        opcion = InterfazConsola.NotaMayor();
                        break;
                    case 3:
                        opcion = InterfazConsola.NotaMenor();
                        break;
                    case 4:
                        opcion = InterfazConsola.BuscarNota();
                        break;
                    case 5:
                        opcion = InterfazConsola.ModificarNota();
                        break;
                    case 6:
                        opcion = InterfazConsola.NotasRegistradas();
                        break;
                    case 0:
                    default:
                        opcion = InterfazConsola.MenuPrincipal();
                        break;
                }
            } while (opcion != 7);

            Console.ReadKey();
        }
    }
}