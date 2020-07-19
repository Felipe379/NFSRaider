using NFSRaider.Enum;
using System;

namespace NFSRaider.Hash
{
    public abstract class HashFactory
    {
        public abstract uint Hash(string StringToHash);
        public abstract UInt64 Hash64(string StringToHash);

        public static HashFactory GetHashType(HashType hashType)
        {
            switch (hashType)
            {
                case HashType.BIN:
                    return new Bin();
                case HashType.VLT:
                    return new Vlt();
                case HashType.VLT64:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
