﻿using LearnYourAlphabet.Models;
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

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
