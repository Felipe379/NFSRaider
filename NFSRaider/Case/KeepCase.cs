using System.Collections.Generic;

namespace NFSRaider.Case
{
    public class KeepCase : CaseFactory
    {
        public override IEnumerable<string> ChangeCase(string value)
        {
            yield return value;
        }
    }
}
