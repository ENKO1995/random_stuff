using System;
using System.Collections.Generic;
using System.IO;

namespace NEO_WATCHER
{
    internal class Program
    {
        public static string sourcePath = @"C:\Users\eduar\Downloads";
        public static string destinationPath = @"C:\Users\eduar\Organized_Downloads\";

        public static List<string> AllDirs;

        public static void Main()
        {
            // Create destination directories if they don't exist
            CreateDestinationDirectories();

            Greetings();

            // Get all files in the source directory
            var files = Directory.GetFiles(sourcePath);

            // Sort and move files
            foreach (var file in files)
            {
                SortAndMoveFile(file);
            }

            Console.ReadKey();
        }

        public static void Greetings()
        {
            Console.WriteLine("Hello, please press any key to sort all files in Downloads dictionary  \n");
            Console.ReadKey();
        }

        public static void CreateDestinationDirectories()
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            // Create subdirectories for different file types
            if (!Directory.Exists(destinationPath + "PDFs"))
            {
                Directory.CreateDirectory(destinationPath + "PDFs");
            }
            if (!Directory.Exists(destinationPath + "EXEs"))
            {
                Directory.CreateDirectory(destinationPath + "EXEs");
            }
            if (!Directory.Exists(destinationPath + "Pictures"))
            {
                Directory.CreateDirectory(destinationPath + "Pictures");
            }
            if (!Directory.Exists(destinationPath + "EPUBs"))
            {
                Directory.CreateDirectory(destinationPath + "EPUBs");
            }
            if (!Directory.Exists(destinationPath + "Videos"))
            {
                Directory.CreateDirectory(destinationPath + "Videos");
            }
            if (!Directory.Exists(destinationPath + "Musik"))
            {
                Directory.CreateDirectory(destinationPath + "Musik");
            }
            if (!Directory.Exists(destinationPath + "Miscellaneous"))
            {
                Directory.CreateDirectory(destinationPath + "Miscellaneous");
            }
        }

        public static void SortAndMoveFile(string file)
        {
            try
            {
                string fileExtension = Path.GetExtension(file);
                string fileName = Path.GetFileName(file);
                string destinationDirectory = "";

                // Use a switch statement to check the file extension
                switch (fileExtension)
                {
                    case ".pdf":
                        destinationDirectory = destinationPath + "PDFs\\";
                        break;
                    case ".exe":
                        destinationDirectory = destinationPath + "EXEs\\";
                        break;
                    case ".epub":
                    case ".mobi":
                        destinationDirectory = destinationPath + "EPUBs\\";
                        break;
                    case ".png":
                    case ".jpg":
                        destinationDirectory = destinationPath + "Pictures\\";
                        break;
                    case ".mp4":
                        destinationDirectory = destinationPath + "Videos\\";
                        break;
                    case ".mp3":
                        destinationDirectory = destinationPath + "Musik\\";
                        break;
                    default:
                        destinationDirectory = destinationPath + "Miscellaneous\\";
                        break;
                }

                // Move the file to the appropriate directory
                File.Move(file, destinationDirectory + fileName);
                Console.WriteLine("File " + fileName + " moved to " + destinationDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
