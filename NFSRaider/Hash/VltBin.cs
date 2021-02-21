using System;

namespace NFSRaider.Hash
{
    public class VltBin : HashFactory
    {
        public override uint Hash(string stringToHash)
        {
            var binHashString = "0x" + new Bin().Hash(stringToHash).ToString("x8");
            var vltHash = new Vlt().Hash(binHashString);

            return vltHash;
        }

        public override ulong Hash64(string stringToHash)
        {
            throw new NotImplementedException();
        }
    }
}
