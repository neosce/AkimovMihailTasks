using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml;
using System.Globalization;
using Task_5.Model;

namespace Task_5.Controller
{
    public class FileController
    {

        [STAThread]
        public void RecordHandler(Events events, IEnumerable<string> backUp)
        {
            
            using (StreamWriter writer = new StreamWriter("E:\\BackUp\\Log.txt", true))
            {
                string data = "";

                if (backUp != null)
                {
                    foreach (var item in backUp)
                    {
                        data += item;
                    }
                }

                writer.WriteLine(string.Format($"Type_of_change: {events.ChangeType}"));
                writer.WriteLine(string.Format($"OldName: {events.OldName}"));
                writer.WriteLine(string.Format($"File_location: {events.FilePath}"));
                writer.WriteLine(string.Format($"File_contents_if_txt: {data}"));
                writer.Flush();
            }

        }

        // TODO: XML

        //[STAThread]
        //public void RecordToXmlLog(Events events)
        //{
        //    string PathLog = "XLog.xml";

        //    using (var logger = new XmlTextWriter(PathLog, Encoding.UTF8))
        //    {
                
        //        logger.WriteStartDocument();

        //        logger.WriteStartElement("TypeOfChange", events.ChangeType);
        //        logger.WriteStartElement("FileName", events.Name);
        //        if (events.OldName != "")
        //        {
        //            logger.WriteStartElement("OldName", events.OldName);
        //        }
        //        logger.WriteStartElement("FileLocation", events.FilePath);
        //        logger.WriteString("string .txt");
        //        logger.WriteEndElement();
        //        if (events.OldName != "")
        //        {
        //            logger.WriteEndElement();
        //        }
        //        logger.WriteEndElement();
        //        logger.WriteEndElement();

        //        logger.Flush();
        //        logger.Close();
        //    }
            

        //}

        //private static void FilePathCheck(Events events, XmlDocument logger, XmlDocument xmlElement)
        //{

        //string PathLog = "XLog.xml";

        //var logger = new XmlDocument();
        //logger.Load(PathLog);


        //var xmlElement = logger;
        //logger.CreateElement(events.EName);

        //logger.DocumentElement.AppendChild(xmlElement);

        //var xmlAttribute = logger.CreateAttribute("DateTime");
        //xmlAttribute.Value = DateTime.Now.ToString(CultureInfo.CurrentUICulture);
        //xmlElement.Attributes.Append(xmlAttribute);

        //if (events.OldName != "")
        //{
        //    XmlNode xmlOldName = logger.CreateElement("OldName");
        //    xmlOldName.InnerText = events.OldName;
        //    xmlElement.AppendChild(xmlOldName);
        //}

        //if (events.Name != "")
        //{
        //    XmlNode xmlNewName = logger.CreateElement("NewName");
        //    xmlNewName.InnerText = events.Name;
        //    xmlElement.AppendChild(xmlNewName);
        //}

        //FilePathCheck(events, logger, xmlElement);

        //if (events.ChangeType != "")
        //{
        //    XmlNode xmlChangeType = logger.CreateElement("ChangeType");
        //    xmlChangeType.InnerText = events.Name;
        //    xmlElement.AppendChild(xmlChangeType);
        //}

        //logger.Save(PathLog);

        ///--------------------------------------------------------------------

        //    if (events.FilePath != "")
        //    {
        //        XmlNode xmlFullPath = logger.CreateElement("FullPath");
        //        xmlFullPath.InnerText = events.FilePath;
        //        xmlElement.AppendChild(xmlFullPath);

        //        if (Directory.Exists(events.FilePath))
        //        {
        //            var elemetFilePath = logger.CreateElement(events.EName);
        //            logger.DocumentElement.AppendChild(elemetFilePath);

        //            XmlNode subElemetFilePath3_1 = logger.CreateElement("CreationTime");
        //            subElemetFilePath3_1.InnerText = Directory.GetCreationTime(events.FilePath).ToString(CultureInfo.InvariantCulture);
        //            elemetFilePath.AppendChild(subElemetFilePath3_1);

        //            XmlNode subElemetFilePath3_2 = logger.CreateElement("LastAccessTime");
        //            subElemetFilePath3_2.InnerText = Directory.GetLastAccessTime(events.FilePath).ToString(CultureInfo.InvariantCulture);
        //            elemetFilePath.AppendChild(subElemetFilePath3_2);

        //            XmlNode subElemetFilePath3_3 = logger.CreateElement("LastWriteTime");
        //            subElemetFilePath3_3.InnerText = Directory.GetLastWriteTime(events.FilePath).ToString(CultureInfo.InvariantCulture);
        //            elemetFilePath.AppendChild(subElemetFilePath3_3);

        //            XmlNode subElemetFilePath3_4 = logger.CreateElement("LogicalDrives");
        //            subElemetFilePath3_4.InnerText = Directory.GetLogicalDrives().ToString();
        //            elemetFilePath.AppendChild(subElemetFilePath3_4);
        //        }
        //    }
        //}
    }
}
