using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Factory
{
    public static class FactoryView
    {
        private static ConcurrentDictionary<String, Page> keyValuePairs = new ConcurrentDictionary<string, Page>();

        public static void RegisterViews(string viewName, Page page)
        {
            keyValuePairs.GetOrAdd(viewName, page);
        }

        public static Page GetPage(string viewName)
        {
            return keyValuePairs[viewName];
        }
    }
}