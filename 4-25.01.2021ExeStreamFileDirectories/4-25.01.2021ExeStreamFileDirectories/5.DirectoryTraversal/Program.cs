using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Directory.GetCurrentDirectory();
            string[] fileNames = Directory.GetFiles(directoryPath);
            Dictionary<string, Dictionary<string, double>> filesData = new Dictionary<string, Dictionary<string, double>>();
            foreach (var fullFileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fullFileName);
                string extension = fileInfo.Extension;
                double kbSize = Math.Round(fileInfo.Length / 1024.0, 3);
                if (filesData.ContainsKey(extension))
                {
                    filesData[extension].Add(fileInfo.Name, kbSize);
                }
                else
                {
                    filesData.Add(extension, new Dictionary<string, double>());
                }
            }
            List<string> result = new List<string>();
            foreach (var item in filesData.OrderByDescending(n=>n.Value.Count).ThenBy(n=>n.Key))
            {
                result.Add(item.Key);
                foreach (var fileData in item.Value.OrderBy(n=>n.Value))
                {
                    result.Add($"--{fileData.Key} - {fileData.Value}kb");
                }
            }
            File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"Ouptut.txt"), result);
            
        }
    }
}
