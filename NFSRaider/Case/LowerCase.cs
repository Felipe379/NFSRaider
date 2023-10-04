namespace NFSRaider.Case
{
    public class LowerCase : CaseFactory
    {
        public override string[] ChangeCase(string value)
        {
            return new[] { value.ToLowerInvariant() };
        }
    }
}
