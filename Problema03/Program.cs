using System;

namespace Problema03
{

    class Program
    {
        static void Main(string[] args)
        {
            Auto Auto1 = CrearAutoFiat(2020);            
            MostrarAuto(Auto1);            

            Auto Auto2 = CrearAutoPeugeot();
            try{
                MostrarAuto(Auto2);
            }
            catch(Exception ex){
                Console.WriteLine("No se instació el objeto");
                Console.WriteLine("Mensaje de error: " + ex.Message);
            }
        }

        static Auto CrearAutoFiat(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Fiat"
                };
            }

            return auto;
        }

        static Auto CrearAutoPeugeot(int? anio = null)
        {
            Auto auto = null;
            
            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Peugeot"
                };
            }

            return auto;
        }

        static void MostrarAuto(Auto auto)
        {
            Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
            Console.ReadLine();
        }
    }
}
