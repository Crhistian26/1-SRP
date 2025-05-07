namespace Clases;


//Esta clase violenta el principio de responsabilidad única (SRP) porque tiene múltiples responsabilidades: almacenar datos de una persona y enviar correos electrónicos.
//Esto hace que la clase sea más difícil de mantener y entender. Para cumplir con el SRP, deberíamos separar las responsabilidades en diferentes clases.
public class Persona
{
    public string nombre {get; set; }
    public int edad {get; set; }
    public string? direccion {get; set; }
    public string? correoElectronico {get; set; }

    public Persona(string nombre, int edad, string direccion, string correoElectronico)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.correoElectronico = correoElectronico;
    }

   
    public void EnviarCorreo(string mensaje)
    {
        //Correo electrónico simulado
    }
}
