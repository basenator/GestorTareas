using System;
using System.Collections.Generic;
using System.Linq;

public class Tarea
{
    public int Id { get; set; }
    public string Descripcion { get; set; }
    public bool Completada { get; set; }

    public Tarea(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
        Completada = false;
    }

    public override string ToString()
    {
        return $"{Id}: {Descripcion} - {(Completada ? "✔" : "✘")}";
    }
}

public class GestorTareas
{
    private List<Tarea> tareas;
    private int contadorId;

    public GestorTareas()
    {
        tareas = new List<Tarea>();
        contadorId = 1;
    }

    public void AgregarTarea(string descripcion)
    {
        tareas.Add(new Tarea(contadorId++, descripcion));
    }

    public List<Tarea> ObtenerTareas()
    {
        return tareas;
    }

    public void CompletarTarea(int id)
    {
        var tarea = tareas.FirstOrDefault(t => t.Id == id);
        if (tarea != null)
        {
            tarea.Completada = true;
        }
        else
        {
            Console.WriteLine("Tarea no encontrada");
        }
    }

    public void EliminarTarea(int id)
    {
        var tarea = tareas.FirstOrDefault(t => t.Id == id);
        if (tarea != null)
        {
            tareas.Remove(tarea);
        }
        else
        {
            Console.WriteLine("Tarea no encontrada");
        }
    }
}