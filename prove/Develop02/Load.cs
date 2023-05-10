using System;
using System.IO;

class Load
{
    public static List<Entry> LoadFromFile(string filename)
    {
        List<Entry> entries = new List<Entry>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                {
                    string prompt = parts[0];
                    string response = parts[1];                   
                    
                    {
                        Entry entry = new Entry( prompt, response);
                        entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: {0}", filename);
        }

        return entries;
    }
}
