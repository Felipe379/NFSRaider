using System;
using System.Text;

namespace NFSRaider.Hash
{
    public class Bin : HashFactory
    {
        public override uint Hash(string StringToHash)
        {
            byte[] ByteArrayToHash = Encoding.GetEncoding(1252).GetBytes(StringToHash);

            return Hash(ByteArrayToHash);
        }

        public override UInt64 Hash64(string StringToHash)
        {
            throw new NotImplementedException();
        }

        private uint Hash(byte[] ByteArrayToHash)
        {
            int v1 = 0;
            int i = -1;

            while (v1 < ByteArrayToHash.Length)
            {
                i = ByteArrayToHash[v1] + 33 * i;
                v1++;
            }

            return (uint)i;
        }
    }
}
