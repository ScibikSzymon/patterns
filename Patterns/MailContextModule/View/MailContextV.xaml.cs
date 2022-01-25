using Infrastructure;
using MailContext.Module.ViewModel;
using System.Windows.Controls;

namespace MailContext.Module.View
{
    /// <summary>
    /// Interaction logic for MailContextV.xaml
    /// </summary>
    public partial class MailContextV : UserControl, IApplicationView
    {
        public MailContextV(MailContextVM mailContextVM)
        {
            InitializeComponent();
            DataContext = mailContextVM;
        }
        public string ViewName => "MailContextV";
    }
}
