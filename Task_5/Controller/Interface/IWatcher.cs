using System.IO;

namespace Task_5.Controller.Interface
{
    interface IWatcher
    {
        void OnRenamed(object sender, RenamedEventArgs e);
        void OnChanged(object sender, FileSystemEventArgs e);
        void OnCreated(object sender, FileSystemEventArgs e);
        void OnDeleted(object sender, FileSystemEventArgs e);
    }
}
