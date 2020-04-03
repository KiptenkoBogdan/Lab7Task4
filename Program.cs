using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"numbers.txt";
            string saveFilePath = @"saved_numbers.txt";
            Stack numbers = new Stack();
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] num = line.Split();
                    foreach (String item in num)
                    {
                        numbers.Push(item);
                    }
                }
            }

            if (!File.Exists(saveFilePath))
            {
                using (StreamWriter sw = File.CreateText(saveFilePath))
                {
                    while (numbers.Count != 0)
                    {
                        string temp = numbers.Pop().ToString() + " ";
                        sw.Write(temp);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
