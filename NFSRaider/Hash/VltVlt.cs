namespace NFSRaider.Hash
{
    public class VltVlt : HashFactory
    {
        public override bool IsHash64 => false;

        public override ulong Hash(string stringToHash)
        {
            return Hash32(stringToHash);
        }

        public static uint Hash32(string StringToHash)
        {
            var vltHashString = "0x" + Vlt.Hash32(StringToHash).ToString("x8");
            var vltHash = Vlt.Hash32(vltHashString);

            return vltHash;
        }
    }
}
