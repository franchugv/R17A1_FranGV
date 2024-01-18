using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A1_FranGV
{
    public class Examen
    {

        // CONSTANTES PRIVADAS

        private const byte NOTA_MAX = 10;
        private const byte NOTA_MIN = 0;


        // MEIMBROS DE LA CLASE
        // valores tipo cadena
        public string asignatura;

        // valores tipo numericos
        private float _nota;

        private string[] _calificacion;     // 1 a 7.

        // PROPIEDADES (Las propiededas siempren empiezan por mayuscula, sin parentesis)

        /// <summary>
        /// Propiedad LECTURA ESCRITURA PARA NOTA
        /// </summary>
        public float Nota
        {
            get // Lectura
            {
               

                return _nota;
            }

            set
            {
                // CONTROL NOTA MAXIMA Y MÍNIMA
                if (value > NOTA_MAX) throw new Exception($"la nota supera el valor maximo ({NOTA_MIN} - {NOTA_MAX})");
                if (value < NOTA_MIN) throw new Exception($"la nota es menor al valor mínimo ({NOTA_MIN} - {NOTA_MAX})");
                _nota = value;
            }
        } 
        /// <summary>
        /// Propiedad Solo lectura Calificacion
        /// </summary>
        public string[] Calificacion
        {
            get
            {
                AsignacionTextoCalificacion();

                return _calificacion;
            }

           
        }


        // MÉTODOS PRIVADOS
        /// <summary>
        /// Asignación de calificaciones para el ARRAY 
        /// </summary>
        private void AsignacionTextoCalificacion()
        {
            _calificacion = new string[] { "Muy Deficiente", "Insuficiente", "Suficiente", "Bien", "Notable", "Sobresaliente", "Matrícula de Honor" };
        }

      
    }
}
