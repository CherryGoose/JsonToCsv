using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsontoCsv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathIn = "";
            string pathOut = "";
            string separator = ";";
            Encoding en = Encoding.Default;
            bool inPathExists=false;    
            bool outPathExists=false;   
            bool quit=false;

            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "-q")
                    {
                        quit = true;
                    }
                    if (args[i] == "-i")
                    {
                        if (i + 1 <= args.Length - 1)
                        {
                            if (Validator.ValidateFile(args[i + 1]))
                            {
                                pathIn = Path.GetFullPath(args[i + 1]);
                                inPathExists = true;
                            }
                            else 
                            { 
                              StandardMessages.ShowInvalidFileMessage();
                              StandardMessages.ShowEndMessage();
                            }
                        }
                        else
                        {
                            StandardMessages.ShowMissingArgumentMessage();
                            StandardMessages.ShowEndMessage();
                        }
                    }
                    if (args[i] == "-o")
                    {
                        if (i + 1 <= args.Length - 1)
                        {
                            if (Validator.ValidateFile(args[i + 1]))
                            {
                                pathOut = Path.GetFullPath(args[i + 1]);
                                outPathExists = true;
                            }
                            else
                            {
                                StandardMessages.ShowInvalidFileMessage();
                                pathOut = Environment.CurrentDirectory;
                            }
                        }
                        else
                        {
                            StandardMessages.ShowMissingArgumentMessage();
                            StandardMessages.ShowEndMessage();
                        }
                    }
                    if (args[i] == "-e")
                    {
                        if (i + 1 <= args.Length - 1)
                        {
                            try
                            {
                                en = Encoding.GetEncoding(args[i + 1]);
                            }
                            catch { 
                                Exception ex;
                                StandardMessages.ShowInvalidArgumentMessage();
                                StandardMessages.ShowEndMessage();
                            }
                        }
                        else
                        {
                            StandardMessages.ShowMissingArgumentMessage();
                            StandardMessages.ShowEndMessage();
                        }
                    }
                    if (args[i] == "-s")
                    {
                        if (i + 1 <= args.Length - 1)
                        {
                            if (args[i + 1].Length == 1)
                            {
                                separator = args[i + 1];
                            }
                            else
                            {
                                StandardMessages.ShowInvalidArgumentMessage();
                                StandardMessages.ShowEndMessage();
                            }
                        }
                        else
                        {
                            StandardMessages.ShowMissingArgumentMessage();
                            StandardMessages.ShowEndMessage();
                        }
                    }
               }
           }

            if (inPathExists && outPathExists)
            {
                IFileModel InFile = Factory.CreateJsonFile(pathIn, FileReader.Read(pathIn));
                IConverter converter = Factory.CreateConverter();
                string convertedData = (string)converter.Convert(InFile, separator,en);
                IFileModel outFile = Factory.CreateCsvFile(pathOut, convertedData);
                IFileWriter writer = Factory.CreateWriter();
                writer.Write(outFile);
                if (!quit)
                { StandardMessages.ShowEndMessage(); }
            }
            else if (inPathExists&& !outPathExists)
            {
                IFileModel InFile = Factory.CreateJsonFile(pathIn, FileReader.Read(pathIn));
                IConverter converter = Factory.CreateConverter();
                string convertedData = (string)converter.Convert(InFile, separator,en);
                IFileModel outFile = Factory.CreateCsvFile(pathIn, convertedData);
                IFileWriter writer = Factory.CreateWriter();
                writer.Write(outFile);
                if(!quit)
                {
                    StandardMessages.ShowEndMessage();
                }
            }
         
        }

       
    }
}
