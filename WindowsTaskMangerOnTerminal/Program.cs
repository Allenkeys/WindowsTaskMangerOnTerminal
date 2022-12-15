namespace WindowsTaskMangerOnTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AllProcesses.EnumerateProcesses();
               AllProcesses.StartApplication("git-bash", "");
            // AllProcesses.TerminateActiveProcess("slack");
            //Test.TestCase();
            //Test.Getfile(@"C:\");
        }
    }
}