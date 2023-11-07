namespace AvaMusicStore.ViewModels;

public class ItemOne : ViewModelBase
{
    private bool _IsClass1;
    public bool IsClass1
    {
        get => _IsClass1;
        set => UpdateProp(ref _IsClass1, value);
    }

    private bool _IsClass2;
    public bool IsClass2
    {
        get => _IsClass2;
        set => UpdateProp(ref _IsClass2, value);
    }
    
    public string Text { get; set; }
}