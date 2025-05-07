namespace Clases;

public class ServiceEmailPersona
{
    /// <summary>
    /// Este metodo es responsable de enviar correos electrónicos a las personas.
    /// </summary>
    /// <param name="Escritor">La persona que enviara el EMAIL</param>
    /// <param name="Remitente">La persona que lo recibira</param>
    /// <param name="mensaje">El mensaje que se enviara</param>
    public void EnviarCorreo(SRP_Persona Escritor, SRP_Persona Remitente, string mensaje)
    {
        // Simulación de envío de correo electrónico
        Console.WriteLine($"El escritor {Escritor.correoElectronico} le envion un correo a {Remitente.correoElectronico} con el mensaje: {mensaje}");
    }
}
