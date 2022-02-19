using WorkerKalumEnrollments.Entities;
public class Sistema
{   
    public static void Main(String[] args)
    {   
        //List<Alumno> listaAlumnos = new List<Alumno>();
        //List<Aspirante> listaAspirante = new List<Aspirante>();

        List<Persona> listaPersonas = new List<Persona>();

        Persona alumno2 = new Alumno();
        ((Alumno)alumno2).Carne = "2022002";
        alumno2.Apellidos = "Mancilla Perez";
        alumno2.Nombres = "Maria Eunice";
        alumno2.Direccion = "Guatemala, Guatemala";
        alumno2.Telefono = "45789634";
        alumno2.Email = "mmancilla@gmail.com";
        ((Alumno)alumno2).Foto= "Default.png";
        ((Alumno)alumno2).NivelAcademico = "Nivel Diversificado";
        alumno2.NotificarPorEmail("El listado de su nota de ingles fue de 100 puntos");
        alumno2.NotificarDeuda();



        Aspirante aspirante1 = new Aspirante();
        aspirante1.NoExpediente = "EXP-2022001";
        aspirante1.CUI = "24840124789";
        aspirante1.Apellidos = "Martinez Muñoz";
        aspirante1.Nombres = "Juan Alberto";
        aspirante1.Direccion = "Guatemala, Guatemala";
        aspirante1.Telefono = "2471529";
        aspirante1.Email = "jmartinez@gmail.com";
        aspirante1.Estatus = "No asignado";
        aspirante1.FechaExamenAdmision = DateTime.Now;        
        aspirante1.NotificarPorEmail("Su examen de admision fue exitoso");
        aspirante1.NotificarDeuda();

        Aspirante aspirante2 = new Aspirante();
        aspirante2.NoExpediente = "EXP-2022002";
        aspirante2.CUI = "24840124787";
        aspirante2.Apellidos = "Perez Mancilla";
        aspirante2.Nombres = "Maria Alejandra";
        aspirante2.Direccion = "Guatemala, Guatemala";
        aspirante2.Telefono = "2471527";
        aspirante2.Email = "mperez@gmail.com";
        aspirante2.Estatus = "No asignado";
        aspirante2.FechaExamenAdmision = DateTime.Now;        

        Alumno alumno1 = new Alumno();
        alumno1.Carne = "2022001";
        alumno1.Apellidos = "Lemus Carpio";
        alumno1.Nombres = "Juan Luis";
        alumno1.Direccion = "Guatemala, Guatemala";
        alumno1.Telefono = "45789634";
        alumno1.Email = "jlemus@gmail.com";
        alumno1.Foto= "Default.png";
        alumno1.NivelAcademico = "Nivel Diversificado";
        alumno1.NotificarPorEmail("El listado de su nota de ingles fue de 100 puntos");
        alumno1.NotificarDeuda();
        //listaAlumnos.Add(alumno1);

        Aspirante aspirante3 = new Aspirante();
        aspirante3.NoExpediente = "EXP-2022003";
        aspirante3.CUI = "24840124781";
        aspirante3.Apellidos = "Barrios Martinez";
        aspirante3.Nombres = "Raul Antonio";
        aspirante3.Direccion = "Guatemala, Guatemala";
        aspirante3.Telefono = "2471574";
        aspirante3.Email = "rbarrios@gmail.com";
        aspirante3.Estatus = "No asignado";
        aspirante3.FechaExamenAdmision = DateTime.Now;        

        //listaAspirante.Add(aspirante1);
        //listaAspirante.Add(aspirante2);
        //listaAspirante.Add(aspirante3);
    

        listaPersonas.Add(alumno1);
        listaPersonas.Add(alumno2);
        listaPersonas.Add(aspirante1);
        listaPersonas.Add(aspirante2);
        listaPersonas.Add(aspirante3);




        //ImprimirAlumnos(listaAlumnos);
        //ImprimirAspirante(listaAspirante);
        ImprimirInformacionGeneral(listaPersonas);

    }

    /*static void ImprimirAlumnos(List<Alumno> lista)
    {
        Console.WriteLine("Lista de alumnos");
        foreach(Alumno elemento in lista)
        {
            Console.WriteLine($"Datos: {elemento.Carne} {elemento.Apellidos} {elemento.Nombres}");
        }
    }

    static void ImprimirAspirante(List<Aspirante> lista)
    {
        Console.WriteLine("Lista de aspirantes");
        foreach(Aspirante aspirante in lista)
        {
            Console.WriteLine($"Datos: {aspirante.NoExpediente} {aspirante.Apellidos} {aspirante.Nombres}");
        }
    }*/

    static void ImprimirInformacionGeneral(List<Persona> personas)
    {
        Console.WriteLine($"Información General");
        foreach (Persona elemento in personas)
        {
            if(elemento is Alumno)
            {
                Console.WriteLine($"Datos: {((Alumno)elemento).Carne} {elemento.Apellidos} {elemento.Nombres}");
                Console.WriteLine("Registro de asistencia:");
                ((Alumno)elemento).TomarAsistencia();                
            }
            else if(elemento is Aspirante)
            {
                Console.WriteLine($"Datos: {((Aspirante)elemento).NoExpediente} {elemento.Apellidos} {elemento.Nombres}");
                Console.WriteLine("Registro de asistencia:");
                ((Aspirante)elemento).TomarAsistencia();                
            }           
        }
    }

}