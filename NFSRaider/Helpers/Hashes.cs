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

        public static bool IsHash(string hash)
        {
            return new Regex(@"^(((0x)|(0X)){0,1}[0-9a-fA-F]{1,8})$").Match(hash).Success;
        }

        public static bool IsHash64(string hash)
        {
            return new Regex(@"^(((0x)|(0X)){0,1}[0-9a-fA-F]{1,16})$").Match(hash).Success;
        }
    }
}
