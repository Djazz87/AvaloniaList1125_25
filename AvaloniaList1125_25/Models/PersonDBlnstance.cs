namespace AvaloniaList1125_25.Models;

// реализация singleton-объекта для хранения ссылки на бд с списком заметок
public class PersonDBlnstance
{
    private static PersonDBlnstance instance;
    readonly PersonDB _db;

    // публичная ссылка на базу
    public PersonDB DB
    {
        get => _db;
    }

    private PersonDBlnstance()
    {
        // создаем базу заметок и настраиваем ее на работу с json
        _db = new PersonDB(new PersonJson());
    }

    // метод для получения синглтон-объекта
    public static PersonDBlnstance Get()
    {
        if (instance == null)
            instance = new();
        return instance;
    }
}