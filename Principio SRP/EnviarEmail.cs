

namespace Principio_SRP
{
    public class EnviarEmail
    {
        public void EnviarCorreo(string mensaje, string destino)
        {
            Console.WriteLine($"Enviando correo a: {destino}");
            Console.WriteLine($"Mensaje: {mensaje}");
        }
    }
}
