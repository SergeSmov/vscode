using System;
using System.Collections.Generic;

namespace Test4
{
    class Program
    {

        /*
         * Имеется исходный код, который с помощью рекурсии выводит имена последних детей в каждой ветви.
         * Необходимо переписать метод RecursFillLastChilds что бы он стал не-рекурсивным, при этом сохранился исходный принцип работы метод. 
         * Cортировать коллекцию SomeData вне метода RecursFillLastChilds – нельзя!
         * Условие: При добавлении новых записей в SomeData  - разработанный алгоритм должен сохранить работоспособность.
         */
        public static void Main()
        {
            Dictionary<string, List<string>> someData = new Dictionary<string, List<string>>();
            someData["Петр Иванович"] = new List<string>();
            someData["Петр Иванович"].Add("Анна Петровна");
            someData["Петр Иванович"].Add("Максим Петровна");
            someData["Максим Иванович"] = new List<string>();
            someData["Максим Иванович"].Add("Андрей Максимович");
            someData["Максим Иванович"].Add("Миша Максимович");
            someData["Максим Иванович"].Add("Николай Максимович");
            someData["Анна Ивановна"] = new List<string>();
            someData["Анна Ивановна"].Add("Артем");
            someData["Николай Максимович"] = new List<string>();
            someData["Николай Максимович"].Add("Катя");
            someData["Николай Максимович"].Add("Маша");
            someData["Анна Ивановна"].Add("Саша");
            someData["Федор Федорович"] = new List<string>();
            someData["Федор Федорович"].Add("Евдоким");
            someData["Федор Федорович"].Add("Фрося");
            someData["Федор Федорович"].Add("Калистрат");

            List<string> lastChilds = new List<string>();
            RecursFillLastChilds2("Федор Федорович", someData, lastChilds);
            foreach (var child in lastChilds)
            {
                Console.WriteLine(child);
            }
        }

        private static void RecursFillLastChilds(string parentName, Dictionary<string, List<string>> someData, List<string> lastChilds)
        {
            if (!someData.ContainsKey(parentName))
            {
                lastChilds.Add(parentName);
                return;
            }
            foreach (string child in someData[parentName])
            {
                RecursFillLastChilds(child, someData, lastChilds);
            }
        }


        private static void RecursFillLastChilds2(string parentName, Dictionary<string, List<string>> someData, List<string> lastChilds)
        {
            foreach (string child in someData[parentName])
            {
                if (!someData.ContainsKey(child))
                {
                    lastChilds.Add(child);
                }
            }
        }
    }
}
