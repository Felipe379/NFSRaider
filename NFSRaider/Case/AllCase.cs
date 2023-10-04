using System.Collections.Generic;
using System.Linq;

namespace NFSRaider.Case
{
    public class AllCase : CaseFactory
    {
        public override string[] ChangeCase(string value)
        {
            return new[] { value, value.ToLowerInvariant(), value.ToUpperInvariant() };
        }
    }
}
