// ReSharper disable MemberCanBePrivate.Global


namespace ModernizedCode;

public class Data 
{
    public Data(string firstName, string lastName) 
    {
        FullName( firstName,lastName);
        FirstName = firstName;
        LastName = lastName;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName(string first, string last) 
    {
        return $"{first} {last}";
    }
}