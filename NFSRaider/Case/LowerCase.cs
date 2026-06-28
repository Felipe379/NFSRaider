using System.Collections.Generic;

namespace NFSRaider.Case
{
    public class LowerCase : CaseFactory
    {
        public override IEnumerable<string> ChangeCase(string value)
        {
            yield return value.ToLowerInvariant();
        }
    }
}
