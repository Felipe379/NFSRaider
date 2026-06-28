using System.Collections.Generic;

namespace NFSRaider.Case
{
    public class AllCase : CaseFactory
    {
        public override IEnumerable<string> ChangeCase(string value)
        {
            yield return value;

            var low = value.ToLowerInvariant();
            if (low != value)
            {
                yield return low;
            }

            var up = value.ToUpperInvariant();
            if (up != value && up != low)
            {
                yield return up;
            }
        }
    }
}
