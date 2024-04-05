using UtilityLibraries;

namespace ConsumeArtifact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Number 1 - Input: hello world");
            Console.WriteLine(StringLibrary.StartsWithUpper("hello world"));

            Console.WriteLine("Test Number 2 - Input: Good afternoon");
            Console.WriteLine(StringLibrary.StartsWithUpper("Good afternoon"));
        }
    }
}
