using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void P(string s) //создаем функцию, чтобы проверить, является ли строка полиндромом
        {
            bool ok = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - i - 1] != s[i])
                {
                    ok = false;
                    break;

                }
            }

            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }

        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C: \Users\user\Desktop\tup - tup 2\Lab2\task1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();

            P(line);//ставим строку в функцию

            sr.Close();
            fs.Close();
        }


        }
    }

