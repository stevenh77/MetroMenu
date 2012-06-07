using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MetroMenu.Controls
{
    [TemplatePart(Name = "PART_DISPLAY_ICON", Type = typeof(Image))]
    [TemplatePart(Name = "PART_DISPLAY_COUNT_CONTAINER", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_DISPLAY_TITLE_CONTAINER", Type = typeof(TextBlock))]
    [Description("Represents a metro styled tile that displays an icon, a count and a title")]
    public class MetroTile : Control
    {
        public MetroTile()
        {
            DefaultStyleKeyProperty.GetMetadata(typeof(MetroTile));
        }
        
        public static readonly DependencyProperty DisplayIconProperty =
            DependencyProperty.Register("DisplayIcon",
                                        typeof(ImageSource),
                                        typeof(MetroTile),
                                        new PropertyMetadata(null));

        [Description("The icon displayed in the tile."), Category("Common Properties")]
        public ImageSource DisplayIcon
        {
            get { return (ImageSource)this.GetValue(DisplayIconProperty); }
            set { this.SetValue(DisplayIconProperty, value); }
        }

        public static readonly DependencyProperty DisplayCountProperty =
            DependencyProperty.Register("DisplayCount",
                                        typeof(int),
                                        typeof(MetroTile),null);

        [Description("The count displayed in the tile."), Category("Common Properties")]
        public int DisplayCount
        {
            get { return (int)this.GetValue(DisplayCountProperty); }
            set { this.SetValue(DisplayCountProperty, value); }
        }

        [Description("The text displayed in the tile."), Category("Common Properties")]
        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register("DisplayText",
                                        typeof(string),
                                        typeof(MetroTile),
                                        new PropertyMetadata("Not set"));

        public string DisplayText
        {
            get { return (string)this.GetValue(DisplayTextProperty); }
            set { this.SetValue(DisplayTextProperty, value); }
        }
    }
}