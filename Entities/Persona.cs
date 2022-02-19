using WorkerKalumEnrollments.Interfaces;

namespace WorkerKalumEnrollments.Entities
{
    public abstract class Persona
    {
        public string Apellidos {get;set;}
        public string Nombres {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string Email {get;set;}
        public abstract bool NotificarPorEmail(string mensaje);

        public bool NotificarDeuda()
        {
            Console.WriteLine("Se le recuerda que ustede tiene un deuda pendiente de algún pago");
            return true;
        }

    }
}