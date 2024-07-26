// See https://aka.ms/new-console-template for more information
using EjercicioClase;

Console.WriteLine("********Superheroes********");
Console.WriteLine("");





//Instancia para SuperHeroe de prueba 
Console.WriteLine("Ingrese los datos del superheroe como el en siguiente ejemplo: ");
Console.WriteLine("");
SuperHeroe superHeroe1 = new SuperHeroe();
superHeroe1.Nombre = "Batman";
superHeroe1.IdentidadSecreta = "Bruce Wayne";
superHeroe1.Ciudad = "Gotham";
superHeroe1.PuedeVolar = "puedeVolar";


//Instancia para SuperPoder prueba 
superPoder superPoder1 = new superPoder();
superPoder1.Snombre = "Inteligencia Superior";
superPoder1.Sdescripcion = "Habilidad en el Combate Cuerpo a Cuerpo";
superPoder1.Snivel = "6";


superHeroe1.imprimir();
superPoder1.imprimir();
Console.WriteLine("");


Console.WriteLine("*******Inicie aqui*******");




//Instancia para SuperHeroe #1
SuperHeroe superHeroe2 = new SuperHeroe();
Console.Write("Ingrese el nombre del Super Heroe #1: ");
superHeroe2.Nombre = Console.ReadLine();
Console.Write("Cual es su identidad secreta? ");
superHeroe2.IdentidadSecreta = Console.ReadLine();
Console.Write("Ingrese su ciudad ");
superHeroe2.Ciudad = Console.ReadLine();
Console.Write("Tiene habilidad para volar? ");
superHeroe2.PuedeVolar = Console.ReadLine();


//Instancia para SuperPoder#1
superPoder superPoder2 = new superPoder();
Console.WriteLine("Ingrese el nombre del Super Heroe: ");
superPoder2.Snombre = Console.ReadLine();
Console.WriteLine("Descripcion del poder: ");
superPoder2.Sdescripcion = Console.ReadLine();
Console.WriteLine("Nivel de poder");
superPoder2.Snivel = Console.ReadLine();

Console.WriteLine("Super Heroe #1 agregado, toca una tecla para continuar");
Console.Clear();








//Instancia para SuperHeroe #2
SuperHeroe superHeroe3 = new SuperHeroe();
Console.Write("Ingrese el nombre del Super Heroe #2: ");
superHeroe3.Nombre = Console.ReadLine();
Console.Write("Cual es su identidad secreta? ");
superHeroe3.IdentidadSecreta = Console.ReadLine();
Console.Write("Ingrese su ciudad ");
superHeroe3.Ciudad = Console.ReadLine();
Console.Write("Tiene habilidad para volar? ");
superHeroe3.PuedeVolar = Console.ReadLine();



//Instancia para SuperPoder#2
superPoder superPoder3 = new superPoder();
Console.WriteLine("Ingrese el nombre del super poder: ");
superPoder3.Snombre = Console.ReadLine();
Console.WriteLine("Descripcion del poder: ");
superPoder3.Sdescripcion = Console.ReadLine();
Console.WriteLine("Nivel de poder");
superPoder3.Snivel = Console.ReadLine();

Console.WriteLine("Super Heroe #2 agregado, toca una tecla para continuar");
Console.Clear();





//Instancia para SuperHeroe #3
SuperHeroe superHeroe4 = new SuperHeroe();
Console.Write("Ingrese el nombre del Super Heroe #3: ");
superHeroe4.Nombre = Console.ReadLine();
Console.Write("Cual es su identidad secreta? ");
superHeroe4.IdentidadSecreta = Console.ReadLine();
Console.Write("Ingrese su ciudad: ");
superHeroe4.Ciudad = Console.ReadLine();
Console.Write("Tiene habilidad para volar? ");
superHeroe4.PuedeVolar = Console.ReadLine();








//Instancia para SuperPoder#3
superPoder superPoder4 = new superPoder();
Console.WriteLine("Ingrese el nombre del super poder: ");
superPoder4.Snombre = Console.ReadLine();
Console.WriteLine("Descripcion del poder: ");
superPoder4.Sdescripcion = Console.ReadLine();
Console.WriteLine("Nivel de poder");
superPoder4.Snivel = Console.ReadLine();

Console.WriteLine("Super Heroe #3 agregado, toca una tecla para continuar");
Console.Clear();









//iMPRESION DE DATOS


Console.WriteLine("Super Heroe #1");
superHeroe2.imprimir();
superPoder2.imprimir();
Console.WriteLine("");
Console.WriteLine("*******");
Console.WriteLine("");

Console.WriteLine("Super Heroe #2");
superHeroe3.imprimir();
superPoder3.imprimir();
Console.WriteLine("");
Console.WriteLine("*******");
Console.WriteLine("");

Console.WriteLine("Super Heroe #3");
superHeroe4.imprimir();
superPoder4.imprimir();
Console.WriteLine("");
Console.WriteLine("*******");
Console.WriteLine("");


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Sistema terminado");
