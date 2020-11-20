using CardViewDemo.Models;
using MvvmHelpers;
using NavigationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CardViewDemo.ViewModels
{
    public class CardViewModel : BaseViewModel
    {
        private readonly INavigationPushService navigationPushService = null;
        private readonly INavigationRemoveService navigationRemoveService = null;

        public CardViewModel()
        {
            navigationPushService = DependencyService.Get<INavigationPushService>();
            navigationRemoveService = DependencyService.Get<INavigationRemoveService>();

            UserM = new UserModel()
            {
                FullName = "Kishor Naik"
            };

            NavigateMainPage = new Command(async () => await this.NavigateMainPageAsync());
        }

        private UserModel userM;

        public UserModel UserM
        {
            get => userM;
            set => base.SetProperty(ref userM, value);
        }

        public ICommand NavigateMainPage { get; set; }

        private async Task NavigateMainPageAsync()
        {
            await navigationPushService.NavigateToMainPageView();
            await navigationRemoveService.RemoveOthersPagesExceptMainPageNavigationStack();
        }
    }
}