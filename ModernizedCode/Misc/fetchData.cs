namespace ModernizedCode;

public class DB
{
    public class Country
    {
        public string Name { get; set; }
    }
    
    public class Database
    {
        public string Name { get; set; }
        public async Task<List<Country>> fetchCountryData()
        {
            await Task.Delay(2000); 
            return new List<Country>();
        }
       
    }
}