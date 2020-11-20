/*
 * Game bowl in the style OOP, a requirement of one of the organizations
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowl
{
    static class Constans
    {
        public const ushort COUNT_FRAME = 10;
        public const ushort COUNT_SHOT = 2;
    }

    internal static class Program
    {


        private static void Main(string[] args)
        {
            var players = new List<Player>();
            Print.Write(Print.SELECTCOUNTPLAYER);
            var countPlayer = Convert.ToInt32(Print.ReadLine());
            for (var i = 1; i <= countPlayer; i++)
            {
                Print.Write("Введите номер " + i + "-го игрока?");
                var Number = Print.ReadLine();
                Print.Write("Введите имя " + i + "-го игрока?");
                var Name = Print.ReadLine();
                players.Add(new Player(Number, Name));
            }
            //players.Add(new Player("1", "Ivan"));
            //players.Add(new Player("2", "Nikola"));
            Print.Write("Введите кол-во партий?");
            var countParty = Convert.ToInt32(Print.ReadLine());
            for (ushort i = 1; i <= countParty; i++)
            {
                var party = new Party(Constans.COUNT_FRAME, Constans.COUNT_SHOT, players, i);
                var framesShots = party.StartParty();
                if (framesShots.Count == 0)
                    Print.Warning();

                foreach (var player in players)
                {
                    Print.StartParty(party, player);

                    foreach (var (frame, value) in framesShots)
                    {
                        if (frame.Player != player) continue;
                        Print.StartFrame(frame, frame.Player);
                        var countTotalSkittles = GetResult(value, player, frame);
                        Print.Total(party, frame, countTotalSkittles);
                    }
                }

                Glasses.Calc(framesShots, players);
            }
            Print.Read();
        }

        private static int GetResult(IEnumerable<Shot> value, Player player, Frame frame)
        {
            var countTotalSkittles = 0;
            foreach (var shot in value.Where(x => x.Player == player))
            {
                Print.Shot(shot);
                if (shot.IsStrike) Print.Strike();
                if (shot.IsSplit) Print.Split(shot.localWhatSkittles.Count);
                if (shot.IsSpare) Print.Spare();
                countTotalSkittles += shot.CountSkittles;
            }
            return countTotalSkittles;
        }
    }
}
