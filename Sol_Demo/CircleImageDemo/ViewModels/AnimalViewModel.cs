using CircleImageDemo.Models;
using CircleImageDemo.Views;
using MvvmHelpers;
using NavigationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CircleImageDemo.ViewModels
{
    public class AnimalViewModel : BaseViewModel
    {
        private INavigationPushService navigationService;
        private INavigationRemoveService navigationRemoveService = null;

        public AnimalViewModel()
        {
            navigationService = DependencyService.Get<INavigationPushService>();
            navigationRemoveService = DependencyService.Get<INavigationRemoveService>();

            AnimalM = new AnimalModel();
            AnimalM.Source = "https://cdn.vox-cdn.com/thumbor/bcz_df2g76PuoMeaSt6JOjlE-Fo=/0x0:3000x2225/920x613/filters:focal(1082x339:1562x819):format(webp)/cdn.vox-cdn.com/uploads/chorus_image/image/66609943/GettyImages_137497593.0.jpg";

            NavigateCardViewPage = new Command(async () => await this.NavigateCardViewAsync());
        }

        private AnimalModel animalM = null;

        public AnimalModel AnimalM
        {
            get => animalM;
            set => base.SetProperty(ref animalM, value);
        }

        public ICommand NavigateCardViewPage { get; }

        private async Task NavigateCardViewAsync()
        {
            await navigationService.NavigateToCardView();
            await navigationRemoveService.RemoveOthersPagesExceptCardViewPageNavigationSatck();
        }
    }
}