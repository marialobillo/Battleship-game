using System;

namespace Battle_Ship_Game
{
    public class BoardGame
    {
        public int SpotX { get; set; }
        public int SpotY { get; set; }

        public SpotStatus Status { get; set; } = SpotStatus.Empty;
    }
}