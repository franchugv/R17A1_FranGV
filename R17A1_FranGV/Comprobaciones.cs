using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R17A1_FranGV
{
    public static class Comprobaciones
    {

       public static void ErroresCadenasINTERFAZ(string cadena)
        {


         

            // VALIDACION DE CADENA VACÍA

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
        }

        public static float ErroresNumerosInterfaz(string cadena)
        {

            // RECURSOS

            float numero;


            // VALIDACION DE CADENA VACÍA

            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            
            // CONVERSIÓN DE STRING A FLOAT

            numero = Convert.ToSingle(cadena);


            // SALIDA

            return numero;

        }



    }
}
