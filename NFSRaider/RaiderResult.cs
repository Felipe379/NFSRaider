namespace NFSRaider
{
    public class RaiderResult
    {
        public ulong Hash { get; set; }
        public string Value { get; set; }
        public bool IsKnown { get; set; }
        public bool IsHash64 { get; set; }
    }
}
