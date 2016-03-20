using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MemoryGame;
using System.Windows.Markup;
using System.Windows.Baml2006; 
namespace StartPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        public string new_route; 
        public MainWindow()
        {
            InitializeComponent();
            //ImageBrush myBrush = new ImageBrush();
            //myBrush.ImageSource = new BitmapImage(new Uri("pack://MemoryGame:.../fon2.jpg", UriKind.Absolute));
            //this.Background = myBrush;
           
        }
       
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = new Easy(new_route);
            form.Show();
 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var hard = new Hard(new_route);
            hard.Show();
        }

       

        private void SM_Selected(object sender, RoutedEventArgs e)
        {
            this.new_route = "SuperMario";
            Easy.IsEnabled = true;
            Hard.IsEnabled = true;
        }

        private void AB_Selected(object sender, RoutedEventArgs e)
        {
            this.new_route = "AngryBirds";
            Easy.IsEnabled = true;
            Hard.IsEnabled = true;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            this.new_route = "Smeshar";
            Easy.IsEnabled = true;
            Hard.IsEnabled = true;
        }

     

        

       

    

    
    }
}
