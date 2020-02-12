using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabloolustur
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1=1, sayi2=1;
            while (sayi1 <=10)
            {
                while (sayi2 <= 10)
                {
                    int sonuc = sayi1 * sayi2;
                    Console.WriteLine("{0}*{1}={2}",sayi1,sayi2,sonuc);
                    sayi2++;
                }
                sayi1++;
                sayi2 = 1;
            }
            Console.Read();
        }
    }
}
