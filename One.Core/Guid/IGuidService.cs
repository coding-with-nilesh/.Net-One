namespace One.Core.Guid
{
    public interface IGuidService
    {
        string GetGuid();
        string GetShortGuid();
        int GenerateCode(int length);
    }
}
