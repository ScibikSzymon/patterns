using Infrastructure;
using MailList.Module.View;
using MailList.Module.ViewModel;
using Prism.Ioc;
using Prism.Modularity;
using System;

namespace MailList.Module
{
    public class MailListModule : IModule
    {
        private readonly IApplicationViewManager _applicationViewManager;
        public MailListModule(IApplicationViewManager applicationViewManager)
        {
            _applicationViewManager = applicationViewManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MailListV, MailListVM>();
            _applicationViewManager.AddView(nameof(MailListV), RegionNames.Left, typeof(MailListV));
        }
    }
}
