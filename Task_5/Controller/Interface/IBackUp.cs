using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Controller.Interface
{
    interface IBackUp
    {
        void FileRenamed(int index, List<string> backUp);
        void FileChanged(int index, List<string> backUp);
        void FileCreated(int index, List<string> backUp);
        void FileDeleted(int index, List<string> backUp);
    }
}
