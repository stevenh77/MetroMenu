
using System.Windows;
using TinyMessenger;

namespace MetroMenu.Controls
{
	public partial class MenuSection2
	{
private ITinyMessengerHub Hub { get; set; }

        public MenuSection2()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }

        private void SendMessage(string text)
        {
            var message = new GenericTinyMessage<string>(this, text);
            Hub.Publish(message);
        }

        private void MetroTileMenu5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 5");
        }

        private void MetroTileMenu6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 6");
        }

        private void MetroTileMenu7_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 7");
        }

        private void MetroTileMenu8_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 8");
        }
	}
}