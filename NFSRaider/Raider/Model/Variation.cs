using Combinatorics.Collections;
using System.Collections.Generic;

namespace NFSRaider.Raider.Model
{
    public class Variation
    {
        public int MinVariations { get; set; }
        public int MaxVariations { get; set; }
        public ICollection<string> Variations { get; set; }
        public GenerateOption GenerateOption { get; set; }
    }
}
