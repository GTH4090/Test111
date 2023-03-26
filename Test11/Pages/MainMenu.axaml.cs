using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using static Test11.Classes.Helper;
namespace Test11.Pages;

public partial class MainMenu : UserControl
{
    public MainMenu()
    {
        InitializeComponent();
        MainDg.Items = Db.Users.ToList();
    }

    
}