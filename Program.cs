using System;
using System.Collections;

namespace ArrayListDemo
{
    class ArrListDemo
    {
        internal void InsrtRng(ArrayList al1, ArrayList al2, int num)
        {
            al1.InsertRange(num, al2);
        }
        internal bool CheckAlphabet(ArrayList al1, string alphabet)
        {
            return al1.Contains(alphabet);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countAl, num;
            string alphabet;
            bool res;
            Console.WriteLine("ArrayList 1:");
            ArrayList al1 = new ArrayList();
            al1.Add("A");
            al1.Add("B");
            al1.Add("C");
            al1.Add("D");
            al1.Add("E");
            al1.Add("F");
            al1.Add("G");
            foreach (Object i in al1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ArrayList 2:");
            ArrayList al2 = new ArrayList();
            al2.Add("T");
            al2.Add("U");
            al2.Add("V");
            al2.Add("W");
            al2.Add("X");
            al2.Add("Y");
            al2.Add("Z");
            foreach (Object j in al2)
            {
                Console.WriteLine(j);
            }
            countAl = al1.Count;
            do
            {
                Console.Write("Enter Value less than {0} :", countAl);
                num = Convert.ToInt32(Console.ReadLine());
            } while (num > countAl);
            new ArrListDemo().InsrtRng(al1, al2, num);
            Console.WriteLine("After Execution");
            foreach (Object i in al1)
            {
                Console.WriteLine(i);
            }
            Console.Write("Enter any string: ");
            alphabet = Console.ReadLine();
            res = new ArrListDemo().CheckAlphabet(al1, alphabet);
            if (res == true)
            {
                Console.WriteLine("Given ArrayList Contains {0}", alphabet);
            }
            else
            {
                Console.WriteLine("Given ArrayList Dosent Contain {0}", alphabet);
            }
        }
    }
}
