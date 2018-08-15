using Programa_10___Aparato_Sonido.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    class ReproductorMP3 : ReproductorDeMusica
    {
        //atributos

        //metodos
        //metodo sobrecargado con respecto al de la clase padre
        public override void ReproducirMusica()
        {
            Console.WriteLine("Reproduciendo MP3");
        }

        public override void Menu()
        {
            Console.WriteLine("Menu MP3");
            CrearListaDeReproduccion();
        }

        public void CrearListaDeReproduccion()
        {
            //arreglo de objetos
            Cancion[] lista = new Cancion[5];
            lista[0] = new Cancion();
            lista[0].Titulo = "MiCancion";
            lista[0].Autor = "Yo";
            lista[0].Duracion = 180;
            lista[0].Ruta = @"C:\";

            Console.WriteLine(lista[0].Titulo);
        }
    }
}
