using System;
using System.Linq;
using Tarea1_EFCore.Models;

namespace Tarea1_EFCore
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            northwindContext DataContext = new northwindContext();

            var empleados = DataContext.Employees
                .Where(w => w.Country == "UK")
                .Select(s => new 
            { 
                s.FirstName,
                s.LastName,
                s.City
            });
            var salida = empleados.ToList();

        }
    }
}
