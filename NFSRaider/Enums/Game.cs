using System;

namespace NFSRaider.Enums
{
    [Flags]
    public enum Game
    {
        None = 0,
        HotPursuit2 = 1 << 0,  // 1
        Underground1 = 1 << 1,  // 2
        Underground2 = 1 << 2,  // 4
        MostWanted = 1 << 3,  // 8
        Carbon = 1 << 4,  // 16
        ProStreet = 1 << 5,  // 32
        Undercover = 1 << 6,  // 64
        UndercoverCG = 1 << 7,  // 128
        Nitro = 1 << 8,  // 256
        World = 1 << 9,  // 512
        TheRun = 1 << 10  // 1024
    }
}
