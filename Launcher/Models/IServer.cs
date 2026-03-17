using System.Windows.Media;

namespace Launcher.Models
{
    public interface IServer
    {
        public string Name { get; set; }
        public ImageSource Image { get; set; }
    }
}
