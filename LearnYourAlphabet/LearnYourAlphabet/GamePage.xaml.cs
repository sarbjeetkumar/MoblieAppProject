using LearnYourAlphabet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LearnYourAlphabet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        private ObservableCollection<Sound> Sounds;
        public GamePage()
        {
            this.InitializeComponent();
            Sounds = new ObservableCollection<Sound>();
            SoundDecide.GetAllSounds(Sounds);
        }

        private void MyListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AlphabetSoundGridView_ItemClick(object sender, ItemClickEventArgs e)
        {

            var sound = (Sound)e.ClickedItem;

            MyMediaElement.Source = new Uri(this.BaseUri, sound.AudioFile); //playing the sound

            // var dialog = new MessageDialog(sound.AudioFile.ToString());

            String lett = sound.Name.ToString();
            //String lett = sound.AudioFile.ToString().Substring(0,sound.a)
            //await dialog2.ShowAsync();
            //var user =  myTextBox.ToString();
            Popup popup = new Popup();


           popup.MaxHeight = 2000;
           popup.MaxWidth = 2000;
            //popup.VerticalOffset = 100;
         

          
            PopUpPage control = new PopUpPage(lett);
            
            popup.Child = control;
            popup.IsOpen = true;
           



        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
