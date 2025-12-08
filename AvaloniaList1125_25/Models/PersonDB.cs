using System;
using System.Collections.Generic;
using System.Linq;

namespace AvaloniaList1125_25.Models;

public class PersonDB
{
    private readonly INoteSerializer _serializer;
    List<Person> notes;

    public PersonDB(INoteSerializer serializer)
    {
        _serializer = serializer;
        notes = serializer.Load();
    }

    public Person CreateNote()
    {
        Person person = new Person { DateCreated = DateOnly.FromDateTime(DateTime.Today) };
        notes.Add(person);
        _serializer.Save(notes);
        return person;
    }

    public void UpdateNote(Person person)
    {
        _serializer.Save(notes);
    }

    public void DeleteNote(Person person)
    {
        notes.Remove(person);
        _serializer.Save(notes);
    }

    public List<Person> GetLast10Notes()
    {
        if (notes.Count <= 10)
            return notes.OrderByDescending(s => s.DateCreated).ToList();
        else
            return notes.TakeLast(10).OrderByDescending(s => s.DateCreated).ToList();
    }
}