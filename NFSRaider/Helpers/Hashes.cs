using System;
using System.Buffers.Binary;
using System.Text.RegularExpressions;

namespace NFSRaider.Helpers
{
    public static class Hashes
    {
        public static bool IsValidHash(string hash, bool isHash64, int numericBase)
        {
            return (isHash64 && IsHash64(hash, numericBase)) ||
                   (!isHash64 && IsHash32(hash, numericBase));
        }

        public static ulong Reverse(string hash, bool isHash64, int numericBase)
        {
            return isHash64
                ? BinaryPrimitives.ReverseEndianness(Convert.ToUInt64(hash, numericBase))
                : BinaryPrimitives.ReverseEndianness(Convert.ToUInt32(hash, numericBase));
        }

        public static ulong Reverse(ulong hash, bool isHash64)
        {
            return isHash64
                ? BinaryPrimitives.ReverseEndianness(Convert.ToUInt64(hash))
                : BinaryPrimitives.ReverseEndianness(Convert.ToUInt32(hash));
        }

        public static bool IsHash32(string hash, int numericBase)
        {
            switch (numericBase)
            {
                case 16:
                    return new Regex(@"^(((0x)|(0X)){0,1}[0-9a-fA-F]{1,8})$").Match(hash).Success;
                case 10:
                    return new Regex(@"^(((0d)|(0D)){0,1}[0-9]{1,10})$").Match(hash).Success;
                case 8:
                    return new Regex(@"^(((0o)|(0O)){0,1}[0-7]{1,11})$").Match(hash).Success;
                case 2:
                    return new Regex(@"^(((0b)|(0B)){0,1}[0-1]{1,32})$").Match(hash).Success;
                default:
                    throw new NotImplementedException();
            }
        }

        public static bool IsHash64(string hash, int numericBase)
        {
            switch (numericBase)
            {
                case 16:
                    return new Regex(@"^(((0x)|(0X)){0,1}[0-9a-fA-F]{9,16})$").Match(hash).Success;
                case 10:
                    return new Regex(@"^(((0d)|(0D)){0,1}[0-9]{11,20})$").Match(hash).Success;
                case 8:
                    return new Regex(@"^(((0o)|(0O)){0,1}[0-7]{12,22})$").Match(hash).Success;
                case 2:
                    return new Regex(@"^(((0b)|(0B)){0,1}[0-1]{33,64})$").Match(hash).Success;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
