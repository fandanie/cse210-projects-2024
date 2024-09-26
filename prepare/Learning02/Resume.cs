using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Inicializa la lista

    public void Display()
    {
        Console.WriteLine($"Resume for: {_name}");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}