//start
using System.Text;
using System.Linq;
using System;
﻿
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Certify
{
    public class Program
    {
        public static void FileExecute(string commandName, Dictionary<string, string> parsedArgs)
        {

            var file = parsedArgs[new string("/bhgsvyr".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray())];

            var realStdOut = Console.Out;
            var realStdErr = Console.Error;

            using (var writer = new StreamWriter(file, false))
            {
                writer.AutoFlush = true;
                Console.SetOut(writer);
                Console.SetError(writer);

                MainExecute(commandName, parsedArgs);

                Console.Out.Flush();
                Console.Error.Flush();
            }
            Console.SetOut(realStdOut);
            Console.SetError(realStdErr);
        }

        public static void MainExecute(string commandName, Dictionary<string, string> parsedArgs)
        {
            var sw = new Stopwatch();
            sw.Start();

            if(!(parsedArgs.ContainsKey(new string("/dhvrg".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray())) || parsedArgs.ContainsKey("/q") || parsedArgs.ContainsKey(new string("/wfba".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()))))
                Info.ShowLogo();

            parsedArgs.Remove("/q");
            parsedArgs.Remove(new string("/dhvrg".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));

            try
            {
                var commandFound = new CommandCollection().ExecuteCommand(commandName, parsedArgs);

                if (commandFound == false)
                    Info.ShowUsage();
            }
            catch (Exception e)
            {
                Console.WriteLine(new string("\\e\a[!] Haunaqyrq Pregvsl rkprcgvba:\\e\a".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
                Console.WriteLine(e);
            }

            sw.Stop();
            if(!parsedArgs.ContainsKey(new string("/wfba".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray())))
                Console.WriteLine(new string("\\e\a\\e\aPregvsl pbzcyrgrq va ".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()) + sw.Elapsed);
        }

        public static string MainString(string command)
        {

            var args = command.Split();

            var parsed = ArgumentParser.Parse(args);
            if (parsed.ParsedOk == false)
            {
                Info.ShowLogo();
                Info.ShowUsage();
                return new string("Reebe cnefvat nethzragf: ${pbzznaq}".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray());
            }

            var commandName = args.Length != 0 ? args[0] : "";

            var realStdOut = Console.Out;
            var realStdErr = Console.Error;
            TextWriter stdOutWriter = new StringWriter();
            TextWriter stdErrWriter = new StringWriter();
            Console.SetOut(stdOutWriter);
            Console.SetError(stdErrWriter);

            MainExecute(commandName, parsed.Arguments);

            Console.Out.Flush();
            Console.Error.Flush();
            Console.SetOut(realStdOut);
            Console.SetError(realStdErr);

            var output = "";
            output += stdOutWriter.ToString();
            output += stdErrWriter.ToString();

            return output;
        }

        public static void Main(string[] args)
        {
            try
            {
                var parsed = ArgumentParser.Parse(args);
                if (parsed.ParsedOk == false)
                {
                    Info.ShowLogo();
                    Info.ShowUsage();
                    return;
                }

                var commandName = args.Length != 0 ? args[0] : "";

                if (parsed.Arguments.ContainsKey(new string("/bhgsvyr".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray())))
                {
                    FileExecute(commandName, parsed.Arguments);
                }
                else
                {
                    MainExecute(commandName, parsed.Arguments);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(new string("\\e\a[!] Haunaqyrq Pregvsl rkprcgvba:\\e\a".Select(xAZ => (xAZ >= 'a' && xAZ <= 'z') ? (char)((xAZ - 'a' + 13) % 26 + 'a') : ((xAZ >= 'A' && xAZ <= 'Z') ? (char)((xAZ - 'A' + 13) % 26 + 'A') : xAZ)).ToArray()));
                Console.WriteLine(e);
            }
        }
    }
}