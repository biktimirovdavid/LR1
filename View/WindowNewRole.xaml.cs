using System.Windows;

namespace LR1.View
{
    public partial class WindowNewRole : Window
    {
        public WindowNewRole()
        {
            InitializeComponent();
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
