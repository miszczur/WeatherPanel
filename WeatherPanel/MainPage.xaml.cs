using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace WeatherPanel
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Open the text file using a stream reader.
                var sr = File.ReadAllLines(@"C:\Users\jfmys\Downloads\123.txt");
                //var sr = File.ReadAllLines(@"C:\Users\jfmys\Downloads\3598f_DeviceLimits_.dat"); //new StreamReader("C:\\Users\\jfmys\\source\\repos\\WeatherPanel\\WeatherPanel\\3598f_DeviceLimits_.dat"))
                
                    // Read the stream as a string, and write the string to the console.
                    StringBuilder sb = new StringBuilder();

                    sb.Append(sr);
                    OutputText.Text = sb.ToString();
                
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }
        private void InputBox_GotFocus(object sender, RoutedEventArgs e) => InputText.Text = string.Empty;
    }
}
