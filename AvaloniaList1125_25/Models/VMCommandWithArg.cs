using System;
using System.Windows.Input;

namespace AvaloniaList1125_25.Models;

public class VMCommandWithArg<T> : ICommand where T : class
{
    private Action<T> action;

    public VMCommandWithArg(Action<T> action)
    {
        this.action = action;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        action((T)parameter);
    }

    public event EventHandler? CanExecuteChanged;
}