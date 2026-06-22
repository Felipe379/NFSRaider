using System.Text;

namespace NFSRaider.Hash
{
    public class Bin : HashFactory
    {
        public override bool IsHash64 => false;

        public override ulong Hash(string stringToHash)
        {
            return Hash32(stringToHash);
        }

        public static uint Hash32(string stringToHash)
        {
            var byteArrayToHash = Encoding.GetEncoding("ISO-8859-1").GetBytes(stringToHash);

            return HashPrefix(byteArrayToHash);
        }

        private static uint HashPrefix(byte[] byteArrayToHash, uint prefix = uint.MaxValue)
        {
            var len = 0;

            while (len < byteArrayToHash.Length)
            {
                prefix *= 0x21;
                prefix += byteArrayToHash[len++];
            }

            return prefix;
        }
    }
}
