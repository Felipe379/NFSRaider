using NFSRaider.Enums;
using System;

namespace NFSRaider.Hash
{
    public abstract class HashFactory
    {
        public abstract uint Hash(string stringToHash);
        public abstract ulong Hash64(string stringToHash);

        public static HashFactory GetHashType(HashType hashType)
        {
            switch (hashType)
            {
                case HashType.Bin:
                    return new Bin();
                case HashType.Vlt:
                    return new Vlt();
                //case HashType.Vlt64:
                //    throw new NotImplementedException();
                case HashType.VltBin:
                    return new VltBin();
                case HashType.VltVlt:
                    return new VltVlt();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
