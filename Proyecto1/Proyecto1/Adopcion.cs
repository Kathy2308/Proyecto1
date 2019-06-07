using System;

namespace Proyecto1
{
    class Adopcion
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Persona per = new Persona();

            Console.WriteLine("°°°°°Centro de Adopción°°°°°");
            Console.WriteLine("Por favor ingresar su nombre:");
            per.NombreP= Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            per.Edad = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("¿Qué tipo de mascota desea adoptar?");
            Console.WriteLine("Eliga una opción");
            Console.WriteLine("1 Gato");
            Console.WriteLine("2 Perro");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Elige un nombre para tu mascota:");
                ani.Nombre = Console.ReadLine();
                Console.WriteLine("¿Qué tipo de raza deseas que sea tu mascota?");
                ani.Raza = Console.ReadLine();
                Console.Write("Excelente Usted " + per.NombreP + " de Edad " + per.Edad + " ha adoptado un gato de Raza " + ani.Raza);
            }
            else 
            {
                Console.WriteLine("Elige un nombre para tu mascota:");
                ani.Nombre = Console.ReadLine();
                Console.WriteLine("¿Qué tipo de raza deseas que sea tu mascota?");
                ani.Raza = Console.ReadLine();
                Console.Write("Excelente Usted " + per.NombreP + " de Edad " + per.Edad + " ha adoptado un perro de Raza " + ani.Raza);
            }

           

        }

       
    }
}
