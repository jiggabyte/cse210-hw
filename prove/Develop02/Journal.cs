using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Globalization;
using CsvHelper;

public class Journal {


    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("date,prompt,entry");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText.Replace(",","#@#")},{entry._entryText.Replace(",","#@#")}");           
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        // Read CSV file using CsvHelper
        using (StreamReader reader = new StreamReader(file))
        
        using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            while (csv.Read())
            {
                csv.ReadHeader();

                var records = csv.GetRecords<EntryDto>();
                
                foreach(var record in records)
                {
                    _entries.Add(new Entry(record.prompt.Replace("#@#",","), record.entry.Replace("#@#",","), record.date));
                    //Console.Write($"{item.date}\t{item.prompt}\t{item.entry}");
                }
                
                //Console.WriteLine();

            }
        }
        /*
        string text;
        using (StreamReader reader = new StreamReader(file))

        {
            text = reader.ReadToEnd();

            var jsonData = JsonSerializer.Deserialize<dynamic>(text);

            foreach(var property in jsonData.Properties())
            {
                _entries.Add(new Entry(property.prompt, property.entry, property.date));
            }

        }

        */
    }


}