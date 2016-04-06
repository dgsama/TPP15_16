using System;
using System.Text;
using System.Text.RegularExpressions;

namespace TPP.ObjectOriented.Overload {

    class ExtensionMethods {

        public static void Run() {
            string párrafo = @"
                Si la misión del W3C es guiar la Web hacia su máximo potencial, 
                la nuestra es formar a los profesionales e investigadores 
                capaces de llevarlo a cabo, 
                integrando aplicaciones de Internet, 
                construyendo arquitecturas orientadas a servicios, 
                administrando servidores de información y creando sitios web usables, 
                accesibles y que cumplan con los estándares.
        ";
            Console.WriteLine("Paragraph words: {0}.", párrafo.ContarPalabras());
        }
    }


}
