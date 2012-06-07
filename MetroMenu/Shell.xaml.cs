using System.Windows;
using TinyMessenger;

namespace MetroMenu
{
    public partial class Shell
    {
        public Shell()
        {
            InitializeComponent();
			
            var hub = Application.Current.Resources[ResourceKeys.Hub] as ITinyMessengerHub;
            hub.Subscribe<GenericTinyMessage<string>>((m) => { 
				this.NotificationTextBlock.Text = m.Content; 
			});
        }
    }
}
