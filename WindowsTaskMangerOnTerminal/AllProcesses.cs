using System.Diagnostics;

namespace WindowsTaskMangerOnTerminal
{
    internal class AllProcesses
    {
        public static void EnumerateProcesses()
        {
            var allRunningProcesses = from procs in Process.GetProcesses()
                                      orderby procs.Id
                                      select procs;
            foreach (var item in allRunningProcesses)
            {
                Console.WriteLine($"Process Id:{item.Id}\nName: {item.ProcessName}\n");
                Console.WriteLine("**************************************\n");
            }
        }
    }
}
