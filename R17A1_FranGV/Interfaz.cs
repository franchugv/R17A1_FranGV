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


        public static void MostrarDatos(string asignaturas, string[] calificaciones, float notas)
        {
            // RECURSOS

            int indice;

            // INICIALIZACION 

            indice = 0;

            // ENTRADA

            // PROCESO

            // VALIDACION PARA LA CALIFICACION
                if (notas <= 2.99) indice = 0;         
                if (notas >= 2.99) indice = 1;
                if (notas >= 4.99) indice = 2;
                if (notas >= 5.99) indice = 3;
                if (notas >= 7.49) indice = 4;
                if (notas >= 8.89) indice = 5;
                if (notas == 10) indice = 6;

            Console.WriteLine($"Asignatura:\t{asignaturas}");
            Console.WriteLine("Calificación\tNota\n");
            Console.WriteLine($"{calificaciones[indice]}\t{notas}");
           

            // SALIDA
        }    


    }
}
