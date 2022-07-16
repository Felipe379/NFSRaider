using System;
using System.Text;

namespace NFSRaider.Hash
{
    public class Bin : HashFactory
    {
        public override uint Hash(string stringToHash)
        {
            var ByteArrayToHash = Encoding.GetEncoding("ISO-8859-1").GetBytes(stringToHash);

            return Hash(ByteArrayToHash);
        }

        public override ulong Hash64(string stringToHash)
        {
            throw new NotImplementedException();
        }

        private uint Hash(byte[] byteArrayToHash)
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
    }
}
