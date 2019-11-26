using System;
using System.Threading;

namespace accounts
{
    class Program
    {
        static Account account;
        // static Two_resourses two_resourses;
        static double Init = 1000;
        static int n = 20000, m = 20000;
        static double husband_sum = 0;
        static double wife_sum = 0;
        static double daughter_sum = 0;

        static void Main(string[] args)
        {
            Test_Unsafe();
        }

        static void Test_Unsafe()
        {
            // account = new Account(Init);
            account = new Safe_Account(Init);
            Go();
        }

        /// <summary>
        /// В трех разных потоках
        /// моделируется параллельная работа со счетом
        /// трех членов одной семьи - мужа, его жены и дочери        
        /// </summary>
        static void Go()
        {
            //Создание потоков для трех клиентов 
            Thread h = new Thread(Husband);
            Thread w = new Thread(Wife);
            Thread d = new Thread(Daughter);
            //запуск их методов на выполнение
            h.Start();
            d.Start();
            w.Start();
            //Пора подвести итоги работы
            d.Join();
            h.Join();
            w.Join();
            Console.WriteLine("Работа со счетом закончена" +
               "\r\n" + "Муж положил = " + husband_sum.ToString() +
               "\r\n" + "Дочь сняла = " + daughter_sum.ToString() +
                "\r\n" + "Жена сняла = " + wife_sum.ToString() +
                "\r\n" + "Баланс = " + account.Sum);
            if (husband_sum != daughter_sum + wife_sum + account.Sum)
                Console.WriteLine("Опасные операции над счетом!");
        }

        static void Husband()
        {
            husband_sum = Init;
            for (int i = 0; i < n; i++)
            {
                account.Add(300);
                if (!account.Error)
                    husband_sum += 300;
            }
        }

        static void Wife()
        {
            for (int i = 0; i < m; i++)
            {
                account.Sub(400);
                if (!account.Error)
                    wife_sum += 400;
            }
        }

        static void Daughter()
        {
            if (account == null) Thread.Sleep(0);
            for (int i = 0; i < m; i++)
            {
                account.Sub(500);
                if (!account.Error)
                    daughter_sum += 500;
            }
        }
    }
}
