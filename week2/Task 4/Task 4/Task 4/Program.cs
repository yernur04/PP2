using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Users\Yernur\Desktop\C#\week2\Task 4\Task 4\Text1.txt";
            string b = @"C:\Users\Yernur\Desktop\C#\week2\Task 4\Task 4\Text2.txt";
            StreamWriter wr = new StreamWriter(a);
            string text = "yernur_";
            wr.Write(text);
            wr.Close();
            File.Copy(a, b);
            File.Delete(a);
        }
    }
}
