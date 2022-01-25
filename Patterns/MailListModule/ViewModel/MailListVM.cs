using Infrastructure;
using Prism.Commands;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MailList.Module.ViewModel
{
    public class MailListVM
    {
        private readonly IEventAggregator _eventAggregator;

        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();
        public MailListVM(IEventAggregator eventAggregator)
        {
            OpenMailCommand = new DelegateCommand<object>(param => 
            {
                if (param is Mail mail)
                    OpenMail(mail);
            });
            _eventAggregator = eventAggregator;
        }
        public ICommand OpenMailCommand { get; }
        public void OpenMail(Mail mail)
        {
            //_eventAggregator.GetEvent
        }
    }
}
