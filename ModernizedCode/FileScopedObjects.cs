namespace ModernizedCode;

// public, private, internal and now file scope
file class FileScoped
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

class Useit
{
    void Usething()
    {
        FileScoped fs = new FileScoped();
    }
    
}