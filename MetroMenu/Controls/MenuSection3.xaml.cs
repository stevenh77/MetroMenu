using System.Windows;
using TinyMessenger;

namespace MetroMenu.Controls
{
	public partial class MenuSection3
	{
        private ITinyMessengerHub Hub { get; set; }

        public MenuSection3()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }

        private void SendMessage(string text)
        {
            var message = new GenericTinyMessage<string>(this, text);
            Hub.Publish(message);
        }

        private void MetroTileMenu9_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 9");
        }

        private void MetroTileMenu10_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 10");
        }

        private void MetroTileMenu11_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 11");
        }

        private void MetroTileMenu12_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SendMessage("Menu 12");
        }
	}
}