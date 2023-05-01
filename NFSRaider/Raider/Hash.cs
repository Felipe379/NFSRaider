using NFSRaider.Hash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NFSRaider.Raider
{
    public class Hash
    {
        private readonly HashFactory _hashFactory;
        private readonly NFSRaiderForm _sender;

        public HashSet<string> Strings { get; set; }

        public Hash(NFSRaiderForm sender, HashFactory hashFactory)
        {
            _sender = sender;
            _hashFactory = hashFactory;
        }

        public void SplitStrings(string txtStrings)
        {
            var strings = txtStrings.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Strings = new HashSet<string>(strings);

            _sender.GenericMessageBoxDuringBruteForce("Info", $"{Strings.Count} unique strings identified");
        }

        public void HashStrings(CancellationToken cancellationToken)
        {
            var results = new List<RaiderResult>();

            foreach (var item in Strings)
            {
                cancellationToken.ThrowIfCancellationRequested();
                results.Add(new RaiderResult { Hash = _hashFactory.Hash(item), Value = item, IsKnown = true });
            }

            if (results.Any())
            {
                _sender.UpdateFormDuringBruteforce(results);
            }
        }
    }
}
