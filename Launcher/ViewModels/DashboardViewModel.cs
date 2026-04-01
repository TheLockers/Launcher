using Launcher.Models;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Launcher.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        #region Текущая страницца
        private ObservableCollection<IServer> _serversList = new ObservableCollection<IServer>();
        public ObservableCollection<IServer> ServersList
        {
            get => _serversList;
            set => SetProperty(ref _serversList, value);
        }
        #endregion

        public DashboardViewModel()
        {
            BitmapImage bitmapimage = new BitmapImage();
            bitmapimage.BeginInit();
            bitmapimage.UriSource = new Uri(@"C:\Users\polun\source\repos\Launcher\Launcher\Views\Resources\Images\cube.png");
            bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapimage.EndInit();
            ServersList.Add(new Server
            {
                Name = "Hitech",
                Image = bitmapimage
            });

            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
            ServersList.Add(new Server
            {
                Name = "Magic",
                Image = bitmapimage
            });
        }
    }
}
