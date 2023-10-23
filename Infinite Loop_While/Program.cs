namespace Infinite_Loop_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            while (comand != "End") {
             Console.WriteLine("Executing: " + comand);
                comand = Console.ReadLine();
            }
        }
    }
}