using System;
using System.Text;

namespace NFSRaider.Hash
{
    public class Vlt : HashFactory
    {
        public override bool IsHash64 => false;

        public override ulong Hash(string stringToHash)
        {
            return Hash32(stringToHash);
        }

        public static uint Hash32(string str)
        {
            var arr = Encoding.ASCII.GetBytes(str);
            uint a = 0x9E3779B9;
            uint b = 0x9E3779B9;
            uint c = 0xABCDEF00;
            int v1 = 0;
            int v2 = arr.Length;

            while (v2 >= 12)
            {
                a += BitConverter.ToUInt32(arr, v1);
                b += BitConverter.ToUInt32(arr, v1 + 4);
                c += BitConverter.ToUInt32(arr, v1 + 8);
                Mix32_1(ref a, ref b, ref c);
                v1 += 12;
                v2 -= 12;
            }

            c += (uint)arr.Length;

            switch (v2)
            {
                case 11:
                    c += (uint)arr[10 + v1] << 24;
                    goto case 10;
                case 10:
                    c += (uint)arr[9 + v1] << 16;
                    goto case 9;
                case 9:
                    c += (uint)arr[8 + v1] << 8;
                    goto case 8;
                case 8:
                    b += (uint)arr[7 + v1] << 24;
                    goto case 7;
                case 7:
                    b += (uint)arr[6 + v1] << 16;
                    goto case 6;
                case 6:
                    b += (uint)arr[5 + v1] << 8;
                    goto case 5;
                case 5:
                    b += arr[4 + v1];
                    goto case 4;
                case 4:
                    a += (uint)arr[3 + v1] << 24;
                    goto case 3;
                case 3:
                    a += (uint)arr[2 + v1] << 16;
                    goto case 2;
                case 2:
                    a += (uint)arr[1 + v1] << 8;
                    goto case 1;
                case 1:
                    a += arr[v1];
                    break;
                default:
                    break;
            }

            return Mix32_2(a, b, c);
        }

        private static void Mix32_1(ref uint a, ref uint b, ref uint c)
        {
            a = c >> 13 ^ (a - b - c);
            b = a << 8 ^ (b - c - a);
            c = b >> 13 ^ (c - a - b);
            a = c >> 12 ^ (a - b - c);
            b = a << 16 ^ (b - c - a);
            c = b >> 5 ^ (c - a - b);
            a = c >> 3 ^ (a - b - c);
            b = a << 10 ^ (b - c - a);
            c = b >> 15 ^ (c - a - b);
        }

        private static uint Mix32_2(uint a, uint b, uint c)
        {
            a = c >> 13 ^ (a - b - c);
            b = a << 8 ^ (b - c - a);
            c = b >> 13 ^ (c - a - b);
            a = c >> 12 ^ (a - b - c);
            b = a << 16 ^ (b - c - a);
            c = b >> 5 ^ (c - a - b);
            a = c >> 3 ^ (a - b - c);
            b = a << 10 ^ (b - c - a);
            return b >> 15 ^ (c - a - b);
        }
    }
}
