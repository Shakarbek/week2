using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static bool f(int k)
        {
            if (k <= 1) return false;
            if (k == 2) return true;
            else
            {
                bool t = true;
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0)
                    {
                        t = false;
                        break;
                    }
                }
                return t;

            }
        }
        static bool f2(string s)
        {
            return f(int.Parse(s));
        }


        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C: \Users\user\Desktop\tup - tup 2\Lab2\task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            List<string> l = new List<string>();

            string a = sr.ReadLine();
            string[] b = a.Split();
            
            foreach(var x in b)
                {
                if (f2(x))
                {
                    l.Add(x);
                }
                }

            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(@"C: \Users\user\Desktop\tup - tup 2\Lab2\task2.1.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter sr2 = new StreamWriter(fs2);
 
           foreach(var x in l)
            {
                sr2.Write(x + " ");
            }


            sr2.Close();
            fs2.Close();

        }
    }
}
