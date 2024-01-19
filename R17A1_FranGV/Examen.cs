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
        private string _asignatura;

        // valores tipo numericos
        private float _nota;

        private string _calificacion;

        // PROPIEDADES (Las propiededas siempren empiezan por mayuscula, sin parentesis)


        public string Asignatura
        {
            get
            {
                return _asignatura;
            }
            set
            {
                _asignatura = value;
            }
        }

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
        public string Calificacion
        {
            get
            {

                ProcesarCalificacion();

                return _calificacion;
            }

           
        }


        // MÉTODOS PRIVADOS

      

        private void ProcesarCalificacion()
        {

            // RECURSOS


               // VALIDACION PARA LA CALIFICACION
                if (Nota <= 2.99) _calificacion = "Muy Deficiente";      // "0 Muy Deficiente", "1 Insuficiente", "2 Suficiente", "3 Bien", "4 Notable", "5 Sobresaliente", "6 Matrícula de Honor"         
                if (Nota > 2.99) _calificacion = "Insuficiente";
                if (Nota > 4.99) _calificacion = "Suficiente";
                if (Nota > 5.99) _calificacion = "Bien";
                if (Nota > 7.49) _calificacion = "Notable";
                if (Nota > 8.89) _calificacion = "Sobresaliente";
                if (Nota == 10) _calificacion = "Matrícula de Honor";






        }
      
    }
}
