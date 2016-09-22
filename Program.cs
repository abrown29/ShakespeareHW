using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShakespeareHW
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Shakespeare.txt");

            string line = reader.ReadLine();
            Console.WriteLine(line);

            reader.Close();

            StreamReader newReader = new StreamReader("..\\..\\Shakespeare.txt");

            string entire = newReader.ReadToEnd();
            Console.WriteLine(entire);
            newReader.Close();

            StreamReader brandNewReader = new StreamReader("..\\..\\Shakespeare.txt");
            string toCapital = brandNewReader.ReadToEnd();
            string result = toCapital.Replace('a', 'A');
            result = result.Replace('e', 'E');
            result = result.Replace('i', 'I');
            result = result.Replace('o', 'O');
            result = result.Replace('u', 'U');
            Console.WriteLine(result);



        }
    }
}
