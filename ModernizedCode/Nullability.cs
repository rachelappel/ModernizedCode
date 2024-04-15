public class Nullability
{
    /*public void attemptNullPrint()
    {
        string s = GetValue();
        Console.WriteLine($"Length of '{s}': {s.Length}");
    }*/

    public void attemptNullPrintWithGuard()
    {
        string s = GetValue();
        Console.WriteLine(s != null
            ? $"Length of '{s}': {s.Length}"
            : "String is null.");
    }

    private string GetValue()
    {
        return null;
    }
}
