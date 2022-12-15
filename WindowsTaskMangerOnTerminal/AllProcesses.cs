using System.Diagnostics;
using System.Globalization;

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


        public static void StartApplication(string fileName, string arg)
        {
            Process? process = null;
            try
            {
                ProcessStartInfo startProcess = new ProcessStartInfo( fileName, arg);
                startProcess.WindowStyle = ProcessWindowStyle.Maximized;
                startProcess.Verb = "Open";
                startProcess.UseShellExecute = true;
                process = Process.Start(startProcess);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            /*var dir = Directory.GetDirectories(@"C:\");

            foreach (var item in dir)
            {
                Console.WriteLine(item);
            }*/
        }


        public static void TerminateActiveProcess(string processName)
        {
            
            try
            {
                foreach (var processes in Process.GetProcessesByName(processName))
                {
                    processes.Kill(true);
                    Console.WriteLine($"Success! {processes.ProcessName} - {processes.Id} has been terminated");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
