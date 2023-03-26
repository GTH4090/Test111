using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using static Test11.Classes.Helper;

namespace Test11.Pages;

public partial class Auth : UserControl
{
    public Auth()
    {
        InitializeComponent();
    }

    

    private void PasswordCb_OnChecked(object? sender, RoutedEventArgs e)
    {
        PasswordTbx.PasswordChar = '\0';
    }

    private void PasswordCb_OnUnchecked(object? sender, RoutedEventArgs e)
    {
        PasswordTbx.PasswordChar = '*';
    }

    private void LoginBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        if (Db.Users.FirstOrDefault(el => el.Login == LoginTbx.Text && el.Password == PasswordTbx.Text) != null)
        {
            Navigationn.Content = new MainMenu();
        }
    }
}