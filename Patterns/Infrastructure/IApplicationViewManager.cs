using System;

namespace Infrastructure
{
    public interface IApplicationViewManager
    {
        void AddView(string viewName, string regionName, Type viewType);
        void ShowView(string viewName);
    }
}
