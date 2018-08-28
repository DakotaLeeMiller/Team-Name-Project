﻿using System;
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
using Pokedata;
using System.Threading.Tasks;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectedPokemonPage : Page
    {
        private Pokemon selectedPokemon;
        public Pokemon SelectedPokemon
        {
            get => selectedPokemon;
            set
            {
                selectedPokemon = value;
                if (selectedPokemon.GenderRatio == null)
                {
                    maleRatio.Text = "NaN";
                    femaleRatio.Text = "NaN";
                }
                if (selectedPokemon.EvolveFrom == null) evolveFromPokemonButton.IsEnabled = false;
                if (selectedPokemon.EvolveTo == null) evolveToPokemonButton.IsEnabled = false;
            }
        }

        public SelectedPokemonPage()
        {
            this.InitializeComponent();
            this.Height = 720.0;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedPokemon = e.Parameter as Pokemon;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChoosingPage));
        }

        private void EvolveFromPokemonClick(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(SelectedPokemonPage), SelectedPokemon.EvolveFrom);
        }

        private void EvolveToPokemonClick(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(SelectedPokemonPage), SelectedPokemon.EvolveTo);
        }

        private async void playCrySound_Click(object sender, RoutedEventArgs e)
        {
            await PlayPokemonCry();
            playCrySound.IsEnabled = false;
            await Task.Delay(1000);
            playCrySound.IsEnabled = true;
        }

        public async Task PlayPokemonCry()
        {
            IStorageFile mediaFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri(SelectedPokemon.CrySoundSource));
            var stream = await mediaFile.OpenAsync(FileAccessMode.Read).AsTask();
            var mediaControl = new MediaElement();
            mediaControl.SetSource(stream, mediaFile.ContentType);
            mediaControl.Play();
        }
    }
}
