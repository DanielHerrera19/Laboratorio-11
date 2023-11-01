using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11.Carpeta
{
    public class InterfazConsola
    {
        public static float[] notas = new float[30];
        public static int contador = 0;

        public static int MenuPrincipal()
        {
            string texto = "================================" +
            "\nCasos con arreglos" +
            "\n================================" +
            "\n1: Registrar notas" +
            "\n2: Hallar la nota mayor" +
            "\n3: Hallar la nota menor" +
            "\n4: Encontrar una nota" +
            "\n5: Modificar una nota" +
            "\n6: Ver notas registradas" +
            "\n7: Salir" +
            "\n================================";
            Console.Write(texto);
            return Calculos.getEntero("\nIngrese una opción: ", texto);
        }

        public static int RegistrarNota()
        {
            string texto = "================================\n" +
                    "Registrar una nota\n" +
                    "================================\n";
            Console.Write(texto);
            float Nota = Calculos.getDecimal("Ingresa la nota: ");

            if (contador == 50)
            {
                Console.WriteLine("LA LISTA YA ESTÁ LLENA");
            }
            notas[contador] = Nota;
            contador++;

            string texto2 = "================================\n" +
                    "1: Registrar otra nota\n" +
                    "2: Regresar \n" +
                    "================================\n";

            Console.Write(texto2);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int NotaMayor()
        {
            string texto = "================================\n" +
                "La nota mayor\n" +
                "================================\n";
            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float mayor = notas[0];
                for (int i = 0; i < contador; i++)
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                    }
                Console.WriteLine("La nota mayor es: [" + mayor + "]");
            }

            string texto2 = "================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int NotaMenor()
        {
            string texto = "================================\n" +
                "La nota menor\n" +
                "================================\n";
            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float menor = notas[0];
                for (int i = 0; i < contador; i++)
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                    }
                Console.WriteLine("La nota menor es: [" + menor + "]");
            }

            string texto2 = "================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int BuscarNota()
        {

            string texto = "================================\n" +
                "Buscar nota\n" +
                "================================\n";
            Console.Write(texto);
            float valorBuscar = Calculos.getDecimal("Ingrese la nota a buscar: ");
            int posicionEncontrada = -1;
            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                }
            }
            if (posicionEncontrada == -1)
            {
                Console.WriteLine("No se ha encontrado la nota");
            }
            else
            {
                string texto2 = "La nota está en la posición: " + posicionEncontrada + "\n";
                Console.Write(texto2);

            }

            string texto3 = "================================\n" +
                "1: Regresar\n";

            Console.Write(texto3);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int ModificarNota()
        {

            string texto = "================================\n" +
                "Modificar nota\n" +
                "================================\n";
            Console.Write(texto);

            Console.Write("Ingrese la posición: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion >= 0 && posicion < notas.Length)
            {
                Console.Write("Ingrese el nuevo valor: ");
                int nuevoValor = int.Parse(Console.ReadLine());
                notas[posicion] = nuevoValor;
            }
            else
            {
                Console.WriteLine("La posición ingresada no es válida.");
            }


            string texto2 = "================================\n" +
               "1: Regresar\n";

            Console.Write(texto2);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int NotasRegistradas()
        {
            string texto = "================================\n" +
                "Notas Registradas\n" +
                "================================\n" +
                "Notas actuales:\n\n";
            Console.Write(texto);

            if (contador == 0)
            {
                Console.WriteLine("No extisten notas");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.Write(notas[i] + " - ");

            }
            Console.WriteLine("\n\nSiguiente posición será: " + contador);


            string texto2 = "\n================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = Calculos.getEntero("Ingrese una opción: ", texto);
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
