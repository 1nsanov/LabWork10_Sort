using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork10_Sort
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var listHospital = new List<Hospital>();

            for (int i = 1; i <= 5; i++)
            {
                var nameCab = "Кабинет " + rnd.Next(10, 99);
                var idCab = rnd.Next(1, 1000);
                var fullName = "Хохлов Шамиль Станиславович " + i;
                var receptionDay = rnd.Next(1, 7);
                var day = rnd.Next(1, 28);
                var startReception = new DateTime(2022, 2, day, rnd.Next(7, 11), 00, 00);
                var endReception = new DateTime(2022, 2, day, rnd.Next(15, 18), 00, 00);
                listHospital.Add(new Hospital(nameCab, idCab, fullName, receptionDay, startReception, endReception));
            }


            OutputList(listHospital);

            Console.WriteLine("Сортировка по Номеру кабинета");
            listHospital.Sort();
            OutputList(listHospital);

            Console.WriteLine("Сортировка по Имени кабинета");
            listHospital.Sort(new Hospital.SortByNameCabinet());
            OutputList(listHospital);

            Console.WriteLine("Сортировка по ФИО врача");
            listHospital.Sort(new Hospital.SortByFullName());
            OutputList(listHospital);

            Console.WriteLine("Сортировка по Время начала приема");
            listHospital.Sort(new Hospital.SortByStartReception());
            OutputList(listHospital);

            Console.ReadLine();
        }

        private static void OutputList(List<Hospital> list)
        {
            Console.WriteLine();
            if (list.Count > 0)
            {
                Console.WriteLine("Название кабинета  | Номер   | ФИО                           |День приема | Начало приема | Окончание приема");
                Console.WriteLine("______________________________________________________________________________________________________________");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("______________________________________________________________________________________________________________");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
            Console.WriteLine();
        }

    }
}
