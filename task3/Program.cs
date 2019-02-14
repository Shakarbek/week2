using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void Level(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("  ");
            }
        }
        public static void F(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                Level(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Level(level);
                Console.WriteLine(d.Name);

                F(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\user\Desktop\tup - tup 2");
            F(dir, 0);
           
        }
    }
}
    
