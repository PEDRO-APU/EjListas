using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjListas
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {
            //punto a
            List<String> listaColores = new List<string>(colors);
            List<String> listaRemove = new List<string>(removeColors);

         //punto b
          foreach(String colores in listaColores)
            {
                Console.WriteLine(colores);
            }

            //punto c
            listaColores = listaColores.Except(listaRemove).ToList();
          

            //punto d
            Console.WriteLine("nueva lista");
            foreach (String colores in listaColores)
            {
                Console.WriteLine(colores);
            }
        
            Console.ReadKey();        

            
           
        }
    }
        


            
        
}
