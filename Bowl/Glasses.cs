using System.Collections.Generic;
using System.Linq;

namespace Bowl
{
    internal static class Glasses
    {
        public static void Calc(Dictionary<Frame, List<Shot>> framesShots, IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                var message = "";
                var countGlasses = 0;
                foreach (var frame in framesShots.Select(framesShot => framesShot.Key))
                {
                    var frameShots = frame.shots.Where(x => x.Player.Number == player.Number);
                    foreach (var shot in frameShots)
                    {
                        countGlasses += shot.CountSkittles;
                        message += "\r\n № frame " + frame.Number + " " + shot.Player.Name + " № shot" + shot.NumberShot + " выбито " +
                                  shot.CountSkittles + ". Общее кол-во: " + countGlasses;
                        if (!shot.IsStrike && !shot.IsSpare) continue;
                        var present = GetCountGlasses(framesShots, player, frame.Number, shot.IsStrike,
                            shot.IsSpare);
                        countGlasses += present;
                        if (shot.IsStrike) message += ("\r\n  + за Strike = " + present + ". Общее кол-во = " + countGlasses);
                        if (shot.IsSpare) message += ("\r\n  + за Spare = " + present + ". Общее кол-во = " + countGlasses);
                    }
                   
                }

                message += message + "\r\n";
                Print.Write("Игрок " + player.Name + ". Кол-во очков: " + countGlasses + ". " + message);
            }
        }

        // return count glasses
        private static ushort GetCountGlasses(Dictionary<Frame, List<Shot>> framesShots, Player player,
            ushort frameNumber, bool isStrike, bool isSpare)
        {
            ushort countLocal = 0;
            var countShot = 0;

            foreach (var frameNext in framesShots.Select(framesShot => framesShot.Key)
                .Where(x => x.Number > frameNumber))
            {

                var frameShotsNext = frameNext.shots.Where(x => x.Player.Equals(player));
                foreach (var shotNext in frameShotsNext)
                {
                    countLocal = (ushort)(countLocal + shotNext.localWhatSkittles.Count);
                    if (isSpare)
                        return countLocal;

                    if (isStrike && countShot == 1)
                        return countLocal;

                    countShot++;
                }
            }

            return countLocal;
        }
    }
}