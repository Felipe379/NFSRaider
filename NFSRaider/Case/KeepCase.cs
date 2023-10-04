namespace NFSRaider.Case
{
    public class KeepCase : CaseFactory
    {
        public override string[] ChangeCase(string value)
        {
            return new[] { value };
        }
    }
}
