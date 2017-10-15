using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public MainPage()
        {
            this.InitializeComponent();

        }

        public class Info
        {
            public string width { get; set; }
            public string height { get; set; }
            public double woodLength { get; set; }
            public double glassArea { get; set; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // double width, height, woodLength, glassArea;

            Info parameters = new Info();


            parameters.width = txtWidth.Text;

            parameters.height = txtWidth.Text;


           // woodLength = 2 * (width * height) * 3.25;

            //glassArea = 2 * (width * height);

            this.Frame.Navigate(typeof(BlankPage1), parameters );
        }


    }
}
