namespace NFSRaider.Hash
{
    public class VltBin : HashFactory
    {
        public override bool IsHash64 => false;

        public override ulong Hash(string stringToHash)
        {
            return Hash32(stringToHash);
        }

        public static uint Hash32(string stringToHash)
        {
            var binHashString = "0x" + Bin.Hash32(stringToHash).ToString("x8");
            var vltHash = Vlt.Hash32(binHashString);

            return vltHash;
        }
    }
}
