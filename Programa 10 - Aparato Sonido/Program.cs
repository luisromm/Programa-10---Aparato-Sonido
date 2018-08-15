using Microsoft.Toolkit.Uwp.Notifications;
using Programa_10___Aparato_Sonido.Classes;
using Programa_10___Aparato_Sonido.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace Programa_10___Aparato_Sonido
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Construct the visuals of the toast (using Notifications library)
            //ToastContent toastContent = new ToastContent()
            //{
            //    // Arguments when the user taps body of toast
            //    Launch = "action=viewConversation&conversationId=5",

            //    Visual = new ToastVisual()
            //    {
            //        BindingGeneric = new ToastBindingGeneric()
            //        {
            //            Children =
            //{
            //    new AdaptiveText()
            //    {
            //        Text = "Hello world!"
            //    }
            //}
            //        }
            //    }
            //};

            //// Create the XML document (BE SURE TO REFERENCE WINDOWS.DATA.XML.DOM)
            //var doc = new XmlDocument();
            //doc.LoadXml(toastContent.GetContent());

            //// And create the toast notification
            //var toast = new ToastNotification(doc);

            //// And then show it
            //DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);

            MiniComponente SonyZT20Genesi = new MiniComponente();
            SonyZT20Genesi.reproductorMP3.Menu();
            SonyZT20Genesi.reproductorRadio.ReproducirMusica();

            Console.ReadLine();
        }
    }
}
