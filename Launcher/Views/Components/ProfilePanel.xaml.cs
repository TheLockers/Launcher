using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher.Views.Components
{
    /// <summary>
    /// Логика взаимодействия для ProfilePanel.xaml
    /// </summary>
    public partial class ProfilePanel : UserControl
    {

        public int Coins
        {
            get { return (int)GetValue(CoinsProperty); }
            set { SetValue(CoinsProperty, value); }
        }

        public static readonly DependencyProperty CoinsProperty =
            DependencyProperty.Register(nameof(Coins), typeof(int), typeof(ProfilePanel), new PropertyMetadata(null));



        public ProfilePanel()
        {
            InitializeComponent();
        }
    }
}
