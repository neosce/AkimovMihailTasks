using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using Task_5.Controller.Interface;

namespace Task_5.Controller
{
    public class BackUp: IBackUp
    {

        int indexLog = default;

        Regex regex = new Regex(@"TIME:");
        Regex regex2 = new Regex(@"Type_of_change: ");
        Regex regexTypeFile = new Regex(@"[^ ]+\.txt");


        public void BackUpMain(uint n, IDictionary<int, int> keyNumberBackUp, List<string> eventsBackUp)
        {

            foreach (var item in keyNumberBackUp)
            {
                if (item.Key == n)
                {
                    //Console.WriteLine($"IDictionary: {item.Key}, value {item.Value}");
                    indexLog = item.Value;
                }
            }

            int number = 1;
            string pattern = @"Type_of_change: ";
            string[] elements;

            for (int i = indexLog + 1; i < eventsBackUp.Count; i++)
            {
                if (regex.IsMatch(eventsBackUp[i]))
                {
                    break;
                }
                else if (eventsBackUp[i].StartsWith("Type_of_change: "))
                {
                    elements = Regex.Split(eventsBackUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "")
                        {
                            number++;
                            Console.WriteLine($"{number} - {element}");

                            //TODO: Select events list time session

                            switch (element)
                            {
                                case "Changed":
                                    FileChanged(i, eventsBackUp);
                                    break;
                                case "Created":
                                    FileCreated(i, eventsBackUp);
                                    break;
                                case "Renamed":
                                    FileRenamed(i, eventsBackUp);
                                    break;
                                case "Deleted":
                                    FileDeleted(i, eventsBackUp);
                                    break;
                                default:
                                    break;
                            }

                        }
                    }
                }
               
                Console.WriteLine($"{eventsBackUp[i]}");

            }

        }

        public void FileChanged(int index, List<string> backUp)
        {

            string[] elements;
            string pattern = @": ";
            string path = default;
            string txt = default;

            for (int i = index + 1 ; i < backUp.Count; i++)
            {
                if (regex.IsMatch(backUp[i]) || regex2.IsMatch(backUp[i]))
                {
                    break;
                }
                else if (backUp[i].StartsWith("File_location: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_location")
                        {
                            path = element;
                        }
                    }
                }
                else if(backUp[i].StartsWith("File_contents_if_txt: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_contents_if_txt")
                        {
                            txt = element;
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(txt);
                writer.Flush();
            }

        }

        public void FileCreated(int index, List<string> backUp)
        {
            string[] elements;
            string pattern = @": ";
            string path = default;
            string txt = "";

            for (int i = index + 1; i < backUp.Count; i++)
            {
                if (regex.IsMatch(backUp[i]) || regex2.IsMatch(backUp[i]))
                {
                    break;
                }
                else if (backUp[i].StartsWith("File_location: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_location")
                        {
                            path = element;
                        }
                    }
                }
                else if (backUp[i].StartsWith("File_contents_if_txt: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_contents_if_txt")
                        {
                            txt = element;
                        }
                    }
                }
            }

            if (regexTypeFile.IsMatch(path))
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLine(txt);
                    writer.Flush();
                }
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.ToString()}");
                }
            }

            
        }

        public void FileDeleted(int index, List<string> backUp)
        {

            string[] elements;
            string pattern = @": ";
            string path = default;

            for (int i = index + 1; i < backUp.Count; i++)
            {
                if (regex.IsMatch(backUp[i]) || regex2.IsMatch(backUp[i]))
                {
                    break;
                }
                else if (backUp[i].StartsWith("File_location: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_location")
                        {
                            path = element;
                        }
                    }
                }
                
            }

            if (regexTypeFile.IsMatch(path))
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(path);
                    fileInfo.Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.ToString()}");
                }
            }
            else
            {
                try
                {
                    Directory.Delete(path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.ToString()}");
                }
            }

        }

        public void FileRenamed(int index, List<string> backUp)
        {

            string[] elements;
            string pattern = @": ";
            string path = default;
            string oldPath = default;

            for (int i = index + 1; i < backUp.Count; i++)
            {
                if (regex.IsMatch(backUp[i]) || regex2.IsMatch(backUp[i]))
                {
                    break;
                }
                else if (backUp[i].StartsWith("OldName: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "OldName")
                        {
                            oldPath = element;
                        }
                    }
                }
                else if (backUp[i].StartsWith("File_location: "))
                {
                    elements = Regex.Split(backUp[i], pattern);
                    foreach (var element in elements)
                    {
                        if (element != "File_location")
                        {
                            path = element;
                        }
                    }
                }

            }

            if (regexTypeFile.IsMatch(path) || regexTypeFile.IsMatch(oldPath))
            {
                try
                {
                    File.Move(oldPath, path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.ToString()}");
                }
            }
            else
            {
                try
                {
                    Directory.Move(oldPath, path);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.ToString()}");
                }
            }

        }

    }
}
