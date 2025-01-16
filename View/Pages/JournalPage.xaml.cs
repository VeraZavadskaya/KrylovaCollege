using KrylovaCollege.Model;
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
    /// Логика взаимодействия для JournalPage.xaml
    /// </summary>
    public partial class JournalPage : Page
    {
        public JournalPage()
        {
            InitializeComponent();

            JournalLv.ItemsSource = App.context.Journal.ToList();

            SpecialCmb.SelectedValuePath = "Id";
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.ItemsSource = App.context.Special.ToList();

            DirectionCmb.SelectedValuePath = "Id";
            DirectionCmb.DisplayMemberPath= "Name";
            DirectionCmb.ItemsSource = App.context.Direction.ToList();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            ActivityCmb.SelectedValuePath= "Id";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.Activity.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(SpecialCmb.Text) && string.IsNullOrEmpty(DirectionCmb.Text) && string.IsNullOrEmpty(GroupCmb.Text) && string.IsNullOrEmpty(ActivityCmb.Text) && string.IsNullOrEmpty(MarkTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Journal journal = new Journal()
                {
                    DateEvent = (DateTime)DateEventDp.SelectedDate,
                    Group = GroupCmb.SelectedItem as Group,
                    Activity = ActivityCmb.SelectedItem as Activity,
                    Mark = Convert.ToDecimal(MarkTb.Text)
                };

                App.context.Journal.Add(journal);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена");

                JournalLv.ItemsSource = App.context.Journal.ToList();
            }
        }
    }
}
