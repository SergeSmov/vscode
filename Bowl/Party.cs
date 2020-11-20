using System.Collections.Generic;
using System.Linq;

namespace Bowl
{
    internal class Party
    {
        private readonly Dictionary<Frame, List<Shot>> framesShots;
        private readonly ushort countFrame;
        private readonly ushort countShot;
        private readonly List<Player> players;
        public ushort NumberParty { get; set; }


        internal Party(ushort countFrame, ushort countShot, List<Player> players, ushort numberParty)
        {
            this.countFrame = countFrame;
            this.countShot = countShot;
            this.players = players;
            NumberParty = numberParty;
            framesShots = new Dictionary<Frame, List<Shot>>();
        }

        internal Dictionary<Frame, List<Shot>> StartParty()
        {
            for (ushort i = 1; i <= countFrame; i++)
            {
                foreach (var frame in players.Select(player => new Frame(countShot, player) { Number = i }))
                {
                    frame.DoShots();
                    framesShots.Add(frame, frame.shots);
                }
            }
            return framesShots;
        }
    }
}