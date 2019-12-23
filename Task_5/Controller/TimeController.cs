using System;
using System.IO;
using System.Globalization;

namespace Task_5.Controller
{
    public class TimeController
    {

        [STAThread]
        public void RecordTime()
        {
            using (StreamWriter writer = new StreamWriter("E:\\BackUp\\Log.txt", true))
            {
                writer.WriteLine(string.Format($"TIME: {DateTime.Now.ToString(CultureInfo.CurrentUICulture)}"));
                writer.Flush();
            }
        }

    }
}
