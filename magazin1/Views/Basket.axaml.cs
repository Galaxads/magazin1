using Avalonia.Controls;
using Avalonia.Interactivity;
using magazin1.ViewModels;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace magazin1.Views
{
    public partial class Basket : Window
    {
        
        public Basket()
        {
            InitializeComponent();
            
            productsBasket.ItemsSource = Soxrdann.productsBascket.ToList();
        }
        public void Ybavtov1(object sender, RoutedEventArgs args)
        { 
                if (0 <= Soxrdann.products1.Count - 1)
                {
                    Soxrdann.products1.RemoveAt((int)(sender as Button)!.Tag!);

                    for (int i = 0; i < Soxrdann.products1.Count; i++)
                    {
                        Soxrdann.products1[i].Id = i;
                    }

                    productsBasket.ItemsSource = Soxrdann.products1.ToList();
                }  
        }
        public void Dobav_Product(object sender, RoutedEventArgs args)
        {
            int v = (int)(sender as Button)!.Tag!;
            if (Soxrdann.products1[v].Colvo1< Soxrdann.products1[v].Colvo)
            {
                Soxrdann.products1[v].Colvo1 += 1;
                productsBasket.ItemsSource = Soxrdann.products1.ToList();
            }
        }
        public void Delete_Product(object sender, RoutedEventArgs args)
        {
            int v = (int)(sender as Button)!.Tag!;
            if (1<Soxrdann.products1[v].Colvo1 && Soxrdann.products1[v].Colvo1 <= Soxrdann.products1[v].Colvo)
            {

                Soxrdann.products1[v].Colvo1 -= 1;
                productsBasket.ItemsSource = Soxrdann.products1.ToList();
            }

        }
        public void Exit(object source, RoutedEventArgs args)
        {
            Soxrdann.pers[0].admin = false;
            new MainWindow().Show();
            Close();
        }
        public void Baskets(object source, RoutedEventArgs args)
        {
            Soxrdann.pers[0].admin = true;
            new Shop().Show();
            Close();
        }
     
    }
}
