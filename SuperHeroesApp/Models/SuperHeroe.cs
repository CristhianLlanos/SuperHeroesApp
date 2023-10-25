using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    //Clase SuperHeroe    
    class SuperHeroe : Heroe, ISuperHeroe
    {
        public int Id { get; set; }       
        private string _Nombre;
        public override string Nombre {  get { return _Nombre; } set { _Nombre = value.Trim(); }}
        public string IdentidadSecreta { get; set; }
        public string NombreEIdentidadSecreta {get{return $"{Nombre}({IdentidadSecreta})";}}


        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        //Método constructor, puedo crear otros métodos que me ayuden a definir el comportamiento de nuestros objetos
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        internal string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder de {poder.Nombre}!!");
            }
            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();//con base estaría haciendo lo que hace el padre
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }
}
