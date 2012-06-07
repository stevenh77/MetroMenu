using System.Windows;
using TinyMessenger;

namespace MetroMenu.Controls
{
	public partial class MenuSection4
	{
        private ITinyMessengerHub Hub { get; set; }

        public MenuSection4()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }

        private void SendMessage(string text)
        {
            var message = new GenericTinyMessage<string>(this, text);
            Hub.Publish(message);
        }

        private void MetroTileMenu13_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 13");
        }

        private void MetroTileMenu14_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 14");
        }

        private void MetroTileMenu15_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 15");
        }

        private void MetroTileMenu16_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 16");
        }
	}
}