using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_3
{
    class Program
    {
        static string Space(int a)
        {
            string sp = "    ";
            string qp = "";
            for(int i = 0; i < a; i++)
            {
                qp += sp;
            }
            return qp;
        }
        static void Pap(DirectoryInfo direct, int a)
        {
            FileInfo[] files = direct.GetFiles();
            DirectoryInfo[] folders = direct.GetDirectories();
            foreach(FileInfo file in files)
            {
                Console.Write(Space(a));
                Console.WriteLine(file.Name);
            }
            foreach(DirectoryInfo file in folders)
            {
                Console.Write(Space(a));
                Console.WriteLine(file.Name);
                Pap(file, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo direct = new DirectoryInfo(@"C:\Users\Yernur\Desktop\C#");
            Pap(direct, 0);
            Console.ReadKey();
        }
    }
}
