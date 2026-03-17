using Launcher.Views.Pages;
using MvvmCross.ViewModels;
using System.Windows.Controls;

namespace Launcher.ViewModels
{
    internal class MainViewModel : MvxViewModel
    {

        private Page _dashboardPage = new DashboardPage();

        #region Текущая страницца
        private Page _currentPage;
        public Page ContentPage
        {
            get => _currentPage;
            set => SetProperty(ref _currentPage, value);
        }
        #endregion

        public MainViewModel()
        {
            ContentPage = _dashboardPage;

        }
    }
}
