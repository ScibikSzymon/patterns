using Infrastructure;
using MailList.Module.ViewModel;
using System.Windows.Controls;

namespace MailList.Module.View
{
    /// <summary>
    /// Interaction logic for MailListV.xaml
    /// </summary>
    public partial class MailListV : UserControl, IApplicationView
    {
        public MailListV(MailListVM mailListVM)
        {
            InitializeComponent();
            DataContext = mailListVM;
        }

        public string ViewName => "MailListV";
    }
}
