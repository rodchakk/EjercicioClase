

using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace EjercicioClase
{
    public class superPoder
    {

        public string Snombre {  get; set; }
        public string Sdescripcion { get; set; }
        public string Snivel { get; set; }

        public void imprimir()
        {

            Console.WriteLine($"Nombre de Superpoder: {Snombre}");
            Console.WriteLine($"Descripcion: {Sdescripcion}");
            Console.WriteLine($"Nivel: {Snivel}");


        }



    }
}
