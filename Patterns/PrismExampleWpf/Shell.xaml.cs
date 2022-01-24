using PrismExampleWpf.ViewModel;
using System.Windows;

namespace PrismExampleWpf
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell(ShellVM shellVM)
        {
            InitializeComponent();
            DataContext = shellVM;
        }
    }
}
