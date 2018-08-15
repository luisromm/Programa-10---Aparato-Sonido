using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    class ReproductorUSB : ReproductorDeMusica
    {
        public override void ReproducirMusica()
        {
            Console.WriteLine("Reproduciendo USB...");
        }

        public new void Menu()
        {
            base.Menu();
            Console.WriteLine("Menu USB");
        }
    }
}
