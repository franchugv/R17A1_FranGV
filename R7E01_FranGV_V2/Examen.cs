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
                if (value.Length < CADENA_MAX) throw new Exception("Supera la cadena maxima") ;
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

                ActualizarCalificacion();
            }
        }

        public string Calificacion
        {
            get
            {
                return _calificacion;
            }

            set
            {
                // TODO: Evaluar si es necesaio comprobar si el atributo se ha actualizado
                _calificacion = value;
            }
        }

        // MÉTODOS PUBLICOS/PRIVADOS

        private void ActualizarCalificacion()
        {
            // CONSTANTES
            
            // RECURSOS LOCALES 
            string notaCualitativa = "";
            // PROCESO

            // SALIDA

            _calificacion = notaCualitativa;

        }

    }
}
