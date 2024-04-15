namespace ModernizedCode.Records
{
    public record Person()
    {
        public int Id { get; set; } = 1;
        public string FirstName { get; set; } = "Margaret";
        public string LastName { get; set; } = "Hamilton";
        public int Age { get; set; }
        public Pet Pet { get; set; } = new(1, "Fluffy", "Hedgehog");
    }

    public record Pet(int Id, string Name, string Type);
    
    public class PersonLocator
    {
        public void Locate()
        {
            var firstPerson = new Person();
            var nextPerson = new Person
            {
                FirstName = "Margaret",
                LastName = "Hamilton"
            };

            Console.Clear();
            
            Console.WriteLine($"The first person's last name is {firstPerson.LastName}");
            Console.WriteLine($"The next person's last name is {nextPerson.LastName}");

            Console.WriteLine(firstPerson == nextPerson ? 
                "Yes, these two people are the same!" : 
                "No, these two are not the same!");
        }
    }
}