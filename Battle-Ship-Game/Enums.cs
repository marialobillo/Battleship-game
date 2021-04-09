using System;

namespace Battle_Ship_Game
{
    public enum SpotStatus
    {
        Empty = 0,
        Ship = 1,
        Miss = 2,
        Hit = 3,
        Sunk = 4
    }

    public enum ShotStatus
    {
        InValid = 0,
        Valid = 1,
        Unique = 2,

        Miss = 3,

        Hit = 4,

        Sunk = 5
    }
}