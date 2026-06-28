using System.Collections.Generic;

namespace NFSRaider.Case
{
    public class UpperCase : CaseFactory
    {
        public override IEnumerable<string> ChangeCase(string value)
        {
            yield return value.ToUpperInvariant();
        }
    }
}
