using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCopy
{
    public class FileQuickCopySource : IQuickCopySource
    {

        public string Path { get; set; }

        public FileQuickCopySource(string path)
        {
            Path = path;
        }

        public DateTime GetLastModifiedTime()
        {
            return File.GetLastWriteTime(Path);
        }

        public Dictionary<string, List<string>> RecallData(Dictionary<string, List<string>> data)
        {
            if (data == null)
            {
                data = new Dictionary<string, List<string>>();
            }
            StreamReader reader = new StreamReader(Path);
            using (reader)
            {
                string line = null;
                string categoryName = null;
                List<string> items = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == string.Empty && categoryName != null)
                    {
                        data[categoryName] = items;
                        categoryName = null;
                        items = new List<string>();
                    }
                    else if (line != string.Empty && categoryName == null)
                    {
                        categoryName = line;
                    } else if (line != string.Empty)
                    {
                        items.Add(line);
                    }
                }

                // add leftover items if any
                if (categoryName != null)
                {
                    data[categoryName] = items;
                }
            }
            return data;
        }

        public void StoreData(Dictionary<string, List<string>> data)
        {
            if (data != null)
            {
                CreateDirectory(new FileInfo(Path).Directory);
                StreamWriter writer = new StreamWriter(Path);
                using (writer)
                {
                    foreach (var entry in data)
                    {
                        writer.WriteLine(entry.Key);
                        foreach (string item in entry.Value)
                        {
                            writer.WriteLine(item);
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void CreateDirectory(DirectoryInfo di)
        {
            if (di.Parent != null) {
                CreateDirectory(di.Parent);
            }
            di.Create();
        }

        public string GetData(string key)
        {
            return EncryptionHandler.Decrypt(key, File.ReadAllBytes(Path));
        }

        public void PutData(string key, string json)
        {
            File.WriteAllBytes(Path, EncryptionHandler.Encrypt(key, json));
        }
    }
}
