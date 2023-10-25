using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHeroe
    {
        //El objetivo de esta interface en definir las propiedades o datos generales hacia un método que va a imprimir esta información,
        //la interface se implementa de la misma forma que la herencia: en este caso la Implementaré en SuperHeroe para que no le pase otros datos a parte de estos
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }   
    }
}
