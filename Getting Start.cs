using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMath2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = NextInt();
            var m = NextInt();
            int[,] a = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    a[i, j] = NextInt();
                }
            }
            StringBuilder res = new StringBuilder();
            Console.WriteLine();
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                    res.Append(a[i, j] + " ");
                }
                res.Append("\n");
                Console.WriteLine();
            }
            Console.WriteLine("-----------");
            Console.Write(res);
        }
        static int s_index = 0;
        static List<string> s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                s_index = 0;
            }
            return s_tokens[s_index++];
        }

        private static int NextInt()
        {
            return Int32.Parse(Next());
        }

        private static long NextLong()
        {
            return Int64.Parse(Next());
        }
    }
}
