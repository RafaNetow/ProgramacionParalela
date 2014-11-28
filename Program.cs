using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_dos_programacon_paralela
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                long total = GetTotal();

                Console.WriteLine(total + " ," + i);
            }*/
            
            Parallel.For(0, 10, i =>
            {
                long total = GetTotal();
                Console.WriteLine(total+ " ,"+i);
            });
            Console.ReadLine();
                 
        }


        public static long GetTotal()
        {
            long total = 0;
            for (int i = 0; i < 100000000; i++)
            {
                total++;
            }
            return total;
        }
       
    }

}
