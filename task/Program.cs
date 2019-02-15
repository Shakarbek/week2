using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\Users\user\Desktop\tup - tup 2\Lab2\MyTest.txt";
            string path2 = @"C:\Users\user\Desktop\tup - tup 2\ghj\MyTest.txt";
          
                if (!File.Exists(path)) //если файл не существует
                {
                FileStream fs = File.Create(path);//создаем этот файл
                }

            File.Move(path, path2);//переместим через Move файл в другую папку, учитывая, что в первой папке он исчезает
        }
    }
}
