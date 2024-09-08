using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Lib;

namespace Lab2App
{
    internal class SubscriberApp
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SubscriberLib[] arrSubscribers;
            Console.Write("Введіть кількість абонентів: ");
            int cntSubscribers = int.Parse(Console.ReadLine());
            arrSubscribers = new SubscriberLib[cntSubscribers];
            for (int i = 0; i < cntSubscribers; i++)
            {
                Console.Write("Введіть ім'я абонента: ");
                string sName = Console.ReadLine();
                Console.Write("Введіть номер телефону: ");
                string sPhoneNumber = Console.ReadLine();
                Console.Write("Введіть адресу абонента: ");
                string sAddress = Console.ReadLine();
                Console.Write("Чи є у абонента Інтернет? (y-так, n-ні): ");
                ConsoleKeyInfo keyHasInternet = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Введіть кількість хвилин дзвінків на місяць: ");
                string sCallMinutesPerMonth = Console.ReadLine();
                Console.Write("Введіть кількість SMS на місяць: ");
                string sSMSPerMonth = Console.ReadLine();
                Console.Write("Введіть щомісячну плату: ");
                string sMonthlyFee = Console.ReadLine();
                Console.WriteLine();

                SubscriberLib theSubscriber = new SubscriberLib();
                theSubscriber.Name = sName;
                theSubscriber.PhoneNumber = sPhoneNumber;
                theSubscriber.Address = sAddress;
                theSubscriber.HasInternet = keyHasInternet.Key == ConsoleKey.Y ? true : false;
                theSubscriber.CallMinutesPerMonth = int.Parse(sCallMinutesPerMonth);
                theSubscriber.SMSPerMonth = int.Parse(sSMSPerMonth);
                theSubscriber.MonthlyFee = double.Parse(sMonthlyFee);

                arrSubscribers[i] = theSubscriber;
            }

            foreach (SubscriberLib s in arrSubscribers)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Дані про абонента: " + s.Name);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Номер телефону: " + s.PhoneNumber);
                Console.WriteLine("Адреса: " + s.Address);
                Console.WriteLine("Інтернет: " + (s.HasInternet ? "Підключено" : "Немає"));
                Console.WriteLine("Кількість хвилин дзвінків на місяць: " + s.CallMinutesPerMonth.ToString());
                Console.WriteLine("Кількість SMS на місяць: " + s.SMSPerMonth.ToString());
                Console.WriteLine("Щомісячна плата: " + s.MonthlyFee.ToString("0.00"));
                Console.WriteLine("Вартість хвилини дзвінка: " + s.CostPerMinute.ToString("0.00"));
            }
            Console.ReadKey();
        }
    }
}

