using System;
using System.IO;

namespace Protocol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the directories to monitor
            string[] sourceDirs = new string[] { @"C:\Users\eduar\Downloads", @"C:\Users\eduar\Organized_Downloads" };

            // Get the current month and year
            DateTime now = DateTime.Now;
            string currentDate = now.ToString("MMMM_yyyy");

            // Create the log file path
            string logFilePath = Path.Combine(sourceDirs[0], currentDate + ".txt");

            FileInfo[] infoFiles;

            // Create the log file if it doesn't exist
            if (!File.Exists(logFilePath))
            {
                using FileStream fs = 
                File.Create(logFilePath);
            }

            // Open the log file for appending
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                // Loop through each directory
                foreach (string sourceDir in sourceDirs)
                {
                    // Get the downloaded files from the current directory
                    string[] files = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);
                    infoFiles = Directory.GetFiles(sourceDir);
                    // Log the downloaded files
                    foreach (string file in files)
                    {
                        if (file.CreationTime.ToString("yyyy-MM") == currentDate)
                        {
                            
                        }
                        sw.WriteLine(file);
                    }
                }

                // Write a separator between the two sets of logs
                sw.WriteLine("\n===================================\n");
            }
        }
    }
}

