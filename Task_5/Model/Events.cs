using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5.Model
{
    public class Events
    {

        public string EName { get; set; }
        public string OldName { get; set; }
        public string Name { get; set; }
        public string ChangeType { get; set; }
        public string FilePath { get; set; }

        public void Clear()
        {
            EName = "";
            OldName = "";
            Name = "";
            ChangeType = "";
            FilePath = "";
        }

    }
}
