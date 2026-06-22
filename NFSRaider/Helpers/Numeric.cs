using NFSRaider.Enums;
using System;
using System.Collections.Generic;

namespace NFSRaider.Helpers
{
    public static class Numeric
    {
        public static Dictionary<NumericBase, (int Base, int L32, int L64)> Bases { get; set; } = new Dictionary<NumericBase, (int, int, int)>
        {
            { NumericBase.Hexadecimal, (16, 8, 16) },
            { NumericBase.Decimal, (10, 10, 20) },
            { NumericBase.Octal, (8, 11, 22) },
            { NumericBase.Binary, (2, 32, 64) },
        };

        public static string ToBaseString(this ulong value, int numericBase)
        {
            return numericBase switch
            {
                10 => value.ToString(),
                16 => value.ToString("X"),
                2 => SafeConvert(value, 2),
                8 => SafeConvert(value, 8),
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            };
        }

        private static string SafeConvert(ulong value, int radix)
        {
            if (value == 0) return "0";

            Span<char> buffer = stackalloc char[64];
            int index = 64;

            while (value > 0)
            {
                ulong quotient = value / (ulong)radix;
                ulong remainder = value % (ulong)radix;
                buffer[--index] = (char)(remainder < 10 ? remainder + '0' : remainder - 10 + 'A');
                value = quotient;
            }

            return new string(buffer.Slice(index));
        }
    }
}
