using System;

namespace AvaloniaList1125_25.Models;

// основной класс заметки
public class Person
{
    public string  FIO { get; set; }
    public string  Gender { get; set; }
    public string Phone { get; set; }
    public DateOnly DateCreated { get; set; }
    public string Address { get; set; }
}