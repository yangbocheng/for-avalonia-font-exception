using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace AvaMusicStore.ViewModels;

// public class ViewModelBase : ReactiveObject
// {
//     
// }

public class ViewModelBase : INotifyPropertyChanged
{
    protected void UpdateProp<T>(ref T properValue, T newValue, [CallerMemberName] string properName = "")
    {
        if (object.Equals(properValue, newValue))
            return;
 
        properValue = newValue;
        OnPropertyChanged(properName);
    }
 
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}