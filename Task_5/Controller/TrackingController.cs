using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task_5.Controller.Interface;
using Task_5.Model;

namespace Task_5.Controller
{

    public class TrackingController: IWatcher
    {

        private FileController fileController = new FileController();
        Events events = new Events();
        FileSystemWatcher fileSystemWatcher;
        IEnumerable<string> BackUp;

        //[STAThread]
        public void StartTracking()
        {

            // Create Watcher
            fileSystemWatcher = new FileSystemWatcher("E:\\1", "*.*"); 
            //fileSystemWatcher.Path = @"E:\\1"; // TODO: Сделать запись пути католога в файл общих изминений и при необходимости возможность его менять.

            // Будем следить за изминениями по последнему доступу
            fileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess
                                           | NotifyFilters.DirectoryName
                                           | NotifyFilters.CreationTime
                                           | NotifyFilters.FileName
                                           | NotifyFilters.LastWrite;

            // Добавим обработчик событий 
            fileSystemWatcher.Changed += new FileSystemEventHandler(OnChanged);
            fileSystemWatcher.Created += new FileSystemEventHandler(OnCreated);
            fileSystemWatcher.Deleted += new FileSystemEventHandler(OnDeleted);
            fileSystemWatcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Включаем наблюдение 
            fileSystemWatcher.EnableRaisingEvents = true;
            // Включаем наблюдение под каталогами
            fileSystemWatcher.IncludeSubdirectories = true;
            
            WatcherStop(fileSystemWatcher);

        }

        //[STAThread]
        private void WatcherStop(FileSystemWatcher fileSystemWatcher)
        {
            // Отписка от событий и выключаем наблюдение
            Console.WriteLine($"0 - EXIT: ");

            try
            {
                var exit = int.Parse(Console.ReadLine());
                
                if (exit == 0)
                {
                    fileSystemWatcher.Changed -= new FileSystemEventHandler(OnChanged);
                    fileSystemWatcher.Created -= new FileSystemEventHandler(OnCreated);
                    fileSystemWatcher.Deleted -= new FileSystemEventHandler(OnDeleted);
                    fileSystemWatcher.Renamed -= new RenamedEventHandler(OnRenamed);
                    fileSystemWatcher.EnableRaisingEvents = false;
                    fileSystemWatcher.IncludeSubdirectories = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
        }

        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            // Avoidance of occurrence in the console of two "File changed"
            try
            {
                Console.WriteLine($"File: {e.FullPath}, {e.ChangeType}");

                events.Clear();

                events.EName = "Changed";
                events.ChangeType = e.ChangeType.ToString();
                events.FilePath = e.FullPath;
                events.Name = e.Name;
                events.OldName = "";

                ReaderController readerController = new ReaderController();

                BackUp = null;
                BackUp = readerController.RecordLogBackUp(events.FilePath);
                fileController.RecordHandler(events, BackUp);
                //fileController.RecordToXmlLog(events);
                fileSystemWatcher.EnableRaisingEvents = false;
            }
            finally
            {
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            
        }

        public void OnCreated(object sender, FileSystemEventArgs e)
        {

            Console.WriteLine($"File: {e.FullPath}, {e.ChangeType}");

            events.Clear();

            events.EName = "Created";
            events.ChangeType = e.ChangeType.ToString();
            events.FilePath = e.FullPath;
            events.Name = e.Name;
            events.OldName = "";

            BackUp = null;
            fileController.RecordHandler(events, BackUp);
            //fileController.RecordToXmlLog(events);
        }

        public void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath}, {e.ChangeType}");

            events.Clear();

            events.EName = "Deleted";
            events.ChangeType = e.ChangeType.ToString();
            events.FilePath = e.FullPath;
            events.Name = e.Name;
            events.OldName = "";

            BackUp = default;
            fileController.RecordHandler(events, BackUp);
            //fileController.RecordToXmlLog(events);
        }

        public void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.Name}");

            events.Clear();

            events.EName = "Renamed";
            events.OldName = e.OldFullPath.ToString();
            events.Name = e.Name;
            events.ChangeType = e.ChangeType.ToString();
            events.FilePath = e.FullPath;

            BackUp = null;
            fileController.RecordHandler(events, BackUp);
            //fileController.RecordToXmlLog(events);
        }

        //private static void OnRenamed(object sender, RenamedEventArgs e)
        //{
        //    // Файл переименован
        //    Console.WriteLine($"File: {e.OldFullPath} renamed to {e.Name}");
        //}

        //private static void OnChanged(object sender, FileSystemEventArgs e)
        //{
        //    // Файл изменился, создан или удален
        //    Console.WriteLine($"File: {e.FullPath}, {e.ChangeType}");
        //}
    }
}
