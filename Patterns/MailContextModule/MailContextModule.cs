using Infrastructure;
using MailContext.Module.View;
using MailContext.Module.ViewModel;
using Prism.Ioc;
using Prism.Modularity;
using System;

namespace MailContext.Module
{
    public class MailContextModule : IModule
    {
        private readonly IApplicationViewManager _applicationViewManager;
        public MailContextModule(IApplicationViewManager applicationViewManager)
        {
            _applicationViewManager = applicationViewManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MailContextV, MailContextVM>();
            _applicationViewManager.AddView(nameof(MailContextV), RegionNames.Right, typeof(MailContextV));
        }
    }
}
