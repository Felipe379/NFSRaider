using NFSRaider.Enums;

namespace NFSRaider.Case
{
    public abstract class CaseFactory
    {
        public abstract string[] ChangeCase(string value);

        public static CaseFactory GetCaseType(CaseOptions caseOption)
        {
            switch (caseOption)
            {
                case CaseOptions.Lowercase:
                    return new LowerCase();
                case CaseOptions.Uppercase:
                    return new UpperCase();
                case CaseOptions.All:
                    return new AllCase();
                default:
                    return new KeepCase();
            }
        }
    }
}
