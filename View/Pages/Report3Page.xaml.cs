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
    /// Логика взаимодействия для Report3Page.xaml
    /// </summary>
    public partial class Report3Page : Page
    {
        public Report3Page()
        {
            InitializeComponent();

            SpecialityCmb.SelectedValuePath = "Id";
            SpecialityCmb.DisplayMemberPath = "Name";
            SpecialityCmb.ItemsSource = App.context.Special.ToList();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            int selectedSpecial = Convert.ToInt32(SpecialityCmb.SelectedValue);

            GroupDg.ItemsSource = App.context.Group.Where(x => x.IdSpecial == selectedSpecial).ToList();
        }

        private void MarkBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Report4Page((sender as Button).DataContext as Group));
        }
    }
}
