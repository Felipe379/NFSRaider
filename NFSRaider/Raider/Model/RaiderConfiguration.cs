namespace NFSRaider.Raider.Model
{
    public class RaiderConfiguration
    {
        public string Prefixes { get; set; }
        public string Suffixes { get; set; }
        public string WordsBetweenVariations { get; set; }
        public string Variations { get; set; }
        public string LoadedFromText { get; set; }
        public decimal? MinVariations { get; set; }
        public decimal? MaxVariations { get; set; }
        public decimal? ProcessorsCount { get; set; }
        public bool? WithRepetition { get; set; }
        public int? NumericBase { get; set; }
        public int? HashType { get; set; }
        public int? Endianess { get; set; }
    }
}
