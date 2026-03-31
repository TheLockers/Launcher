using System.Windows;
using System.Windows.Controls;

namespace Launcher.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для DashboardPage.xaml
    /// </summary>
    public partial class DashboardPage : Page
    {
        private void NavigateToWebsite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Открывает сайт в браузере по умолчанию
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://example.com", // Замените на ваш URL
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть сайт: {ex.Message}");
            }
        }

        public DashboardPage()
        {
            InitializeComponent();
        }
    }
}
