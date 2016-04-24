using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Configuration; // Add reference to 'System.Configuration'

namespace FileWatcher
{
    class FileWatcher
    {
        static void Main(string[] args)
        {
            FileWatcher fileWatcher = new FileWatcher();

            fileWatcher.StartFileWatcher();

            Console.ReadLine();
        }

        private void StartFileWatcher()
        {
            string[] filepath = ConfigurationManager.AppSettings["WatchLocations"].Split(',');

            foreach (string f in filepath)
            {
                CreateNewFileWatcher(f);
            }
        }

        private void CreateNewFileWatcher(string filePath)
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher();

            fileWatcher.Path = filePath;
            fileWatcher.Filter = ConfigurationManager.AppSettings["WatchFilter"];
            fileWatcher.NotifyFilter = NotifyFilters.FileName;
            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.Changed += new FileSystemEventHandler(OnChanged);
            fileWatcher.Created += new FileSystemEventHandler(OnChanged);
            fileWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File '{0}' detected at {1}", e.Name, DateTime.Now);
        }
    }
}
