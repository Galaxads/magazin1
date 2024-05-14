using Avalonia.Controls;
using Avalonia.Interactivity;
using magazin1.ViewModels;

namespace magazin1.Views;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        
        
    }
    public void Avtoriaz(object source, RoutedEventArgs args)
    {
       if (Logins.Text!= null&& Passwords.Text != null) 
        {
            Soxrdann.pers[0].login = Logins.Text;
            Soxrdann.pers[0].passwords = Passwords.Text;
            Soxrdann.pers[0].provAdmin(Soxrdann.pers[0].login, Soxrdann.pers[0].passwords);
            new Shop().Show();
            Close();

        }
       
    }
}
