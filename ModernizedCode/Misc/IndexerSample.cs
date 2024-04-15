namespace ModernizedCode
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
    }

    public class CustomerCollection
    {
        // Declare an array to store the data elements.
        private Customer[] arr = new Customer[100];

        // Define the indexer to allow client code to use [] notation.
        public Customer this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    public class AcmeProgram
    {
        public void RunProgram()
        {
            var customers = new CustomerCollection();
            customers[0] = new Customer {Id=1,Name = "Ada"};
            Console.WriteLine(customers[0].Name);
        }
    }
    
    
    /*
     * next sample
     */

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

    class RunProgram
    {
        static void RunIt()
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);
        }
    }
}


