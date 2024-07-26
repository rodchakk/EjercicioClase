// See https://aka.ms/new-console-template for more information
using EjercicioClase;

Console.WriteLine("********Superheroes********");
Console.WriteLine("");





//Instancia para SuperHeroe
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



