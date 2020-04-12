using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace testacmp
{
    class Program
    {
        static void Main(string[] args)
        {

            //string firstStr = Console.ReadLine();
            //string secondStr = Console.ReadLine();

            
            //string ggg ="";
            
            //int count = 0;
            //List<char> lstr = new List<char>();

            //for (int i = 0; i < firstStr.Length; i++)
            //{
            //    lstr.Add(firstStr[i]);
            //}

            //for (int i = 0; i < firstStr.Length; i++)
            //{
            //    ggg = "";
            //    for (int j = 0; j < firstStr.Length; j++)
            //    {
            //        ggg += lstr[j];
            //    }
            //    while (true)
            //    {
            //        int ii = 0;
            //        int h = ggg.IndexOf(secondStr, ii);
            //        //if (ggg == secondStr) { count++; }
            //        if (h == -1)
            //        { 
                    
            //        }
            //    }
                

            //    lstr.Insert(0, lstr[lstr.Count - 1]);
            //    lstr.RemoveAt((lstr.Count - 1));
            //}
            //Console.WriteLine(count);
            string t = "1211";
            int ut = 0;
            int tt = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    ut += int.Parse(t[i].ToString());
                }
                else {
                    tt += int.Parse(t[i].ToString());
                }
            }

            if ((ut - tt) % 11 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
