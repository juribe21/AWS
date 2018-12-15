using SharpRaven;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ravenClient = new RavenClient("https://6b8c9555cd934ad494fc589345ef7317@sentry.io/1262978");
            Process thisProc = Process.GetCurrentProcess();
            if(ProcessOpen())
            {
                Console.WriteLine(ServiceStatus.AppStart + " Open");
            }
            else
            {
                Console.WriteLine(ServiceStatus.AWS_Done + " Can continue");
            }

            Console.ReadKey();

        }

        private static bool ProcessOpen()
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Equals("git-bassh")) //AllListingsReport
                {
                    Console.WriteLine(clsProcess.ProcessName);
                    return true; 
                }

            }
            return false;
        }
    }
}
