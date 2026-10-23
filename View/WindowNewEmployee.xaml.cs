using System.Windows;
using LR1.ViewModel;

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
    }
}