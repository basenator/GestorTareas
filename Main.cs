using System;

class Program
{
    static void Main(string[] args)
    {
        GestorTareas gestor = new GestorTareas();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Ver tareas");
            Console.WriteLine("3. Completar tarea");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Descripción: ");
                    string desc = Console.ReadLine();
                    gestor.AgregarTarea(desc);
                    break;

                case "2":
                    var tareas = gestor.ObtenerTareas();
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas.");
                    }
                    else
                    {
                        foreach (var t in tareas)
                        {
                            Console.WriteLine(t);
                        }
                    }
                    break;

                case "3":
                    Console.Write("ID de la tarea a completar: ");
                    if (int.TryParse(Console.ReadLine(), out int idCompletar))
                    {
                        gestor.CompletarTarea(idCompletar);
                    }
                    break;

                case "4":
                    Console.Write("ID de la tarea a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int idEliminar))
                    {
                        gestor.EliminarTarea(idEliminar);
                    }
                    break;

                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}