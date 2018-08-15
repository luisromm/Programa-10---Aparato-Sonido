using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Programa_10___Aparato_Sonido.Classes
{
    class ReproductorRadio : ReproductorDeMusica
    {
        public override void ReproducirMusica()
        {
            //Reproducir musica de radio
            WindowsMediaPlayer windowsMediaPlayer =
                new WindowsMediaPlayer();
            windowsMediaPlayer.URL = "http://avw.mdr.de/streams/284310-0_mp3_low.m3u";
            windowsMediaPlayer.controls.play();
        }
    }
}
