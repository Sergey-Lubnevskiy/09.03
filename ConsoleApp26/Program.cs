using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        public static void Main()
        {
            Hashtable myHT = new Hashtable();
            myHT.Add("Токио -", "Tokyo");
            myHT.Add("Ходжалы -", "Khojaly");
            myHT.Add("Фрязино -", "Fryazino");
            myHT.Add("Тулуза -", "Toulouse");
            myHT.Add("Черновцы -", "Chernivtsi");

            Hashtable myHT1 = new Hashtable();
            myHT.Add("Tokyo -", "Токио");
            myHT.Add("Khojaly -", "Ходжалы"); 
            myHT.Add("Fryazino -", "Фрязино");
            myHT.Add("Toulouse - ", "Тулуза");
            myHT.Add("Chernivtsi -", "Черновцы");

            Console.WriteLine("1-Вывести словарь\n0-Не выводить");
            int num = Console.Read();
            Console.WriteLine("Вывести словарь\n1-Русско-английский\n2-Англо-русский");
            int num2 = Console.Read();

            if(num==0)
            {
                Console.ReadKey();
            }
            else if(num == 1 && num2 == 1)
            {
                Rus(myHT);
            }
            else if(num == 1 && num2 == 2)
            {
                Eng(myHT1);
            }
        }


        public static void Rus(Hashtable myHT)
        {
            Console.WriteLine("\tРусский\tАнглийский");

            foreach (DictionaryEntry de in myHT)
                Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
        }
        public static void Eng(Hashtable myHT1)
        {
            Console.WriteLine("\tРусский\tАнглийский");

            foreach (DictionaryEntry de in myHT1)
                Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
        }
    }
}
