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
				this.NotificationTextBlock.Text = string.Format("User pressed {0}", m.Content); 
			});
        }
    }
}
