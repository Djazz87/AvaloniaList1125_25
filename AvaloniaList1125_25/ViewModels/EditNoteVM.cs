using System;
using System.Collections.Generic;
using AvaloniaList1125_25.Models;

namespace AvaloniaList1125_25.ViewModels;

public class EditNoteVM : BaseVM
{
    // хранимая ссылка на редактируемую заметку
    PersonVM _person;
    // хранимая ссылка на закрытие окна
    Action<bool> closeWindow;

    // свойство с заметкой для привязки
    public PersonVM EditPerson
    {
        get => _person;
        set
        {
            _person = value;
            OnPropertyChanged();
        }
    }

    // список статусов для комбобокса
    public List<Gender> Genders { get; set; }

    // команды сохранить и удалить (инициализация в конструкторе)
    public VMCommand CloseCommand { get; set; }
    public VMCommand RemoveCommand { get; set; }

    public EditNoteVM()
    {
        // загрузка списка статусов
        Genders = new(Enum.GetValues<Gender>());

        // инициализация команд
        CloseCommand = new(() => { closeWindow(false); });

        RemoveCommand = new(() => { closeWindow(true); });
    }

    // методы для сохранения ссылок на заметку и метод закрытия
    public void SetEditNote(PersonVM person)
    {
        EditPerson = person;
    }
    public void SetWindowClose(Action<bool> action)
    {
        closeWindow = action;
    }
}