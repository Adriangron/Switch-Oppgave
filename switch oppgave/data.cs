using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_oppgave
{
    internal class data
    {
        public void Run()
        {
            Random random = new Random();

            int dayNumber = random.Next(1, 8);

            Console.WriteLine("Today is ");

            switch (dayNumber)
            {
                case 1:
                   Console.WriteLine("Mandag :(((");
                break;
            }
            switch (dayNumber)
            {
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
            }
            switch (dayNumber)
            {
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
            }
            switch (dayNumber)
            {
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
            }
            switch (dayNumber)
            {
                case 5:
                    Console.WriteLine("FREDAG!!!");
                    break;
            }
            switch (dayNumber)
            {
                case 6:
                    Console.WriteLine("Lørdag c:");
                    break;
            }
            switch (dayNumber)
            {
                case 7:
                    Console.WriteLine("Søndag :c");
                    break;
            }
        }
    }
}
