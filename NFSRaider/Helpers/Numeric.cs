using NFSRaider.Enums;
using System.Collections.Generic;

namespace NFSRaider.Helpers
{
    public static class Numeric
    {
        public static Dictionary<NumericBase, (int Base, int Chars)> Bases { get; set; } = new Dictionary<NumericBase, (int, int)>
        {
            { NumericBase.Hexadecimal, (16, 8) },
            { NumericBase.Decimal, (10, 10) },
            { NumericBase.Octal, (8, 11) },
            { NumericBase.Binary, (2, 32) },
        };
    }
}
