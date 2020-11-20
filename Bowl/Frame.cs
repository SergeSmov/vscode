using System.Collections.Generic;

namespace Bowl
{
    internal class Frame
    {
        internal readonly List<Shot> shots;
        private ushort CountSkittles;
        private List<ushort> whatSkittles;
        private readonly ushort CountShot;
        internal ushort Number;
        public Player Player { get; }


        internal Frame(ushort countShot, Player player)
        {
            CountShot = countShot;
            shots = new List<Shot>();
            Player = player;
            DoInitSkittles();
        }

        private void DoInitSkittles()
        {
            CountSkittles = (ushort)SkittleEnum.Ten;
            whatSkittles = new List<ushort>();
        }

        internal void DoShots()
        {
            for (ushort i = 1; i <= CountShot; i++)
            {
                var shot = DoNewShot(i);
                if (Number == Constans.COUNT_FRAME && (shot.IsStrike || shot.IsSpare))
                {
                    GetFrameTen(shot);
                    break;
                }
                if (shot.IsStrike && Number != Constans.COUNT_FRAME) break; // strike
            }
        }

        private Shot DoNewShot(ushort i)
        {
            var shot = new Shot(CountSkittles, whatSkittles, Player, i);
            shot.DoShot();
            shots.Add(shot);
            CountSkittles = GetRestCountSkittles(shot);
            return shot;
        }

        private void GetFrameTen(Shot shot)
        {
            if (shot.IsStrike)
            {
                for (ushort i = 3; i <= 4; i++)
                {
                    if (CountSkittles == 0)
                        DoInitSkittles();
                    DoNewShot(i);
                }
            }
            else
            if (shot.IsSpare)
            {
                DoInitSkittles();
                DoNewShot(3);
            }
        }

        private ushort GetRestCountSkittles(Shot shot)
        {
            return (ushort)(CountSkittles - shot.CountSkittles);
        }
    }
}
