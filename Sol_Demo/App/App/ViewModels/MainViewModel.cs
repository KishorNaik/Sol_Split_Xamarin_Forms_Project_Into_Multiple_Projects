using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using NavigationServices;
using App.Views;

namespace App.ViewModels
{
    public class MainViewModel
    {
        private INavigationPushService navigationService = null;
        private INavigationRemoveService navigationRemoveService = null;

        public MainViewModel()
        {
            navigationService = DependencyService.Get<INavigationPushService>();
            navigationRemoveService = DependencyService.Get<INavigationRemoveService>();

            NavigateAnimalViewPage = new Command(async () => await this.OnNavigateAnimalViewPage());
        }

        public ICommand NavigateAnimalViewPage { get; }

        private async Task OnNavigateAnimalViewPage()
        {
            // navigation = Application.Current.MainPage.Navigation;

            //await navigation.PushModalAsync(animalView);

            await navigationService.NavigateToAnimalView();
            await navigationRemoveService.RemoveOthersPagesExceptAnimalViewPageNavigationStack();
        }
    }
}