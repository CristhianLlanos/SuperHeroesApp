using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class ImprimirInfo
    {

        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine($"Id: {superHeroe.Id}");
            Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
            Console.WriteLine("***************************************************");
        }

        public void ImprimirTodo(ISuperHeroe super)
        {
            Console.WriteLine($"Id:{super.Id}, Nombre:{super.Nombre}, Identidad Secreta:{super.IdentidadSecreta}");
            Console.WriteLine("***************************************************");
        }

    }
        
}
