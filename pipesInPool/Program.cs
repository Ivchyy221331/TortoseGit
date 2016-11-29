using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {

            int poolVolume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());

            double workingHours = double.Parse(Console.ReadLine());

           var  p1Filling = p1 * workingHours;
           var  p2Filling = p2 * workingHours;
           
           var  poolFilling = p1Filling + p2Filling;
           var  poolFillingInPercent = ((p1Filling / poolVolume) * 100) + ((p2Filling / poolVolume) * 100);
           
           var  p1InPercent = ((p1Filling / poolFilling) * 100);
           var  p2InPercent = ((p2Filling / poolFilling) * 100);
           
           var  poolOverflow = Math.Abs(poolVolume - (p1Filling + p2Filling));




            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                    workingHours, poolOverflow);
            }

            if (poolVolume >= poolFilling)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    poolFillingInPercent, p1InPercent, p2InPercent);


           


        }
    }
}
