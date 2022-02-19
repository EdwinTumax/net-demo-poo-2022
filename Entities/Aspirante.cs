using Microsoft.VisualBasic;
using WorkerKalumEnrollments.Interfaces;

namespace WorkerKalumEnrollments.Entities
{
    public class Aspirante: Persona, IAsistencia
    {
        public string NoExpediente {get;set;}  
        public string CUI {get;set;}
        public string Estatus {get;set;}
        public DateTime FechaExamenAdmision {get;set;}

        public override bool NotificarPorEmail(string mensaje)
        {
            Console.WriteLine(mensaje);
            return true;
        }

        public void TomarAsistencia()
        {
            Console.WriteLine($"Tomando asistencia al examen {this.NoExpediente}");
        }
    }
}