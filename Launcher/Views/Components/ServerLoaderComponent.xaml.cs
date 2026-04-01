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
    /// Логика взаимодействия для ServerLoaderComponent.xaml
    /// </summary>
    public partial class ServerLoaderComponent : UserControl
    {
        public String Title
        {
            get { return (String)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(String), typeof(ServerLoaderComponent), new PropertyMetadata(String.Empty));


        public String Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(nameof(Description), typeof(String), typeof(ServerLoaderComponent), new PropertyMetadata(String.Empty));


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(double), typeof(ServerLoaderComponent), new PropertyMetadata(null));


        public ServerLoaderComponent()
        {
            InitializeComponent();
            DataContext = this;
        }

    }
}
