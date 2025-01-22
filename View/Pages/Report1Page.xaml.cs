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

namespace KrylovaCollege.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Report1Page.xaml
    /// </summary>
    public partial class Report1Page : Page
    {
        public Report1Page()
        {
            InitializeComponent();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();
        }

        private void ChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            //    if(string.IsNullOrEmpty(DateStartDp.Text) && string.IsNullOrEmpty(DateFinishDp.Text) && string.IsNullOrEmpty(GroupCmb.Text))
            //    {
            //        MessageBox.Show("Заполните все поля");
            //    }
            //    else
            {
                //int chooseGroup = Convert.ToInt32(GroupCmb.SelectedValue);
                var a = (DateTime)DateStartDp.SelectedDate;
                var b = (DateTime)DateFinishDp.SelectedDate;
                ReportDg.ItemsSource = App.context.Journal
                    //.Where(j => j.IdGroup == chooseGroup)
                    .Select(o => o.DateEvent >= a && o.DateEvent <= b)
                    .ToList();


            }
        }
    }
}
