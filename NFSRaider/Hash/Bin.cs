using System;
using System.Text;
using System.Text.Unicode;

namespace NFSRaider.Hash
{
    public class Bin : HashFactory
    {
        public override uint Hash(string stringToHash)
        {
            var byteArrayToHash = Encoding.GetEncoding("ISO-8859-1").GetBytes(stringToHash);

            return HashPrefix(byteArrayToHash);
        }

        public override ulong Hash64(string stringToHash)
        {
            throw new NotImplementedException();
        }

        private static uint Hash(byte[] byteArrayToHash)
        {
            var v1 = 0;
            var i = -1;

            while (v1 < byteArrayToHash.Length)
            {
                i = byteArrayToHash[v1] + 33 * i;
                v1++;
            }

            return (uint)i;
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
