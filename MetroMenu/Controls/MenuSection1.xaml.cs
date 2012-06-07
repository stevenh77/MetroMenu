
using System.Windows;
using TinyMessenger;

namespace MetroMenu.Controls
{
	public partial class MenuSection
	{
        private ITinyMessengerHub Hub { get; set; }

        public MenuSection()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }

        private void SendMessage(string text)
        {
            var message = new GenericTinyMessage<string>(this, text);
            Hub.Publish(message);
        }

        private void MetroTileMenu1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 1");
        }

        private void MetroTileMenu2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 2");
        }

        private void MetroTileMenu3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 3");
        }

        private void MetroTileMenu4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 4");
        }
	}
}