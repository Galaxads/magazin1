using Avalonia.Controls;
using Avalonia.Interactivity;
using magazin1.ViewModels;
using System;
using System.Linq;

namespace magazin1.Views
{
    public partial class Redactor : Window
    {
        public Redactor()
        {
            InitializeComponent();
        }
        public void Dobavtov1(object source, RoutedEventArgs args)
        {
            
            if (NameTovar.Text != null && PriceTovar.Text != null  && ColvoTovar.Text != null )
            {
                
                double price = double.Parse(PriceTovar.Text);
              
                int colvo = int.Parse(ColvoTovar.Text);
               // Soxrdann.products1.Add(new Tovarclass(NameTovar.Text, price, sell, colvo, Soxrdann.teg[0]));
                Soxrdann.products1[Soxrdann.teg[0]].Name=NameTovar.Text;
                Soxrdann.products1[Soxrdann.teg[0]].Price = price;
                
                Soxrdann.products1[Soxrdann.teg[0]].Colvo = colvo;
                Soxrdann.products1[Soxrdann.teg[0]].Id = Soxrdann.teg[0];
               // products.ItemsSource = Soxrdann.products1.ToList();
                
                
                new Shop().Show();
                Close();
            }
    
        }
    }
}
