using Launcher.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Launcher.Views.Components
{
    /// <summary>
    /// Логика взаимодействия для ServersListComponent.xaml
    /// </summary>
    public partial class ServersListComponent : UserControl
    {

        public ObservableCollection<IServer> ServersList
        {
            get { return (ObservableCollection<IServer>)GetValue(ServersListProperty); }
            set { SetValue(ServersListProperty, value); }
        }

        public static readonly DependencyProperty ServersListProperty =
            DependencyProperty.Register("ServersList", typeof(ObservableCollection<IServer>), typeof(ServersListComponent), new PropertyMetadata(null));



        public IServer SelectedServer
        {
            get { return (IServer)GetValue(SelectedServerProperty); }
            set { SetValue(SelectedServerProperty, value); }
        }

        public static readonly DependencyProperty SelectedServerProperty =
            DependencyProperty.Register(nameof(SelectedServer), typeof(IServer), typeof(ServersListComponent), new PropertyMetadata(null));



        public ServersListComponent()
        {
            InitializeComponent();
        }
    }
}
