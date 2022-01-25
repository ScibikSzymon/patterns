using Infrastructure;
using Prism.Regions;
using System;
using System.Collections.Generic;

namespace PrismExampleWpf.Model
{
    internal class ApplicationViewManager : IApplicationViewManager
    {
        private readonly Dictionary<string, ViewInfo> _appVies = new Dictionary<string, ViewInfo>();
        private readonly IRegionManager _regionManager;

        public ApplicationViewManager(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void AddView(string viewName, string regionName, Type viewType)
        {
            if (string.IsNullOrEmpty(viewName) || string.IsNullOrEmpty(regionName))
            {
                throw new ArgumentNullException("viewName or regionName argument exception");
            }
            if (_appVies.ContainsKey(viewName))
            {
                throw new InvalidOperationException("View already registered!");
            }
            _appVies.Add(viewName, new ViewInfo
            {
                Name = viewName,
                Region = regionName,
                Type = viewType
            });
        }

        public void ShowView(string viewName)
        {
            if (!_appVies.TryGetValue(viewName, out ViewInfo viewInfo))
            {
                throw new ArgumentException("Incorrect viewName, not added view");
            }
            _regionManager.RequestNavigate(viewInfo.Region, viewInfo.Name);
        }
    }
}
