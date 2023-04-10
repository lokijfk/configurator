using System;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using ConfiguratorSH;
using System.Runtime;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;

namespace Wraper
{
    internal class Program
    {
        //private TextWriter COut = Console.Out;
        //private TextWriter CError = Console.Error;
        // main musi być statyczny a więc i reszta jest statyczna, czyli pola i metody
        private static IniFile Settings;
        // private static string[] param;
        //https://github.com/Kapiainen/Advanced-Papyrus

        static void Main(string[] args)
        {

            if (File.Exists(@"settings.ini"))
            {
                //Console.WriteLine("znaleziono plik ini");
                Settings = new IniFile(@"settings.ini");
                 run(parser(args, true));
            }
            else
            {
                run(parser(args));

            }
        }

        private static string parser(string[] args,bool settings = false)
        {
            string ret = "",temp ="";
            string poz = "", output = "", import = "", flags = "", file ="";
            if (!settings || (Array.IndexOf(args, "-ig") >= 0))
            {
                foreach (string arg in args)
                {   
                    if(!arg.Equals("-ig"))
                    ret += " " + arg;
                }
            }
            else
            {
                // -ig ma mbyć jako ignore ini -- dodane już tylko sprawdzić czy działa
                //tu trzeba sparsować dane z wejścia i pliku ini - obiektu settings
                // bo zawsze jest podawany plik do kompilacji a więc 1 zawsze powinien być
                if(args.Length > 1) {
                    //tu sprawdzamy co to za parametry dodatkowe i je ładujemy
                    foreach(string arg in args)
                    {   // tu zapomniałem poprobić odcięcia, trzeba odciąć wartości od parametrów
                        //może tu nie urzywać za każdym razem indexof tylko substring i sprawdzać co mamy
                        // bo to tutaj jak będze w środku to też przejdzie !!!!
                        temp = arg.Trim().Substring(0, 2);
                        if(temp.Equals("-o"))
                        {
                            output = arg;
                        }
                        else if(temp.Equals("-i"))
                        {
                            import += arg;
                        }
                        else if (temp.Equals("-f"))
                        {
                            flags = arg;
                        }
                        else if (!arg.StartsWith("-")&&(arg.IndexOf(".psc") >= 0))
                        {
                            file += arg;
                        }
                        else
                        {
                            poz += arg;
                        }
                    }   
                }

                if(flags.Equals(""))
                {
                    flags = Settings.Read("Skyrim", "FileFLT");
                }
                if (output.Equals(""))
                {
                    output = Settings.Read("Skyrim","Output");
                }
                Dictionary<string, string> DirImport = Settings.GetSection("Import");
                foreach (string val in DirImport.Values)
                {
                    if(import.Length > 0)
                    {
                        import += ";";
                    }
                    import += val;
                }
                ret = file + flags + output + import + poz;
            }
            return ret;
        }

         private static void run(string param)
        {
            Console.WriteLine(param);
        }

         /*
         * PapyrusCompiler <object or folder> [<arguments>]

          object     Specifies the object to compile. (-all is not specified)
          folder     Specifies the folder to compile. (-all is specified)
          arguments  One or more of the following:
           -debug|d
            Turns on compiler debugging, outputting dev information to the screen.
           -optimize|op
            Turns on optimization of scripts.
           -output|o=<string>
            Sets the compiler's output directory.
           -import|i=<string>
            Sets the compiler's import directories, separated by semicolons.
           -flags|f=<string>
            Sets the file to use for user-defined flags.
           -all|a
            Invokes the compiler against all psc files in the specified directory
            (interprets object as the folder).
           -quiet|q
            Does not report progress or success (only failures).
           -noasm
            Does not generate an assembly file and does not run the assembler.
           -keepasm
            Keeps the assembly file after running the assembler.
           -asmonly
            Generates an assembly file but does not run the assembler.
           -?
            Prints usage information.
            */
        private void StartProc()
        {
            /*
            string PapyrusCompilerEXE = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\" + PapyrusCompilerName;
            if (!File.Exists(PapyrusCompilerEXE))
            {
                twError.WriteLine("Advanced Papyrus: ERROR! Unable to find \"" + PapyrusCompilerName + "\" in \"" + PapyrusCompilerEXE.Substring(0, PapyrusCompilerEXE.LastIndexOf("\\") + 1) + "\"!");
                return;
            }
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = PapyrusCompilerEXE,
                    //Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            proc.EnableRaisingEvents = true;
            proc.OutputDataReceived += new DataReceivedEventHandler(OutputWriter);
            proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorWriter);
            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();
            proc.WaitForExit();
            */

        // Prepare the process to run
        ProcessStartInfo start = new ProcessStartInfo("configurator2.exe");
            // Enter in the command line arguments, everything you would enter after the executable name itself
            //start.Arguments = arguments;
            // Enter the executable to run, including the complete path
            //string path = "c:\\Users\\swlas\\OneDrive\\Dokumenty\\Visual Studio 2022\\configurator\\configurator\\bin\\Debug\\net6.0-windows\\";
            start.FileName = "ConfiguratorSH.exe";
            // Do you want to show a console window?
            //start.WindowStyle = ProcessWindowStyle.Hidden;
            start.WindowStyle = ProcessWindowStyle.Normal;
            //start.CreateNoWindow = true;

            //brak obsługi wyjątku !!!
            Process.Start(start);
            /*
             * to kod ze strony wywołanie z parametrami
             ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
             startInfo.WindowStyle = ProcessWindowStyle.Minimized;
             Process.Start(startInfo);
             startInfo.Arguments = "www.northwindtraders.com";
             Process.Start(startInfo);
            */
            // Run the external process & wait for it to finish
            /*
            int exitCode;
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
                Console.WriteLine(" exit: "+exitCode);
            }
            */
        }
    }
}
