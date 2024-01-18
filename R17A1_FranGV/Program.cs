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

            boletinAlumno.asignatura = Interfaz.SolicitarCadena("asignatura");

            boletinAlumno.Nota = Interfaz.SolicitarNota("nota", boletinAlumno);

            // PROCESO


            // SALIDA

            Interfaz.MostrarDatos(boletinAlumno.asignatura, boletinAlumno.Calificacion, boletinAlumno.Nota);

        }
    }
}