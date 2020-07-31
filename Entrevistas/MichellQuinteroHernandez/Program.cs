using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrevistas
{
    /// <summary>
    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int countOfElements = 3;
            int[] queries = new int[12] { 1, 2, 3, 2, 4, 2, 3, 3, 4, 2, 1, 2 };
            int numSec = 0;
            int maxSec = 0;

            Queue memCache = new Queue();

            for (int i = 0; i < queries.Length; i++)
            {
                if (memCache.Count < countOfElements)
                    memCache.Enqueue(queries[i]);
            }
            for (int i = 0; i < queries.Length; i++)
            {
                if (memCache.Contains(queries[i]))
                    numSec++;
                else
                {
                    memCache.Dequeue();
                    memCache.Enqueue(queries[i]);
                    numSec = 0;
                }

                if (maxSec < numSec)
                    maxSec = numSec;
            }
            Console.WriteLine(maxSec.ToString());
            Console.Read();
        }
    }
}
