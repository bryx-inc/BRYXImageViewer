using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace BRYXImageViewer.Controls
{
    public sealed partial class BryxImageViewer : UserControl
    {
        public static readonly DependencyProperty ThumbnailSourceProperty = DependencyProperty.Register(
                "ThumbnailSource",
                typeof(string),
                typeof(BryxImageViewer),
                new PropertyMetadata(string.Empty)
            );

        public string ThumbnailSource
        {
            get { return (string) GetValue(ThumbnailSourceProperty); }
            set { SetValue(ThumbnailSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
                "ImageSource",
                typeof(string),
                typeof(BryxImageViewer),
                new PropertyMetadata(string.Empty)
            );

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public BryxImageViewer()
        {
            this.InitializeComponent();
        }

        private async void ThumbnailClicked(object sender, RoutedEventArgs e)
        {
            await FullSizeImage.ShowAsync();
        }

        private void CloseFullSizeClicked(object sender, RoutedEventArgs e)
        {
            FullSizeImage.Hide();
        }
    }
}
