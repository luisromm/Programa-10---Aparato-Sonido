using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    class MiniComponente
    {
        //atributos
        public ReproductorMP3 reproductorMP3;
        public ReproductorUSB reproductorUSB;
        public ReproductorRadio reproductorRadio;
        private FuenteDePoder fuenteDePoder;

        //metodos
        public MiniComponente()
        {
            this.reproductorMP3 = new ReproductorMP3();
            this.reproductorUSB = new ReproductorUSB();
            this.reproductorRadio = new ReproductorRadio();
            this.fuenteDePoder = new FuenteDePoder();

            bool corriente;
            Random rdn = new Random();
            int voltaje = rdn.Next(70) + 50;
            Console.WriteLine(voltaje);

            if (voltaje <= 80)
                corriente = false;
            else
                corriente = true;

            if (corriente)
            {
                fuenteDePoder.SetTieneCorriente(true);
                for (int i = 0; i < 1; i++)
                {
                    Thread nuevoThread = 
                        new Thread(fuenteDePoder.ConsumirCorriente);
                    nuevoThread.Name = "Luz";
                    nuevoThread.Start();
                }
            }
            else
                Console.WriteLine("No hay luz!");
        }
    }
}
