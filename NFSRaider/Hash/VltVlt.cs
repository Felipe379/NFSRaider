using System;

namespace NFSRaider.Hash
{
    public class VltVlt : HashFactory
    {
        public override uint Hash(string StringToHash)
        {
            var vlt = new Vlt();
            var vltHashString = "0x" + vlt.Hash(StringToHash).ToString("x8");
            var vltHash = vlt.Hash(vltHashString);

            return vltHash;
        }

        public override ulong Hash64(string StringToHash)
        {
            throw new NotImplementedException();
        }
    }
}
