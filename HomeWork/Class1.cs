using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Class1
    {
        public int ArrayChallenge(int x)
        {
            int enBuyuk1=0;
            int[] arrr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
           
            for (int i = 0; i < arrr.Length; i++)
            {
                toplam += arrr[i];



            }
            Console.WriteLine("Toplam {0} :", toplam);
           
            Console.WriteLine(arrr.Max());

            Console.WriteLine("---------------------------");
            return 0;
        } 
    }
}
