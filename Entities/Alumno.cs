using WorkerKalumEnrollments.Interfaces;

namespace WorkerKalumEnrollments.Entities
{
    public class Alumno: Persona, IAsistencia
    {
        public string Carne {get;set;}
        public string Foto {get;set;}
        public string NivelAcademico {get;set;}

        public override bool NotificarPorEmail(string mensaje)
        {
            Console.WriteLine(mensaje);
            return true;
        }

        public void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia con carné {this.Carne}");
        }

    }
}