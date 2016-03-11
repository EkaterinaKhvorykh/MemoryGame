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
        public MainWindow()
        {
            InitializeComponent();
            this.comboBox1.Items.Add("Angry Birds");
            this.comboBox1.Items.Add("Super Mario");

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

    

    
    }
}
