namespace Practica_SRP;
using System;
using Clases;

class Program
{
    static void Main(string[] args)
    {
        SRP_Persona Juan = new SRP_Persona("Juan",25,"Los mina","Juan@gmail.com"); 
        SRP_Persona Pepe = new SRP_Persona("Pepe",22,"Los alcarrizos","Pepe@gmail.com"); 
        ServiceEmailPersona serviceEmailPersona = new ServiceEmailPersona();
        ServiceInformationPersona serviceInformationPersona = new ServiceInformationPersona();

        serviceEmailPersona.EnviarCorreo(Juan,Pepe,"Hola pepe un placer tenerte por aca");

        serviceInformationPersona.Descripcion(Pepe);
        serviceInformationPersona.Descripcion(Juan);
    }
}
