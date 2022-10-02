using NFSRaider.Enums;
using System.Collections.Generic;

namespace NFSRaider.Helpers
{
    public static class Numeric
    {
        public static Dictionary<NumericBase, int> Bases { get; set; } = new Dictionary<NumericBase, int>
        {
            { NumericBase.Hexadecimal, 16 },
            { NumericBase.Decimal, 10 },
            { NumericBase.Octal, 8 },
            { NumericBase.Binary, 2 },
        };
    }
}
