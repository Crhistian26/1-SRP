namespace Clases;

public class ServiceInformationPersona 
{
    /// <summary>
    /// Este metodo es responsable de mostrar la información de una persona.
    /// </summary>
    /// <param name="persona">La persona a la que describiremos</param>
    public void Descripcion(SRP_Persona persona)
    {
        // Simulación de mostrar información de la persona
        Console.WriteLine($"Nombre: {persona.nombre} \nEdad: {persona.edad} \nDirección: {persona.direccion} \nCorreo Electrónico: {persona.correoElectronico}");
    }
}
