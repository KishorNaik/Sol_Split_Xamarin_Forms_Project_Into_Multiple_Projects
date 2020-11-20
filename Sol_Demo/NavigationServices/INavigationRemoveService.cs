using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NavigationServices
{
    public interface INavigationRemoveService
    {
        Task RemoveOthersPagesExceptMainPageNavigationStack();

        Task RemoveOthersPagesExceptAnimalViewPageNavigationStack();

        Task RemoveOthersPagesExceptCardViewPageNavigationSatck();
    }
}