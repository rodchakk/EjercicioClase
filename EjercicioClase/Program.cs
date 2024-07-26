// See https://aka.ms/new-console-template for more information
using EjercicioClase;

Console.WriteLine("********Superheroes********");
Console.WriteLine("");





//Instancia para SuperHeroe #1
SuperHeroe superHeroe1 = new SuperHeroe();
superHeroe1.Nombre = "Batman";
superHeroe1.IdentidadSecreta = "Bruce Wayne";
superHeroe1.Ciudad = "Gotham";
superHeroe1.PuedeVolar = "puedeVolar";


//Instancia para SuperPoder 
superPoder superPoder1 = new superPoder();
superPoder1.Snombre = "Inteligencia Superior";
superPoder1.Sdescripcion = "Habilidad en el Combate Cuerpo a Cuerpo";
superPoder1.Snivel = "6";


superHeroe1.imprimir();
superPoder1.imprimir();



//Instancia para SuperHeroe #2
SuperHeroe superHeroe2 = new SuperHeroe();
Console.Write("Ingrese el nombre del superheroe: ");
superHeroe2.Nombre = Console.ReadLine();
Console.Write("Cual es su identidad secreta? ");
superHeroe2.IdentidadSecreta = Console.ReadLine();
Console.Write("Ingrese su ciudad ");
superHeroe2.Ciudad = Console.ReadLine();
Console.Write("Tiene habilidad para volar? ");
superHeroe2.PuedeVolar = Console.ReadLine();


//Instancia para SuperPoder#2
superPoder superPoder2 = new superPoder();
Console.WriteLine("Ingrese el nombre del super poder: ");
superPoder2.Snombre = Console.ReadLine();
Console.WriteLine("Descripcion del poder: ");
superPoder2.Sdescripcion = Console.ReadLine();
Console.WriteLine("Nivel de poder");
superPoder2.Snivel = Console.ReadLine();

Console.WriteLine("");


superHeroe2.imprimir();
superPoder2.imprimir();