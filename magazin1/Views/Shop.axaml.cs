using Avalonia.Controls;
using Avalonia.Interactivity;
using magazin1.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace magazin1.Views
{
    public partial class Shop : Window
    {
        
        public Shop()
        {
            InitializeComponent();
            products.ItemsSource = Soxrdann.products1.ToList();
            provadmins();
            if (Soxrdann.pers[0].admin == true)
            {
              NameTovar.IsEnabled = true;
              PriceTovar.IsEnabled = true;
              ColvoTovar.IsEnabled = true;
            }
        }

        public void Dobavtov(object source, RoutedEventArgs args)
        {
            if (NameTovar.Text != null && PriceTovar.Text != null  && ColvoTovar.Text != null &&  Soxrdann.pers[0].admin == true)
            {       
                double price = double.Parse(PriceTovar.Text);   
                int colvo = int.Parse(ColvoTovar.Text);
                Soxrdann.products1.Add(new Tovarclass(NameTovar.Text, price,  colvo, products.ItemCount,1));
                products.ItemsSource = Soxrdann.products1.ToList();
            }
        }
        public void Ybavtov(object sender, RoutedEventArgs args)
        {
          if (Soxrdann.pers[0].admin == true)
          {
                if (0 <= Soxrdann.products1.Count - 1)
                {
                    Soxrdann.products1.RemoveAt((int)(sender as Button)!.Tag!);
                    for (int i = 0; i < Soxrdann.products1.Count; i++)
                    {
                        Soxrdann.products1[i].Id = i;
                    }
                    products.ItemsSource = Soxrdann.products1.ToList();
                }
          }
        }
        public void Add_to_cart(object sender, RoutedEventArgs args)
        {
            int v = (int)(sender as Button)!.Tag!;
            if (Soxrdann.dobtov[v]!=5)
            {
                Soxrdann.dobtov[v] = 5;
                Soxrdann.productsBascket.Add(new Tovarclass(Soxrdann.products1[v].Name, Soxrdann.products1[v].Price, Soxrdann.products1[v].Colvo, v, 1));
            }
        }
        public void Redact_Product(object sender, RoutedEventArgs args)
        {
            if (Soxrdann.pers[0].admin == true)
            {
                int v = (int)(sender as Button)!.Tag!;
                Soxrdann.teg[0] = v;
                new Redactor().Show();
                Close();
                products.ItemsSource = Soxrdann.products1.ToList();
            }
        }
        public void Exit(object source, RoutedEventArgs args)
        {
            Soxrdann.pers[0].admin =false;
            new MainWindow().Show();
            Close();
        }
        public void Baskets(object source, RoutedEventArgs args)
        {
            Soxrdann.pers[0].admin = false;
            new Basket().Show();
            Close();
        }
        private void provadmins()
        {
           if (Soxrdann.pers[0].admin == true)
           {
                prov.Text = "Вы админ";
            }
            else { prov.Text = "Вы обычный пользователь"; }
    
        }
    }
}

