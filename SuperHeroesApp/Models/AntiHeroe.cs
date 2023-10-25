using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string CometerDelito(string accion) {  return $"AntiHeroe:{NombreEIdentidadSecreta}, Delito Cometido: {accion}"; }
    }
}
