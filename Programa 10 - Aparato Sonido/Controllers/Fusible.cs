using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Programa_10___Aparato_Sonido.Classes
{
    class Fusible
    {
        //propiedades
        public int VidaUtil { get; set; }

        //metodos
        public Fusible()
        {
            VidaUtil = 15;
        }

        public void ConsumirVidaUtil()
        {
            for (int i = VidaUtil; i > 0; i--)
            {
                StreamWriter streamWriter 
                    = new StreamWriter(@"C:\Users\Luis Roberto\Documents\Visual Studio 2017\Projects\Programa 10 - Aparato Sonido\Programa 10 - Aparato Sonido\Files\fusible.txt");
                streamWriter.WriteLine(i);
                Console.Write(" {0}vu ", i);
                Thread.Sleep(3000);
                streamWriter.Close();
            }
        }
    }
}
