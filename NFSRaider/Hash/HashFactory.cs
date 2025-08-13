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
            return hashType switch
            {
                HashType.Bin => new Bin(),
                HashType.Vlt => new Vlt(),
                //HashType.Vlt64 => throw new NotImplementedException(),
                HashType.VltBin => new VltBin(),
                HashType.VltVlt => new VltVlt(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
