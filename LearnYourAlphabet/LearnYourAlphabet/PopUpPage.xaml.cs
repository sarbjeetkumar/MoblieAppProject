using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnYourAlphabet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PopUpPage : Page
    {
        private String userEnteredLett = null;
        private bool correct = false;
        public PopUpPage(String lett)
        {
            this.InitializeComponent();
            this.userEnteredLett = lett;
            
            
        }

        
        

        private async void verifyLett(object sender, RoutedEventArgs e)
        {
            
            String lett = tbx.Text.ToString().ToLower();
           


            if (userEnteredLett.Equals(lett))
            {
                correct = true;

               
                var dialog = new MessageDialog("Well Done ! Perfect");

                //String lett = sound.AudioFile.ToString().Substring(0,sound.a)
                await dialog.ShowAsync();

            }

            else
            {

               
                var dialog = new MessageDialog( "Try Again !" );
                

                //String lett = sound.AudioFile.ToString().Substring(0,sound.a)
                await dialog.ShowAsync();
            }

            Grid g = sarab;
            g.Visibility = Visibility.Collapsed;
        }
        public bool isCorrect()
        {
            return correct;
        }
    }
}
