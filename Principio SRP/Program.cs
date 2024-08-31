using Principio_SRP;

//La clase anterior violaba el principio SRP porque realizaba mas de una tarea, entonces lo que hice fue crear otra clase relacionada para que realice el metodo de enviar el correo electronico

Persona persona = new Persona("Wilmer", 19, "Calle Joaquin 09", "Wilmer@Pendejo.com");
persona.ImprimirDatos();

EnviarEmail enviarEmail = new EnviarEmail();
enviarEmail.EnviarCorreo(persona.ObtenerCorreo(), "Wilmer, este es un mensaje de confirmacion.");
