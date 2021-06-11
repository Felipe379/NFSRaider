using NFSRaider.Hash;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Raider
{
    public class Hash
    {
        private HashSet<string> Strings { get; set; }
        private HashFactory HashFactory { get; set; }
        private NFSRaiderForm Sender { get; set; }

        public Hash(NFSRaiderForm sender, HashFactory hashFactory)
        {
            Sender = sender;
            HashFactory = hashFactory;
        }

        public void SplitStrings(string txtStrings)
        {
            var strings = txtStrings.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Strings = new HashSet<string>(strings);
        }

        public void BruteForceThread()
        {
            var results = new List<RaiderResult>();

            foreach (var item in Strings)
            {
                results.Add(new RaiderResult { Hash = HashFactory.Hash(item), Value = item, IsKnown = true });
            }

            if (results.Any())
            {
                Sender.UpdateFormDuringBruteforce(results);
            }
        }
    }
}
