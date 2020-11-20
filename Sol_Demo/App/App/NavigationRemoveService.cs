using NavigationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using App.Views;
using CircleImageDemo.Views;
using CardViewDemo.Views;

namespace App
{
    public class NavigationRemoveService : INavigationRemoveService
    {
        private Task RemovePages(Type type)
        {
            return Task.Run(() =>
            {
                var existingPages = App.Current.MainPage.Navigation.NavigationStack.ToList();

                foreach (var page in existingPages)
                {
                    if (page.GetType() == type)
                        continue;
                    App.Current.MainPage.Navigation.RemovePage(page);
                }
            });
        }

        async Task INavigationRemoveService.RemoveOthersPagesExceptAnimalViewPageNavigationStack()
        {
            await this.RemovePages(typeof(AnimalViewPage));
        }

        async Task INavigationRemoveService.RemoveOthersPagesExceptCardViewPageNavigationSatck()
        {
            await this.RemovePages(typeof(CardViewPage));
        }

        async Task INavigationRemoveService.RemoveOthersPagesExceptMainPageNavigationStack()
        {
            await this.RemovePages(typeof(MainPage));
        }
    }
}