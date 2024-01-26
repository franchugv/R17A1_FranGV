using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace R7E01_FranGV_V2
{
    public class Examen
    {

        // CONSTANTES PRIVADAS
        // Supuesto: He conseguido proporcionar un límite para la asignatura no establedido en el enunciaido
        private const int CADENA_MAX = 50;

        private const float NOTA_MAX = 10.0f;

        private const float NOTA_MIN = 0.0f;

        // MIEMBROS - RECURSOS PRIVADOS

        private string _asignatura;
        private float _nota;
        private string _calificacion;


        // CONSTRUCTORES
        /// <summary>
        /// 
        /// </summary>
        public Examen()
        {
            _asignatura = "Programación";
            _nota = 0.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="materia"></param>
        public Examen(string materia)
        {
            Asignatura = materia;
            _nota = 0.0f;           
        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="materia"></param>
      /// <param name="resultado"></param>
        public Examen(string materia, float resultado)
        {
            Asignatura = materia;
            Nota = resultado;
        }

        // PROPIEDADES SIEMPRE SIN PARENTESIS!!!
        /// <summary>
        /// Asignatura a evaluar
        /// </summary>
        
        public string Asignatura
        {
            get
            {
                // LECTURA


                // Comprobación: Evaluar si está establecido

                if (string.IsNullOrEmpty(_asignatura)) throw new Exception("Asignatura no establecida");// No nos permite leer el dato si no está establecido, como mecanismo de seguridad

                return _asignatura;
            }

            set
            {
                // ESCRITURA

                // Validación del dato a establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("Cadena vacía");
                if (value.Length > CADENA_MAX) throw new Exception("Supera la cadena maxima") ;
                _asignatura = value;
            }
        }

        /// <summary>
        /// Nota resultante de la asignatura
        /// </summary>
        
        public float Nota
        {
            get
            {
                return _nota;
            }

            set
            {
                // TODO: Validación de la nota
                if (value < NOTA_MIN) throw new Exception($"La nota {Nota} es menor al rango establecido ({NOTA_MIN} - {NOTA_MAX})");
                if (value < NOTA_MAX) throw new Exception($"La nota {Nota} es mayor al rango establecido ({NOTA_MIN} - {NOTA_MAX})");

                // Estableciento de la nota
                _nota = value;

                // Actualizar la calificación 

               // ActualizarCalificacion();
            }
        }

        public string Calificacion
        {
            get
            {
                // if (String.IsNullOrEmpty(_calificacion)) throw new Exception("No se a establecido el valor");

                return ActualizarCalificacion(); ;
            }


        }

    

        

        // MÉTODOS PUBLICOS/PRIVADOS


        

        private string ActualizarCalificacion()
        {
            // CONSTANTES

            const float LIMITE_NOTABLE = 7.5f;
            
            // RECURSOS LOCALES 
            string notaCualitativa = "";    // Calificacion a establecer en el miembro privado.

            int notaTruncada = 0;   // Nota truncada sin decimañles para establecer calificación
            // PROCESO
            notaTruncada = (int)Math.Truncate(Nota);    // Eliminación del miembro privado


            // Evaluación de la nota truncada para obtener la calificacion
            switch (notaTruncada)
            {
                case 0:
                case 1:
                case 2:
                    notaCualitativa = "Muy Deficiente";
                    break;
                case 3:
                case 4:
                    notaCualitativa = "Insuficiente";
                    break;
                case 5:
                case 6:
                    notaCualitativa = "Bien";
                    break;
                case 7:
                case 8:
                    if (Nota < LIMITE_NOTABLE) notaCualitativa = "Bien";
                    else notaCualitativa = "Notable";
                    break;
                case 9:
                    notaCualitativa = "Sobresaliente";
                    break;
                case 10:
                    notaCualitativa = "Matrícula de Honor";
                    break;
            }

            // SALIDA


            return notaCualitativa;

        }

    }
}
