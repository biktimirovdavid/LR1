using LR1.Model;
using LR1.ViewModel;
using System.Windows;

namespace LR1.View
{
    public partial class WindowNewEmployee : Window
    {
        public WindowNewEmployee()
        {
            InitializeComponent();
            // Привязываем список ролей к ComboBox
            CbRole.ItemsSource = new RoleViewModel().ListRole;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void tbBirthday_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (tbBirthday.Visibility == Visibility.Hidden)
            {
                ClBirthday.Visibility = Visibility.Visible;
            }
            else
            {
                // не прятать календарь, если в нём вводится дата
                if (!ClBirthday.IsKeyboardFocusWithin)
                {
                    ClBirthday.Visibility = Visibility.Hidden;
                }
                // убрать время из даты рождения
                if (DataContext is PersonDpo person)
                {
                    person.Birthday = PersonDpo.GetStringBirthday(person.Birthday);
                }
            }
        }
    }
}