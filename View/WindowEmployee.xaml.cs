using System.Windows;
using LR1.ViewModel;

namespace LR1.View
{
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}

