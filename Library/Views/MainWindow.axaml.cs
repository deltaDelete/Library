using Avalonia.Controls;
using Library.ViewModels;

namespace Library.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}