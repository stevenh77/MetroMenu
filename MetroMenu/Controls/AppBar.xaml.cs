using System.Windows;
using TinyMessenger;

namespace MetroMenu.Controls
{
    public partial class AppBar
    {
        private ITinyMessengerHub Hub { get; set; }

        public AppBar()
        {
            InitializeComponent();

            Hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
        }

        private void SendMessage(string text)
        {
            var message = new GenericTinyMessage<string>(this, text);
            Hub.Publish(message);
        }

        private void imageButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("Settings");
        }


        private void imageButtonSave_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("Save");
        }

        private void imageButtonCamera_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("Camera");
        }

        private void imageButtonFavs_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("Favs");
        }

        private void imageButtonFlag_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("Flag");
        }
    }
}
