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


        public static void StartApplication()
        {
            Process process = null;
            try
            {
                process = Process.Start(@"C:\Program Files\Git\git-bash.exe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
