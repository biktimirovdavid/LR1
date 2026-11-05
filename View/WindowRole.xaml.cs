using System.Windows;
using LR1.ViewModel;

namespace LR1.View
{
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel();
        }
    }
}
