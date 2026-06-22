using NFSRaider.Enums;
using System;

namespace NFSRaider.Hash
{
    public abstract class HashFactory
    {
        public abstract bool IsHash64 { get; }

        public abstract ulong Hash(string stringToHash);

        public static HashFactory GetHashType(HashType hashType)
        {
            return hashType switch
            {
                HashType.Bin => new Bin(),
                HashType.Vlt => new Vlt(),
                HashType.Vlt64 => new Vlt64(),
                HashType.VltBin => new VltBin(),
                HashType.VltVlt => new VltVlt(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
