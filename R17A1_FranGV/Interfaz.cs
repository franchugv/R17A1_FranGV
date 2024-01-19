using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A1_FranGV
{
    public static class Interfaz
    {
        /// <summary>
        /// Metodo para la solicitud de canenas
        /// </summary>
        /// <param name="text">Texto que queremos en el mensaje de solicitud</param>
        /// <returns>Dato impreso por teclado</returns>
        public static string SolicitarCadena(string text)
        {
            // RECURSOS

            string dato;
            bool esValido;

            // INICIALIZACION

            dato = "";

            // ENTRADA

            do
            {
                // RESET
                esValido = true;

                // SOLICITUD DATO

                Console.Write($"Escriba su {text}: ");
                dato = Console.ReadLine();

                try
                {
                    Comprobaciones.ErroresCadenasINTERFAZ(dato);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return dato;
        }


        public static float SolicitarNota(string text)
        {
            // RECURSOS

            float dato;
            bool esValido;
            string aux;

            // INICIALIZACION

            dato = 0;
            aux = "";

            // ENTRADA

            do
            {
                // RESET
                esValido = true;

                // SOLICITUD DATO

                Console.Write($"Escriba su {text}: ");
                aux = Console.ReadLine();

                try
                {
                    dato = Comprobaciones.ErroresNumerosInterfaz(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return dato;
        }

        public static float SolicitarNota(string text, Examen OBJ)
        {
            // RECURSOS

            float dato;
            bool esValido;
            string aux;

            // INICIALIZACION

            dato = 0;
            aux = "";

            // ENTRADA

            do
            {
                // RESET
                esValido = true;

                // SOLICITUD DATO

                Console.Write($"Escriba su {text}: ");
                aux = Console.ReadLine();

                try
                {
                    OBJ.Nota = Comprobaciones.ErroresNumerosInterfaz(aux);
                }
                catch (Exception Error)
                {
                    esValido = false;
                    Console.WriteLine($"Error: {Error.Message}");
                    Console.WriteLine("Pulse ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (!esValido);

            // PROCESO


            // SALIDA METODO

            return OBJ.Nota;
        }


        public static void MostrarDatos(string asignaturas, string calificaciones, float notas)
        {
            // RECURSOS


            // INICIALIZACION 


            // ENTRADA

            // PROCESO

         

            Console.WriteLine($"Asignatura:\t{asignaturas}");
            Console.WriteLine("*************************************************");
            Console.WriteLine("CALIFICACION\tNOTA\n");
            Console.WriteLine($"{calificaciones}\t{notas}");
           

            // SALIDA
        }    


    }
}
