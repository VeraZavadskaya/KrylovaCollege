using KrylovaCollege.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Group = KrylovaCollege.Model.Group;

namespace KrylovaCollege.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report4Page.xaml
    /// </summary>
    public partial class Report4Page : Page
    {
        public Report4Page(Group group)
        {
            InitializeComponent();

            JournalDg.ItemsSource = App.context.Journal.Where(x => x.IdGroup == group.Id).ToList();
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
                printDialog.PrintVisual(JournalDg, "Баллы");
        }
    }
}
