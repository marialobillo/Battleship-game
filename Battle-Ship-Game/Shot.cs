using System;

namespace Battle_Ship_Game
{
    public class Shot
    {
        public string SpotX { get; set; }
        public int SpotY { get; set; }
        public SpotStatus Status { get; set; } = SpotStatus.Empty;
    }
}