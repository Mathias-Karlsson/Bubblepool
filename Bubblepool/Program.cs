using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class Program
    {
        static void Main(string[] args)
        {
            BubblePoolTest(args);
            Console.ReadKey();
        }
        public static void BubblePoolTest(String[] args)
        {
            BubblePool newPool = new BubblePool(5);
            Swimmer johan = new Swimmer();
            for (int i = 4; (i > 0); i--)
            {
                newPool.GetIn(new Swimmer());
            }
            try
            {
                newPool.GetIn(johan);
                // här kastas PoolDirtyException.
            }
            catch
            {
                Console.WriteLine("All swimmers has to leave the pool!");
                newPool.Clean();
            }
            newPool.GetIn(johan);
            newPool.GetIn(new Swimmer());
            // detta borde alltså inte vara något problem längre.
        }
    }
}