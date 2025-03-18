namespace CSharpLearning
{
    internal class Program
    {
        public string? Salary { get; private set; } = "Not Enough";

        static void Main(string[] args)
        {
            string requirements, miracleMax = "Hello World";
            requirements = miracleMax = "It would take a miracle.";
            Console.WriteLine(requirements);
            Console.WriteLine(miracleMax);

            miracleMax = "Hello World!";
            Program program = new();
            program = new Program();
        }
    }
}
