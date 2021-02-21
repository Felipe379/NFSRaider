namespace NFSRaider.Case
{
    public class UpperCase : CaseFactory
    {
        public override string ChangeCase(string value)
        {
            return value.ToUpperInvariant();
        }
    }
}
