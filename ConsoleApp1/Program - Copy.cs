using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1 = DecreeCompliant(1, new string[] { "....---.-"});
            int n2 = DecreeCompliant(2, new string[] { "...---.-",".-.-.-.-"});
            int n3 = DecreeCompliant(2, new string[] { "...---.-", ".-.-.-.-","-.-.-.--.-." });
            int n4 = DecreeCompliant(2, new string[] { "...---.-", ".-.-.-.-", "-.-.-.--.-." ,".-.-.-"});
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.Read();
        }

        public static int DecreeCompliant(int input1, string[] input2)
        {
            int n = 0;
            List<char> stk = new List<char>();
            for (int j = 0; j < input2.Length; j++)
            {
                string str = input2[j];
                if (Convert.ToChar(str[0]) == '.' || Convert.ToChar(str[str.Length - 1]) == '-')
                {
                    for (int k = 0; k < str.Length; k++)
                    {
                        stk.Add(Convert.ToChar(str[k]));
                    }
                    if (stk.Count(i => i.Equals('.')) == stk.Count(i => i.Equals('-')))
                    { n = n + 1; }
                }

            }
            return n;
        }
    }
}
