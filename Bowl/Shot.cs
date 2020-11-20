using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowl
{
    internal class Shot
    {
        public ushort CountSkittles { get; private set; }
        private readonly List<ushort> TotalSkittles;
        public readonly List<ushort> localWhatSkittles;
        public Player Player { get; }
        public ushort NumberShot { get; }
        public bool IsStrike { get; private set; } = false;
        public bool IsSplit { get; private set; } = false;
        public bool IsSpare { get; private set; } = false;

        public Shot(ushort countSkittles, List<ushort> totalSkittles, Player player, ushort numberShot)
        {
            CountSkittles = countSkittles;
            TotalSkittles = totalSkittles;
            localWhatSkittles = new List<ushort>();
            Player = player;
            NumberShot = numberShot;
            IsSplit = false;
            IsStrike = false;
            IsSpare = false;
        }

        internal void DoShot()
        {
            var rand = new Random();
            CountSkittles = (ushort) rand.Next((int) SkittleEnum.One, CountSkittles + 1);
            if (CountSkittles < (int) SkittleEnum.Ten)
            {
                DoShotSkittles(rand);
                IsSplit = GetIsSplit(this);
            }
            else
            {
                IsStrike = NumberShot == 1 || NumberShot == 3 || NumberShot == 4;
                for (ushort i = 1; i <= CountSkittles; i++)
                    localWhatSkittles.Add(i);
            }
            IsSpare = TotalSkittles.Count == (int)SkittleEnum.Ten && !IsStrike;
        }

        // Узнаем какие кегли сбили
        // Find out which pins were hit
        private void DoShotSkittles(Random rand)
        {
            for (var i = 1; i <= CountSkittles; i++)
            {
                var skittle = GetSkittles(rand);
                while (IsSkittles(skittle))
                    skittle = GetSkittles(rand);
                localWhatSkittles.Add((ushort) skittle);
                TotalSkittles.Add((ushort)skittle);
            }
        }

        private bool IsSkittles(int skittle)
        {
            return TotalSkittles.Count(x => x == skittle) > 0;
        }

        private static int GetSkittles(Random rand)
        {
            return rand.Next(1, (int) SkittleEnum.Ten + 1);
        }

        private static bool GetIsSplit(Shot shot)
        {
            return shot.NumberShot == 1 &&
                   shot.CountSkittles > 2
                   &&
                   !shot.localWhatSkittles.Contains((ushort) SkittleEnum.One)
                   &&
                   !shot.localWhatSkittles.Contains((ushort) SkittleEnum.Seven)
                   && !shot.localWhatSkittles.Contains((ushort) SkittleEnum.Ten);
            //&&
            //!shot.localWhatSkittles.Contains((ushort)SkittleEnum.Four)
            //&& !shot.localWhatSkittles.Contains((ushort)SkittleEnum.Six);
        }

    }
}