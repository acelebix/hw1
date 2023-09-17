using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] employee = new string[] { "ali", "ahmet" };
            Console.WriteLine("Calisan Adi: ");
            string employeeName = Console.ReadLine().ToLower();
            foreach (string employee1 in employee)
            {
                if (employeeName == employee[0])
                {
                    DateTime timeofStartAli = new DateTime(2023, 09, 17, 09, 00, 00);
                    calculateShift(timeofStartAli);
                    break;
                }
                else if (employeeName == employee[1])
                {
                    Console.WriteLine("Ahmet!");
                    DateTime timeofStartAhmet = new DateTime(2023, 09, 17, 08, 00, 00);
                    Console.WriteLine(timeofStartAhmet);
                    calculateShift(timeofStartAhmet);
                    break;
                }
            }
            Console.ReadKey();

        }
        public static void calculateShift(DateTime timeofStart)
        {
            DateTime germanyTime = DateTime.Now.AddHours(-1);            
            TimeSpan shiftTotal = germanyTime - timeofStart;
            int shift = Convert.ToInt32(shiftTotal.ToString().Substring(0,2));
            Console.WriteLine($"{shift} saat mesai yapildi.");
            
            int dailyWage = 800; // Gunluk yevmiye 800TL

            if (shift < 8)
            {
                Console.WriteLine("Henuz cikis yapamazsiniz. Mesainizi tamamlayiniz.");
            }
            else if (shift == 8)  
            {
                Console.WriteLine($"Gunluk yevmiyeniz: {dailyWage}");
            }
            else
            {
                int overTime = shift - 8;
                int totalWage = (overTime * 50) + dailyWage;
                Console.WriteLine($"Bugun {overTime} saat ek mesai yaptiniz. Kazanciniz {totalWage} TL");
            }
        }
    }
}
