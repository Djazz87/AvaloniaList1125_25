using System;
using AvaloniaList1125_25.ViewModels;

namespace AvaloniaList1125_25.Models;

// оболочка для заметки, нужна для отображения изменений 
// в свойствах при изменении заметки
public class PersonVM : BaseVM
{
    private Person _person;

    public string Fio
    {
        get => _person.FIO;
        set
        {
            _person.FIO = value;
            OnPropertyChanged();
        }
    }

    public string Gender
    {
        get => _person.Gender;
        set
        {
            _person.Gender = value;
            OnPropertyChanged();
        }
    }

    public DateTimeOffset DateCreated
    {
        get => DateTimeOffset.Parse(_person.DateCreated.ToShortDateString());
        set
        {
            _person.DateCreated = DateOnly.FromDateTime(value.Date);
            OnPropertyChanged();
        }
    }
    
    public String Phone
    {
        get => _person.Phone;
        set
        {
            _person.Phone = value;
            OnPropertyChanged();
        }
    }

    public string Address
    {
        get => _person.Address;
        set
        {
            _person.Address = value;
            OnPropertyChanged();
        }
    }

    public PersonVM(Person person)
    {
        _person = person;
    }

    public Person Value
    {
        get => _person;
    }
}