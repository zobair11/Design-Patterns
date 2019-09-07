using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_responsibility
{

    public class employee
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: { text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
        
    }
    public class Persistance
    {
        public void SaveToFile(employee emp, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, emp.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var newemployee = new employee();
            newemployee.AddEntry("Zobair Islam");
            newemployee.AddEntry("Abdul Kader");

            Console.WriteLine(newemployee);

            var emp = new Persistance();
            var filename = @"F:\Design Pattens\Single_responsibility\employee.txt";
            emp.SaveToFile(newemployee, filename, true);
            Process.Start(filename);
            Console.ReadKey();
        }
    }
}
