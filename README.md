# BRYXImageViewer
An Image Viewer for use in C# projects, particularly for Windows 10 applications

![Example](https://raw.githubusercontent.com/bryx-inc/BRYXImageViewer/master/BRYXImageViewer/BRYXImageViewer/BRYXImageViewerExample2.png)

## Usage

Add the BryxImageViewer.xaml and BryxImageViewer.xaml.cs files to your project. In the example project, I added them to a controls folder that lives in the main project directory.

If you added it to a controls folder, you can import the folder by having `xmlns:controls="using:BRYXImageViewer.Controls"` in the topmost tag of your page:

```
<Page
    x:Class="BRYXImageViewer.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:BRYXImageViewer"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:controls="using:BRYXImageViewer.Controls"
    mc:Ignorable="d">
```

Then, in the rest of your xaml, you can put `<controls:BryxImageViewer></controls:BryxImageViewer>`
There are two requried properties when using this control: `ImageSource` and `ThumbnailSource`. In the example I just used the same picture, but some may want to use a shrunken-down version of the main image at a specific size.

You can also add the `Foreground` property to the tag, and it will apply that color to the X button used for closing the image. 

To close the image, you can either tap the image or tap the X button.

An example use of this in a page would look like this:

```
<controls:BryxImageViewer Margin="5" Foreground="Black"
                          ThumbnailSource="http://beginners-investing.com/images/learn-how-to-invest.jpg"
                          ImageSource="http://beginners-investing.com/images/learn-how-to-invest.jpg"/>
```

## Requirements

The example project as well as the control requires Windows 10

## Author

Robert Bond, robert.bond@bryx.com

## License

BRYXImageViewer is available under the MIT license. See the LICENSE file for more info.
