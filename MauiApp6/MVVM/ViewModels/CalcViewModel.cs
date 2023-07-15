using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp6.MVVM.ViewModels;

public class CalcViewModel : INotifyPropertyChanged
{
	private int _num1;
    private int _num2;
    private int _answer;

    public int Num1
	{
        get => _num1;

        set { _num1 = value; OnPropertyChanged(); }
	}
    public int Num2
    {
        get => _num2;
        set { _num2 = value; OnPropertyChanged(); }
    }
    public int Answer
    {
        get => _answer;
        set { _answer = value; OnPropertyChanged(); }
    }

    public ICommand SumCommand =>
        new Command(() => Answer = Num1 + Num2);

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
