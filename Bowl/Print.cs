using System;
using System.Linq;

namespace Bowl
{
    internal static class Print
    {
        public const string SELECTCOUNTPLAYER = "Game Bolw (Игра Боулинг) \"Enter count players (Введите кол-во игроков)\"";
        public static void Write(string value)
        {
            Console.WriteLine(value);
        }

        public static void Read()
        {
            Console.Read();
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static void Spare()
        {
            Print.Write("'/' 'Spare - запасной'");
        }

        public static void Strike()
        {
            Print.Write("'X' 'Strike - удар'");
        }

        public static void Split(int countSkittles)
        {
            Print.Write("S' Split - расколотый' " + countSkittles);
        }

        public static void Warning()
        {
            Print.Write("Game error! Contact Microsoft.");
        }

        public static void Total(Party party, Frame frame, int countTotalSkittles)
        {
            if (countTotalSkittles == (int)SkittleEnum.Ten || frame.Number == Constans.COUNT_FRAME)
                Print.Write("Всего за фрейм №: " + frame.Number + " выбито " +
                            countTotalSkittles + " кегли(ей).");
            else
                Print.Write("Всего за фрейм №: " + frame.Number + " выбито " + countTotalSkittles + " кегли(ей). Фрейм открытый.");
            if (frame.Number == Constans.COUNT_FRAME)
                Print.Write("Игрок " + frame.Player.Name + ". Партия № " + party.NumberParty + ". Партия окончена!");
            Print.Write("");
        }

        public static void StartFrame(Frame frame, Player player)
        {
            Print.Write("Фрейм № " + frame.Number + ". Игрок " + player.Name);
        }

        public static void StartParty(Party party, Player player)
        {
            Print.Write("Партия № " + party.NumberParty + ". Игрок " + player.Name);
        }

        public static void Shot(Shot shot)
        {
            Print.Write("Бросок № " + shot.NumberShot + "! Выбито: " + shot.CountSkittles + " кегли(ей). Номер(а) кегли(ей):" +
                        shot.localWhatSkittles.Aggregate("", (current, localWhatSkittle) =>
                current + " " + localWhatSkittle));
        }
    }
}
