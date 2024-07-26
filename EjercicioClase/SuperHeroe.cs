






//Crear una clase llamada SuperHeroe la cual tendrá los siguientes atributos:
//nombre
//identidadSecreta
//ciudad
//puedeVolar
//superPoder (Objeto de la clase SuperPoder)


using System;


namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public string PuedeVolar { get; set; }


        public void imprimir()
        {

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar?: {PuedeVolar}");



        }
    }
}
