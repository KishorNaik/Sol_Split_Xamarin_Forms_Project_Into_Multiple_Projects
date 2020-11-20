using App.Views;
using CardViewDemo.Views;
using CircleImageDemo.Views;
using NavigationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class NavigationPushService : INavigationPushService
    {
        async Task INavigationPushService.NavigateToAnimalView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AnimalViewPage());
        }

        async Task INavigationPushService.NavigateToCardView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new CardViewPage());
        }

        async Task INavigationPushService.NavigateToMainPageView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
    }
}