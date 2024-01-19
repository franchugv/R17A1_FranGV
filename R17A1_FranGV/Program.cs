namespace R17A1_FranGV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CONSTANTES


            // RECURSOS

            Examen boletinAlumno;

            // INICIALIZACION

            boletinAlumno = new Examen();

            // ENTRADA

            boletinAlumno.Asignatura = Interfaz.SolicitarCadena("asignatura");

            boletinAlumno.Nota = Interfaz.SolicitarNota("nota", boletinAlumno);

            // PROCESO


            // SALIDA

            Interfaz.MostrarDatos(boletinAlumno.Asignatura, boletinAlumno.Calificacion, boletinAlumno.Nota);

        }
    }
}