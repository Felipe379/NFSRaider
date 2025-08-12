using System;
using System.Text.RegularExpressions;

namespace NFSRaider.Helpers
{
    public static class Hashes
    {
        public static int Reverse(this int value)
        {
            return (value << 24) |
                   (((value >> 16) << 24) >> 16) |
                   (((value << 16) >> 24) << 16) |
                   (value >> 24);
        }

        public static uint Reverse(this uint value)
        {
            return (value << 24) |
                   (((value >> 16) << 24) >> 16) |
                   (((value << 16) >> 24) << 16) |
                   (value >> 24);
        }

        public static bool IsHash(string hash, int numericBase)
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
                    return new Regex(@"^(((0x)|(0X)){0,1}[0-9a-fA-F]{1,16})$").Match(hash).Success;
                case 10:
                    return new Regex(@"^(((0d)|(0D)){0,1}[0-9]{1,20})$").Match(hash).Success;
                case 8:
                    return new Regex(@"^(((0o)|(0O)){0,1}[0-7]{1,22})$").Match(hash).Success;
                case 2:
                    return new Regex(@"^(((0b)|(0B)){0,1}[0-1]{1,64})$").Match(hash).Success;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
