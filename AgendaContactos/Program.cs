using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables necesarias
            int opcion;
            string nombre;
            long numero;

            //instancia de la clase
            Dictionary<string, long> contactos = new Dictionary<string, long>();
            Console.Clear();

            do
            {
                Console.Clear();
                // menu 
                Console.WriteLine("1. Agregar contacto :");
                Console.WriteLine("2. Buscar contacto :");
                Console.WriteLine("3. Eliminar contacto :");
                Console.WriteLine("4. Mostrar los contactos :");
                Console.WriteLine("5. Actualizar contacto :");
               
                Console.WriteLine("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
             

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        // Leer nombre
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Clear();
                        // Leer numero
                        Console.Write("Número: ");
                        numero = Convert.ToInt64(Console.ReadLine());

                        //Agregar nombre y numero 
                        contactos.Add(nombre, numero);

                        Console.WriteLine("\nEl contacto {0}, ha sido agregado con exito", nombre);
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu: ");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("Buscar contacto por nombre: ");
                        nombre = Console.ReadLine();
                        if (contactos.ContainsKey(nombre))
                        {
                            Console.WriteLine("\nEl contacto existe en la agenda: ");
                            Console.WriteLine("\n{0}: {1}", nombre, contactos[nombre]);
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu: ");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("\nEl contacto No existe en la agenda: ");
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu: ");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Eliminar contacto de la agenda: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            contactos.Remove(nombre);
                            Console.WriteLine("\nEl contacto {0}, ha sido eliminado de la agenda con exito: ", nombre);

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu: ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nEl contacto No existe en la agenda: ");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...: ");
                            Console.ReadKey();
                        }

                        break;

                    case 4:
                        Console.WriteLine("\nContactos en la agenda:\n ");
                        foreach (KeyValuePair<string, long> elementos in contactos)
                        {
                            Console.WriteLine("\n {0}; {1}: ", elementos.Key, elementos.Value);

                        }
                        Console.WriteLine("\nPresiona cualquier tecla para regresar al menu: ");
                        Console.ReadKey();

                        break;

                    case 5:
                        Console.Write("\n Escribe el nombre del contacto que deseas alcualizar: ");
                        nombre = Console.ReadLine();

                        if (contactos.ContainsKey(nombre))
                        {
                            Console.Write("\nEscribe nuevo numero: ");
                            numero = Convert.ToInt64(Console.ReadLine());

                            contactos[nombre] = numero;  //actualizamos
                            Console.WriteLine("\nContacto acualizado \n{0} y su nuevo numero es: {1} ", nombre, contactos[nombre]);
                        
                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...: ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nEl contacto No existe en la agenda: ");

                            Console.WriteLine("\nPresiona cualquier tecla para regresar al menu...: ");
                            Console.ReadKey();
                        }

                        break;

                }

            }
            while (opcion >= 1 && opcion <= 5);


        }
    }
}
