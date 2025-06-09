using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp18;

namespace ConsoleApp18
{
    internal class car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        private int _doorsNumber;  

        public int doorsNumber
        {
            get { return _doorsNumber; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorsNumber = value;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı yalnızca 2 veya 4 olmalıdır. Varsayılan olarak -1 atanıyor.");
                    _doorsNumber = -1;
                }
            }
        }

        public void PrintInfo() // Fixed method name and moved it inside the class  
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Renk: {Renk}");
            Console.WriteLine($"Kapı Sayısı: {doorsNumber}");
        }
    }
}
