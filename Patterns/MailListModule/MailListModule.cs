using MailList.Module.View;
using MailList.Module.ViewModel;
using Prism.Ioc;
using Prism.Modularity;
using System;

namespace MailList.Module
{
    public class MailListModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MailListV, MailListVM>();
        }
    }
}
