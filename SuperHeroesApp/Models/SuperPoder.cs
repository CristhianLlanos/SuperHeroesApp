using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    //Clase SuperPoder
    internal class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nombre = "";
            Descripcion = "";
            Nivel = NivelPoder.NivelUno;
        }

        public static SuperPoder CreaPoder(string nombre, string descripcion,NivelPoder nivel)
        {
            var nuevoPoder = new SuperPoder
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Nivel = nivel
            };
            return nuevoPoder;
        }
        
    }
    enum NivelPoder
    {
        NivelUno,
        NivelDos,
        NivelTres
    } 

}
