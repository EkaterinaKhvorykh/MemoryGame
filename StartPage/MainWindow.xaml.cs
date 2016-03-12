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

namespace StartPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> list = new ObservableCollection<string>();
        public int selectedIndex = -1;
        public MainWindow()
        {
            InitializeComponent();
            //this.comboBox1.Items.Add("Angry Birds");
           // this.comboBox1.Items.Add("Super Mario");


            list.Add("Angry Birds");
            list.Add("Super Mario");
            
            this.cbx.ItemsSource = list;

        }
       
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = new Easy();
            form.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var hard = new Hard();
            hard.Show();
        }

        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIndex = this.cbx.SelectedIndex;
            //list[0] = "aa";
            //list[1] = "bb";
           
            //reset the selected index
            //this.cbx.SelectedIndex = selectedIndex;

           

        }

       

    

    
    }
}
