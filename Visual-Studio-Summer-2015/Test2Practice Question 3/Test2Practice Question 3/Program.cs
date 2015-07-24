﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Practice_Question_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public class RecursiveFileProcessor
        {
            public static void Main(string[] args)
            {
                foreach (string path in args)
                {
                    if (File.Exists(path))
                    {
                        // This path is a file
                        ProcessFile(path);
                    }
                    else if (Directory.Exists(path))
                    {
                        // This path is a directory
                        ProcessDirectory(path);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", path);
                    }
                }
            }

            // Process all files in the directory passed in, recurse on any directories
            // that are found, and process the files they contain.
            public static void ProcessDirectory(string targetDirectory)
            {
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                    ProcessFile(fileName);

                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                    ProcessDirectory(subdirectory);
            }

            // Insert logic for processing found files here.
            public static void ProcessFile(string path)
            {
                Console.WriteLine("Processed file '{0}'.", path);
            }
        }
    }
}