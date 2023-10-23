

using System.Text;
using SuperHeroesApp.Models;


/*Pendiente por hacer los atributos privados y crear clases para la impresión de estos*/
var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelDos;

SuperPoder telaraña = SuperPoder.CreaPoder("telaraña", "Permite lanzar un tejido para desplazarse a través de este", NivelPoder.NivelUno);
SuperPoder volar = SuperPoder.CreaPoder("Volar", "Capacidad para volar y planear en el aire",NivelPoder.NivelDos);
SuperPoder volar2 = SuperPoder.CreaPoder("Volareeeee", "Capacidad para volar y planear en el aire", NivelPoder.NivelDos);

//telarania.CreaPoder("nombre 1","descripcion 1",NivelPoder.NivelDos);

//Creo un objeto de lista llamado poderesSuperman
List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(volar);
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(telaraña);

//Creo un objeto de lista llamado poderesSuperman
List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);

//Creación de SuperHeroe
var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "     Superman        ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metrópolis";
superman.PuedeVolar = true;
superman.SuperPoderes = poderesSuperman;
string ResultSuperman = superman.UsarSuperPoderes();
Console.WriteLine(ResultSuperman);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);
string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);


//Creación AntiHeroe para probar la Herencia como concepto
var wolverine = new AntiHeroe();
wolverine.Id = 2;
wolverine.Nombre = "  Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;
wolverine.SuperPoderes = poderesWolverine;
string ResultWolverine = wolverine.UsarSuperPoderes();
Console.WriteLine(ResultWolverine);

string accionAntiHeroe = "Ataque a la policia";
string delito = wolverine.CometerDelito(accionAntiHeroe);
Console.WriteLine(delito);




