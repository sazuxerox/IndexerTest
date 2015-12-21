using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTester
{
     class TempRecord
    {
        private float[] temp = new float[] {45.2f, 23.1f, 21.5f, 26.7f};
        public int length()
        {
            return temp.Length;
        }

        public float this[int index]
        {
        get
        {
            return temp[index];
        }
            set
            {
                temp[index] = value;
            }
        }
     }
    

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var tr = new TempRecord();
            for (; i < tr.length(); i++)
            {
                Console.WriteLine("Element #{0} =>  {1:f2}", i+1, tr[i]);
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
