namespace Clases;

/// <summary>
/// Esta clase representa una persona y contiene información básica como nombre, edad, dirección y correo electrónico.
/// </summary>
public class SRP_Persona
{
    public string? nombre;
    public int edad;
    public string? direccion;
    public string? correoElectronico;

    /// <summary>
    /// Constructor de la clase SRP_Persona.
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="edad"></param>
    /// <param name="direccion"></param>
    /// <param name="correoElectronico"></param>
    public SRP_Persona(string nombre, int edad, string direccion, string correoElectronico)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.correoElectronico = correoElectronico;
    }
}
