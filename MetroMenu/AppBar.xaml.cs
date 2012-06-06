using System.Windows;
using TinyMessenger;

namespace MetroMenu
{
    public partial class AppBar
    {
        private ITinyMessengerHub Hub { get; set; }

        public AppBar()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }
    }
}
