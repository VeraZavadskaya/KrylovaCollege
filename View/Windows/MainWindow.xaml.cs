using KrylovaCollege.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrylovaCollege
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new MainPage());
        }

        private void AddGroup_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddGroupPage());
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddActivityPage());
        }

        private void JournalBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new JournalPage());
        }

        private void Report1Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report1Page());
        }

        private void Report2Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report2Page());
        }

        private void Report3Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Report3Page()); 
        }
    }
}
