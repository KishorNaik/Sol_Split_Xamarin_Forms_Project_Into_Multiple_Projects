using System;
using System.Threading.Tasks;

namespace NavigationServices
{
    public interface INavigationPushService
    {
        Task NavigateToAnimalView();

        Task NavigateToMainPageView();

        Task NavigateToCardView();
    }
}