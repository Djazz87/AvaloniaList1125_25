using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace AvaloniaList1125_25.Models;

// реализация сохранения и загрузки заметок через json
public class PersonJson : INoteSerializer
{
    private string file = "notes.json";

    public void Save(List<Person> notes)
    {
        using (var fs = File.Create(file))
            JsonSerializer.Serialize(fs, notes);
    }

    public List<Person> Load()
    {
        if (File.Exists(file))
        {
            using (var fs = File.OpenRead(file))
                return JsonSerializer.Deserialize<List<Person>>(fs);
        }

        return new List<Person>();
    }
}