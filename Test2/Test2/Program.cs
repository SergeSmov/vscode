﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Каким способом можно оптимизировать следующий код:
             */
            //string a = "";
            //for (int i = 0; i < 1000000; i++)
            //{
            //    a += "a";
            //}
            StringBuilder stringBuilder = new StringBuilder("");
            for (int i = 0; i < 1000000; i++)
            {
                stringBuilder.Append("a");
            }

            /*
             * Перед вами два метода, оба из которых смогут скомпилироваться и корректно отработать при 
             * их вызове, но при этом один из них является избыточным  с точки зрения использования 
             * возможностей языка C#. Вопрос – какой именно метод избыточен и почему?
             * Создание примитивного типа Method2 проще в плане затрат на производительность и ресурсы.
             * Объект более "толстый" Method1.
             */
            List<int> list = new List<int>();
            Program programm = new Program();
            programm.Method1(ref list);

            int digit = 55;
            programm.Method2(ref digit);

            /*
             * Есть следующий код. Как вы считаете, правильно ли он работает? Обоснуйте ваш ответ. 
             * Работает некорректно, надо привести к double одно или оба значения.
             * Тот факт, что переменная имеет тип данных double в этом примере, 
             * недостаточен для преобразования результата в double. Деление двух целых чисел приводит к целому 
             * числу независимо от того, как объявлена переменная результата. Чтобы получить результаты, 
             * которых мы хотим достичь, нам нужно привести целые числа как двойные в уравнении.
             * original: https://www.aubrett.com/article/information-technology/web-development/net-framework/csharp/csharp-division-floating-point
             */
            programm.Method3();

        }

        private void Method1(ref List<int> listDigits)
        {
            listDigits.Add(55);
        }

        private void Method2(ref int digit)
        {
            digit += 55;
        }

        private void Method3()
        {
            int i = 5;
            var l = new List<int> { 1, 2, 3, 4 };
            double fraction = (double) i / l.Count();
            Console.WriteLine(fraction);
        }

    }
}
