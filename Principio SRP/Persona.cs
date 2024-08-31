

namespace Principio_SRP
{
    public class Persona
    {
        private int edad;
        private string nombre;
        private string direccion;
        private string correoElectronico;

        //Metodo que recibe por parametro los datos.
        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }
        //Metodo para imprimir los datos
        public void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Direccion: {direccion}");
            Console.WriteLine($"Correo: {correoElectronico}");

        }
        public String ObtenerCorreo()
        {
            return correoElectronico;

        }


    }
}
