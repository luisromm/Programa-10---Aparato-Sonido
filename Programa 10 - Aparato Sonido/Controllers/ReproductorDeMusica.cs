using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    abstract class ReproductorDeMusica
    {
        //atributos

        //metodos
        //prototipo de la función
        public abstract void ReproducirMusica();

        //metodo virtual de la clase abstracta
        public virtual void Menu()
        {
            Console.WriteLine("Menu");
        }
    }
}
