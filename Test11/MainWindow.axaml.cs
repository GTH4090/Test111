using Avalonia.Controls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Test11.Pages;
using static Test11.Classes.Helper;

namespace Test11;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Navigationn = MainFrame;
        Win = this;
        Navigationn.Content = new Auth();
    }
}