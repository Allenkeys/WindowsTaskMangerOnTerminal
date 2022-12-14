namespace WindowsTaskMangerOnTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllProcesses.EnumerateProcesses();
            AllProcesses.StartApplication();
        }
    }
}