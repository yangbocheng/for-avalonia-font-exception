using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using ReactiveUI;


// using System;
// using System.Collections.Generic;
// using System.Reactive.Linq;
// using System.Text;
// using System.Windows.Input;
// using ReactiveUI;


namespace AvaMusicStore.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ItemOne> List { get; set; }

    public Task<string> AsyncText
    {
        get => GetAsyncText(Text);
    }

    public async Task<string> GetAsyncText(string basetxt)
    {
        await Task.Delay(2000);
        return $"_[{basetxt}]";
    }

    public void ManualNotify()
    {
        OnPropertyChanged(nameof(AsyncText));
    }

    public MainWindowViewModel()
    {
        List = new ObservableCollection<ItemOne>()
        {
            new ItemOne
            {
                IsClass1 = true,
                IsClass2 = false,
                Text = "12312",
            },
            new ItemOne()
            {
                IsClass1 = false,
                IsClass2 = false,
                Text = "奥术大师大",
            }
        };
    }

    private string _Text = "default";

    public string Text
    {
        get => _Text;
        set => UpdateProp(ref _Text, value);
    }


    
}