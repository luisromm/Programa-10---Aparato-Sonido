using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    class FuenteDePoder
    {
        //atributos
        private bool tieneCorriente;
        public Fusible fusible = new Fusible();
        private Thread noLuz;

        //metodos
        public void SetTieneCorriente(bool tieneCorriente)
        {
            this.tieneCorriente = tieneCorriente;
        }

        public bool GetTieneCorriente()
        {
            return this.tieneCorriente;
        }

        public void ConsumirCorriente()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            Thread threadFusible = new Thread(fusible.ConsumirVidaUtil);
            threadFusible.Name = "Fusible";
            threadFusible.Start();

            for (int i = 0; ; i++)
            {
                Console.Write("{0} ",i);
                Thread.Sleep(500);
                if(!threadFusible.IsAlive)
                {
                    Thread.CurrentThread.Abort();
                }
                noLuz = new Thread(GenerarApagon);
                noLuz.Start();                
                Thread.Sleep(100);
                //Console.WriteLine(noLuz.IsAlive.ToString());
                if (!noLuz.IsAlive)
                {
                    Console.WriteLine("Se fue la luz");
                    threadFusible.Suspend();
                    Thread.Sleep(10000);
                    threadFusible.Resume();
                    Console.WriteLine("Regreso la luz");
                }
                noLuz.Abort();
            }
        }

        public void GenerarApagon()
        {
            for (; ; )
            {
                int valor = new Random().Next(0, 300);
                if (valor >= 30 && valor <= 40)
                {
                    //Console.WriteLine("{0}v", valor);
                    noLuz.Abort();
                }
            }            
        }
    }
}
